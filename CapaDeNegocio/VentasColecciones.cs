using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class VentasColecciones
    {
        private List<Producto> Listado(List<CapaDeDatos.Producto> productoDeCapaDeDatos)
        {
            List<Producto> listado = new List<Producto>();
            foreach (CapaDeDatos.Producto p in productoDeCapaDeDatos)
            {
                Producto productoNegocio = new Producto();

                productoNegocio.Id = p.idProducto;
                productoNegocio.CodigoBarra = p.codigoBarra;
                productoNegocio.Descripcion = p.descripcion;
                productoNegocio.PrecioCosto = p.precioCosto;
                productoNegocio.PrecioVenta = p.precioVenta;
                productoNegocio.Stock = p.stock;

                listado.Add(productoNegocio);
            }

            return listado;
        }

        public List<Producto> ReadAll()
        {
            var listado = CommonBC.ModeloVentas.Producto;
            return Listado(listado.ToList());
        }
    }
}
