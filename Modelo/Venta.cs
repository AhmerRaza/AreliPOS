using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using QueryExecutor;

namespace Modelo
{
    public class Venta : AbstractModelo
    {
        Usuario cajero;
        Cliente cliente;
        DetalleVenta detalle;
        DateTime horaVenta;

        public Venta()
            :base()
        {
        }

        public Venta(Producto[] productos)
            : base()
        {
            detalle = new DetalleVenta();
            foreach (Producto pr in productos)
            {
                detalle.AgregaProducto(pr);
            }
        }
    }
}
