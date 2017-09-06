using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;

namespace Moq
{
    public static class MockExtensions
    {
        public static void SetupOrder<T>(this Mock<T> mock, params Expression<Action<T>>[] expressions)
          where T : class
        {
            var currentOrderCalled = 0;

            for (var i = 0; i < expressions.Length; i++)
            {
                var expectedOrderCalled = i;

                mock.Setup(expressions[i]).Callback(
                  () =>
                  {
                      Assert.AreEqual(expectedOrderCalled, currentOrderCalled);

                      currentOrderCalled++;
                  });
            }
        }
    }
}
