using System;
using System.Linq;

namespace Ejercitacion.Ejercicios
{
    public class Facturacion
    {
        /// <summary>
        /// Ejercicio 5
        /// </summary>
        /// <param name="prefactura"></param>
        /// <param name="idHistorialProceso"></param>
        public String PrefacturarFNEE(Prefactura prefactura)
        {
            String resultado = String.Empty;

            try
            {
                Decimal cantidadenergia = this.GetCantidadEnergia(prefactura);

                Decimal precio = this.GetPrecioFNEE();

                resultado = String.Concat("Prefactura: ", cantidadenergia * precio);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new UnaExceptionX(ex);
            }
        }

        private Decimal GetCantidadEnergia(Prefactura prefactura)
        {
            var cantidadenergia = prefactura.PrefacturaDetalles.Where(p => p.EsFacturable)
                                                       .Sum(p => p.CantidadEnergiaPotencia);

            return (cantidadenergia == null) ? 0 : (Decimal)cantidadenergia;
        }

        private Decimal GetPrecioFNEE()
        {
            return 15.5M;
        }
    }
}
