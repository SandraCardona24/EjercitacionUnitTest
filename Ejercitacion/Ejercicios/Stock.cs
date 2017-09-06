using Ejercitacion.Ejercicios;
using System;

namespace Implementaciones.Ejercicios
{
    public class Stock
    {
        /// <summary>
        /// Ejercicio 1
        /// </summary>
        /// <param name="docStockProductoEstadoFE"></param>
        /// <returns></returns>
        public Int32 LeerStockProductoEstadoFE(DocStockProductoEstadoFE docStockProductoEstadoFE)
        {
            try
            {
                EntStockProductoEstado entStockProductoEstado = new EntStockProductoEstado();

                Int32 cantStock = entStockProductoEstado.LeerStockProductoEstadoFE(docStockProductoEstadoFE);

                return cantStock;
            }
            catch (Exception ex)
            {
                throw new UnaExceptionX(ex);
            }
        }

        /// <summary>
        /// Ejercicio 2
        /// </summary>
        /// <param name="tipoAlmacen"></param>
        /// <param name="idSucursal"></param>
        /// <param name="idProducto"></param>
        /// <param name="idTipoEstadoStock"></param>
        /// <returns></returns>
        public DocStockProductoEstado LeerStockProductoPorTipoAlmacen(Guid tipoAlmacen, Guid idSucursal, Guid idProducto, Guid idTipoEstadoStock)
        {
            DocStockProductoEstadoFE docFiltro = new DocStockProductoEstadoFE();

            var drFiltro = docFiltro.StockProductoEstadoFE.NewStockProductoEstadoFERow();

            drFiltro.IDSucursal = idSucursal;
            drFiltro.IDProducto = idProducto;
            drFiltro.IDTipoAlmacen = tipoAlmacen;
            drFiltro.IDTipoEstadoStock = idTipoEstadoStock;

            docFiltro.StockProductoEstadoFE.AddStockProductoEstadoFERow(drFiltro);

            return this.ObtenerStockProductoEstadoFE(docFiltro);
        }

        private DocStockProductoEstado ObtenerStockProductoEstadoFE(DocStockProductoEstadoFE filtroFE)
        {
            try
            {
                EntStockProductoEstado entStockProductoEstado = new EntStockProductoEstado();

                return entStockProductoEstado.ObtenerStockProductoEstadoFE(filtroFE);
            }
            catch (Exception ex)
            {
                throw new UnaExceptionX(ex);
            }
        }
    }
}