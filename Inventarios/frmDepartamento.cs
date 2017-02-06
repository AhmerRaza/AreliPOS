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
    public partial class frmDepartamento : Form
    {
        string _accion;
        bool _inicializado;
        Departamento _dep;

        public frmDepartamento(string accion)
        {
            InitializeComponent();
            Inicializa(accion);
        }

        public frmDepartamento(string accion, Departamento dep)
        {
            _dep = dep;
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
                    this.Icon = Properties.Resources.category_add;
                    btnAceptar.Image = Properties.Resources.tick_16;
                    btnAceptar.Text = "&Aceptar";
                    chkActivo.Checked = true;
                    _inicializado = true;
                    break;
                case "Editar":
                    this.Icon = Properties.Resources.category_edit;
                    btnAceptar.Image = Properties.Resources.disk_16;
                    btnAceptar.Text = "&Guardar";
                    break;
            }
            if (_dep != null)
            {
                tbNombre.Text = _dep["nombre"].Value.ToString();
                chkAgranel.Checked = _dep["agranel"].ToBool();
                chkActivo.Checked = _dep["activo"].ToBool();
                _inicializado = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_accion == "Agregar")
            {
                _dep = new Departamento();
                _dep["nombre"] = new QueryExecutor.QueryResultData(tbNombre.Text, QueryExecutor.DataType.STRING);
                _dep["agranel"] = new QueryExecutor.QueryResultData(chkAgranel.Checked, QueryExecutor.DataType.BOOL);
                _dep["activo"] = new QueryExecutor.QueryResultData(chkActivo.Checked, QueryExecutor.DataType.BOOL);
                DBQueriesGeneral.InsertaDepartamento(_dep);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            if (_accion == "Editar")
            {
                _dep["nombre"] = new QueryExecutor.QueryResultData(tbNombre.Text, QueryExecutor.DataType.STRING);
                _dep["agranel"] = new QueryExecutor.QueryResultData(chkAgranel.Checked, QueryExecutor.DataType.BOOL);
                _dep["activo"] = new QueryExecutor.QueryResultData(chkActivo.Checked, QueryExecutor.DataType.BOOL);
                _dep.Update(DBQueriesGeneral.executor);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _dep["nombre"].Value = tbNombre.Text;
            }
        }

        private void chkBascula_CheckedChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _dep["agranel"].Value = chkAgranel.Checked;
            }
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _dep["activo"].Value = chkActivo.Checked;
            }
        }
    }
}
