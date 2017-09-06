using System;

namespace Ejercitacion.Ejercicios
{
    public class UnaExceptionX : Exception
    {
        public UnaExceptionX(Exception ex)
            : base(ex.Message)
        {

        }
    }
}
