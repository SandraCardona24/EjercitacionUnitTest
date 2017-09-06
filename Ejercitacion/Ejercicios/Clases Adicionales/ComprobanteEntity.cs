using System;
using System.Collections.Generic;

namespace Implementaciones.Ejercicios
{
    public class ComprobanteEntity
    {
        public Object TipoComprobante { get; internal set; }

        public Object ParteContrato { get; internal set; }

        public DateTime? Fecha { get; internal set; }

        public Object EmpresaDestinataria { get; internal set; }

        public List<ComprobanteConceptoEntity> ComprobantesConcepto { get; internal set; }
    }
}