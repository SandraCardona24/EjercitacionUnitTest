using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class Expected : ExpectedExceptionBaseAttribute
    {
        private readonly Type exceptionType;

        private readonly String message;

        public Expected(Type exceptionType, String message = null)
        {
            this.exceptionType = exceptionType;

            this.message = message;
        }

        protected override void Verify(Exception exception)
        {
            Boolean isSameType = exception.GetType() == this.exceptionType;

            Boolean isMessageMatch = this.message == null || exception.Message == this.message;

            Assert.IsTrue(isSameType && isMessageMatch);
        }
    }
}
