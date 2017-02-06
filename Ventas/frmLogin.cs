using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQL;

namespace AreliPOS.Ventas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (DBQueriesGeneral.LoginUser(tbUsuario.Text, tbClave.Text))
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(this, "Credenciales inválidas", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUsuario.Clear();
                tbClave.Clear();
                tbUsuario.Focus();
            }
        }
    }
}
