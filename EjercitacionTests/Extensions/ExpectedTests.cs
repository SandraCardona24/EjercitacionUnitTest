using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Neoris.Fwk.Tests.Extensions
{
    [TestClass]
    public class ExpectedTests
    {
        [TestClass]
        public class ElMetodo_Verify : ExpectedTests
        {
            [Expected(typeof(ArgumentException))]
            [TestMethod]
            public void Captura_Correctamente_La_Excepcion_En_Caso_Que_Sea_Del_Mismo_Tipo()
            {
                //Arrange

                //Act
                throw new ArgumentException();

                //Assert
            }

            [Expected(typeof(ArgumentException), "Un Mensaje")]
            [TestMethod]
            public void Captura_Correctamente_La_Excepcion_En_Caso_Que_Sea_Del_Mismo_Tipo_Y_Mismo_Mensaje()
            {
                //Arrange

                //Act
                throw new ArgumentException("Un Mensaje");

                //Assert
            }
        }
    }
}
