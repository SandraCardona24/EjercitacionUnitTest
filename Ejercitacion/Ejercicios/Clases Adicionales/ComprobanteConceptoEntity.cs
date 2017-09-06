using System;

namespace Implementaciones.Ejercicios
{
    public class ComprobanteConceptoEntity
    {
        public int PorcentajeIVA { get; internal set; }

        public TipoConcepto TipoConcepto { get; internal set; }

        public Decimal ImporteNeto { get; internal set; }
    }
}