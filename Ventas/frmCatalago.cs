using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using SQL;

namespace AreliPOS.Ventas
{
    public partial class frmCatalago : Form
    {
        List<Producto> catProductos;


        public frmCatalago()
        {
            InitializeComponent();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tbBuscar.Text.Length > 0)
            {
                dgvProductos.RowCount = 0;
                catProductos = DBQueriesGeneral.BuscaProductos(tbBuscar.Text);
                dgvProductos.RowCount = catProductos.Count;
            }
        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;                
            }
        }

        private void dgvProductos_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex < catProductos.Count)
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Value = catProductos[e.RowIndex]["codigo"];
                        break;
                    case 1:
                        e.Value = catProductos[e.RowIndex]["descripcion"];
                        break;
                    case 2:
                        e.Value = catProductos[e.RowIndex]["preciocosto"];
                        break;
                    case 3:
                        e.Value = catProductos[e.RowIndex]["precioventa"];
                        break;
                    case 4:
                        e.Value = catProductos[e.RowIndex]["existencia"];
                        break;
                    case 5:
                        e.Value = catProductos[e.RowIndex]["minimo"];
                        break;
                    case 6:
                        e.Value = catProductos[e.RowIndex]["nombredepartamento"];
                        break;
                    case 7:
                        e.Value = catProductos[e.RowIndex]["nombreproveedor"];
                        break;
                    case 8:
                        e.Value = catProductos[e.RowIndex]["nombreunidadproducto"];
                        break;
                    case 9:
                        e.Value = catProductos[e.RowIndex]["inventario"].ToBool();
                        break;
                    case 10:
                        e.Value = catProductos[e.RowIndex]["activo"].ToBool();
                        break;
                }
            }
        }
    }
}
