using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EjercitacionTests
{
    public abstract class TestClass<T>
        where T : class
    {
        public T Target { get; set; }

        [TestInitialize]
        public void Init()
        {
            this.Target = this.CreateTarget();
        }

        protected abstract T CreateTarget();
    }
}
