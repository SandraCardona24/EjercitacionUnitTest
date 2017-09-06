using System;
using System.Collections.Generic;

namespace Ejercitacion.Ejercicios
{
    public class Prefactura
    {
        public Int32 IdPrefactura { get; set; }

        public Int32 IdPadre { get; set; }

        public Int32 IdAgente { get; set; }

        public Int32 IdCliente { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public List<PrefacturaDetalle> PrefacturaDetalles { get; set; }
    }
}
