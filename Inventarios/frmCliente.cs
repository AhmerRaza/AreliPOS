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

namespace Inventarios
{
    public partial class frmCliente : Form
    {
        bool _inicializado;
        string _accion;
        Cliente _cliente;

        public frmCliente(string accion)
        {
            InitializeComponent();
            Inicializa(accion);
        }

        public frmCliente(string accion, ref Cliente cliente)
        {
            _cliente = cliente;
            InitializeComponent();
            Inicializa(accion);
        }

        private void Inicializa(string accion)
        {
            _accion = accion;
            Text = string.Format(Text, accion);
            switch (accion)
            {
                case "Agregar":
                    this.Icon = Properties.Resources.user_add;
                    btnAceptar.Image = Properties.Resources.tick_16;
                    btnAceptar.Text = "&Aceptar";
                    chkActivo.Checked = true;
                    _inicializado = true;
                    break;
                case "Editar":
                    this.Icon = Properties.Resources.user_edit;
                    btnAceptar.Image = Properties.Resources.disk_16;
                    btnAceptar.Text = "&Guardar";
                    break;
            }
            if (_cliente != null)
            {
                tbRFC.Text = _cliente["rfc"].Value.ToString();
                tbNombre.Text = _cliente["nombre"].Value.ToString();
                chkActivo.Checked = _cliente["activo"].ToBool();
                _inicializado = true;
            }
        }

        private void tbRFC_TextChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _cliente["rfc"].Value = tbRFC.Text;
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _cliente["nombre"].Value = tbNombre.Text;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_accion == "Agregar")
            {
                _cliente = new Cliente();
                _cliente["rfc"] = new QueryExecutor.QueryResultData(tbRFC.Text, QueryExecutor.DataType.STRING);
                _cliente["nombre"] = new QueryExecutor.QueryResultData(tbNombre.Text, QueryExecutor.DataType.STRING);
                DBQueriesGeneral.InsertaCliente(_cliente);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            if (_accion == "Editar")
            {
                _cliente.Update(DBQueriesGeneral.executor);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _cliente["activo"].Value = chkActivo.Checked ? 1 : 0;
            }
        }
    }
}
