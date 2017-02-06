using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QueryExecutor;
using SQL;
using Modelo;

namespace AreliPOS.Ventas
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
            // Se inicializan los parametros de MySQL
            MySQLParameters parametros = new MySQLParameters("localhost", 3306, "arelipos", "root", "");
            DBQueriesGeneral.executor = new MySQLExecutor(parametros);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Se hace el login
            /*frmLogin login = new frmLogin();
            if (login.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
            {
                Close();
            }
            else
            {
                Opacity = 100;
                for (int i = 0; i < 10; i++)
                {
                    dgvDetalleVenta.Rows.Add("PROD" + (i + 1).ToString(), "PRODUCTO DE PRUEBA " + (i + 1).ToString(), 1, 10.00, 10.00);
                }
            }*/
        }

        private void btnCatalago_Click(object sender, EventArgs e)
        {
            frmCatalago cat = new frmCatalago();
            cat.ShowDialog(this);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            frmCobro cob = new frmCobro();
            cob.ShowDialog(this);
        }

        private void tbEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                Producto prod = DBQueriesGeneral.ConsultaProductoPorCodigo(tbEntrada.Text);
                tbEntrada.Clear();
                if (prod != null)
                {
                    MessageBox.Show(prod["descripcion"].ToString());
                }
                else
                {
                    MessageBox.Show("No encontrado");
                }
            }
        }
    }
}
