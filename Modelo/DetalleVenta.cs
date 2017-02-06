using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QueryExecutor;

namespace Modelo
{
    public class DetalleVenta : AbstractModelo
    {
        List<Producto> productos;

        public DetalleVenta()
            : base()
        {
            productos = new List<Producto>();
        }

        public void AgregaProducto(Producto producto)
        {
            productos.Add(producto);
        }
    }
}
