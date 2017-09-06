using Implementaciones.Ejercicios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercitacion.Ejercicios
{
    public class Comprobante
    {
        /// <summary>
        /// Ejercicio 3
        /// </summary>
        /// <param name="comprobante"></param>
        /// <returns></returns>
        public ITipoComprobante CrearTipoComprobante(ComprobanteEntity comprobante)
        {
            if (comprobante.TipoComprobante != null)
                return new TipoComprobante1();

            else if (comprobante.ParteContrato != null)
                return new TipoComprobante2();

            throw new InvalidOperationException("No se pudo resolver el tipo de comprobante");
        }

        /// <summary>
        /// Ejercicio 4
        /// </summary>
        /// <param name="comprobante"></param>
        public void Validar(ComprobanteEntity comprobante)
        {
            var errores = new List<String>();

            if (comprobante.TipoComprobante == null)
                errores.Add("Tipo comprobante es obligatorio");

            if (comprobante.ParteContrato == null)
                errores.Add("Parte contrato es obligatorio");

            if (comprobante.Fecha == null)
                errores.Add("La fecha del comprobante es obligatorio");

            if (comprobante.EmpresaDestinataria == null)
                errores.Add("La empresa destinataria es obligatoria");

            var importeNeto = comprobante.ComprobantesConcepto.Where(cc => cc.PorcentajeIVA != 0 && cc.TipoConcepto.Id == 1).Sum(cc => cc.ImporteNeto);

            var ImporteNetoADeducir = comprobante.ComprobantesConcepto.Where(cc => cc.PorcentajeIVA != 0 && cc.TipoConcepto.Id == 2).Sum(cc => cc.ImporteNeto);

            if ((importeNeto - ImporteNetoADeducir) < 0)
                errores.Add("El importe neto no puede ser igual a cero.");

            var importeNetoNoGravadoAFacturar = comprobante.ComprobantesConcepto.Where(cc => cc.PorcentajeIVA == 0 && cc.TipoConcepto.Id == 1).Sum(cc => cc.ImporteNeto);

            var importeNetoNoGravadoADeducir = comprobante.ComprobantesConcepto.Where(cc => cc.PorcentajeIVA == 0 && cc.TipoConcepto.Id == 2).Sum(cc => cc.ImporteNeto);

            if ((importeNetoNoGravadoAFacturar - importeNetoNoGravadoADeducir) < 0)
                errores.Add("El importe neto gravado tiene que ser mayor a cero");

            if (errores.Any())
                throw new ValidationException(String.Join(Environment.NewLine, errores));
        }
    }
}
