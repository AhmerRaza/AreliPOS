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
    public partial class frmProveedor : Form
    {
        bool _inicializado;
        string _accion;
        Proveedor _proveedor;

        public frmProveedor(string accion)
        {
            InitializeComponent();
            Inicializa(accion);
        }

        public frmProveedor(string accion, ref Proveedor proveedor)
        {
            _proveedor = proveedor;
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
                    this.Icon = Properties.Resources.lorry_add;
                    btnAceptar.Image = Properties.Resources.tick_16;
                    btnAceptar.Text = "&Aceptar";
                    chkActivo.Checked = true;
                    _inicializado = true;
                    break;
                case "Editar":
                    this.Icon = Properties.Resources.lorry_edit;
                    btnAceptar.Image = Properties.Resources.disk_16;
                    btnAceptar.Text = "&Guardar";
                    break;
            }
            if (_proveedor != null)
            {
                tbNombre.Text = _proveedor["nombre"].Value.ToString();
                chkDomingo.Checked = _proveedor["domingo"].ToBool();
                chkLunes.Checked = _proveedor["lunes"].ToBool();
                chkMartes.Checked = _proveedor["martes"].ToBool();
                chkMiercoles.Checked = _proveedor["miercoles"].ToBool();
                chkJueves.Checked = _proveedor["jueves"].ToBool();
                chkViernes.Checked = _proveedor["viernes"].ToBool();
                chkSabado.Checked = _proveedor["sabado"].ToBool();
                chkActivo.Checked = _proveedor["activo"].ToBool();
                _inicializado = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_accion == "Agregar")
            {
                _proveedor = new Proveedor();
                _proveedor["nombre"] = new QueryExecutor.QueryResultData(tbNombre.Text, QueryExecutor.DataType.STRING);
                _proveedor["domingo"] = new QueryExecutor.QueryResultData(chkDomingo.Checked, QueryExecutor.DataType.BOOL);
                _proveedor["lunes"] = new QueryExecutor.QueryResultData(chkLunes.Checked, QueryExecutor.DataType.BOOL);
                _proveedor["martes"] = new QueryExecutor.QueryResultData(chkMartes.Checked, QueryExecutor.DataType.BOOL);
                _proveedor["miercoles"] = new QueryExecutor.QueryResultData(chkMiercoles.Checked, QueryExecutor.DataType.BOOL);
                _proveedor["jueves"] = new QueryExecutor.QueryResultData(chkJueves.Checked, QueryExecutor.DataType.BOOL);
                _proveedor["viernes"] = new QueryExecutor.QueryResultData(chkViernes.Checked, QueryExecutor.DataType.BOOL);
                _proveedor["sabado"] = new QueryExecutor.QueryResultData(chkSabado.Checked, QueryExecutor.DataType.BOOL);
                _proveedor["activo"] = new QueryExecutor.QueryResultData(chkActivo.Checked, QueryExecutor.DataType.BOOL);
                DBQueriesGeneral.InsertaProveedor(_proveedor);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            if (_accion == "Editar")
            {
                _proveedor.Update(DBQueriesGeneral.executor);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void chkDomingo_CheckedChanged(object sender, EventArgs e)
        {
            string dia = string.Empty;

            if (sender == chkDomingo)
            {
                dia = "domingo";
            }
            if (sender == chkLunes)
            {
                dia = "lunes";
            }
            if (sender == chkMartes)
            {
                dia = "martes";
            }
            if (sender == chkMiercoles)
            {
                dia = "miercoles";
            }
            if (sender == chkJueves)
            {
                dia = "jueves";
            }
            if (sender == chkViernes)
            {
                dia = "viernes";
            }
            if (sender == chkSabado)
            {
                dia = "sabado";
            }

            if (_inicializado && _accion == "Editar")
            {
                _proveedor[dia].Value = ((CheckBox)sender).Checked;
            }
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            tbNombre.Focus();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _proveedor["nombre"].Value = tbNombre.Text;
            }
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _proveedor["activo"].Value = chkActivo.Checked;
            }
        }
    }
}
