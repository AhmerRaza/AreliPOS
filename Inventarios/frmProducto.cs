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
    public partial class frmProducto : Form
    {
        Producto producto;
        string _accion;
        Producto _producto;
        List<UnidadProducto> catUnidades;
        UnidadProducto unidad;
        List<Departamento> catDepartamentos;
        Departamento departamento;
        List<Proveedor> catProveedor;
        Proveedor proveedor;
        bool _inicializado;

        public frmProducto(string accion)
        {
            InitializeComponent();
            Inicializa(accion);
        }

        public frmProducto(string accion, Producto producto)
        {
            _producto = producto;
            InitializeComponent();
            Inicializa(accion);
        }

        private void Inicializa(string accion)
        {
            _accion = accion;
            catDepartamentos = DBQueriesGeneral.ConsultaDepartamentosProductos();
            catUnidades = DBQueriesGeneral.ConsultaUnidadesProducto();
            catProveedor = DBQueriesGeneral.ConsultaProveedoresProductos();

            // Departamento
            int dep = -1;
            for (int i = 0; i < catDepartamentos.Count; i++)
            {
                cmbDepartamento.Items.Add(catDepartamentos[i]["nombre"].ToString());
                if (_accion == "Editar")
                {
                    if (catDepartamentos[i]["iddepartamento"].ToIn32() == _producto["departamento"].ToIn32())
                    {
                        dep = i;
                    }
                }
                else
                {
                    if (catDepartamentos[i]["pordefecto"].ToBool())
                    {
                        dep = i;
                    }
                }
            }

            // Unidades
            int uni = 0;
            for (int i = 0; i < catUnidades.Count; i++)
            {
                cmbUnidad.Items.Add(catUnidades[i]["nombre"].ToString());
                if (_accion == "Editar")
                {
                    if (catUnidades[i]["idunidadproducto"].ToIn32() == _producto["unidadproducto"].ToIn32())
                    {
                        uni = i;
                    }
                }
                else
                {
                    if (catUnidades[i]["pordefecto"].ToBool())
                    {
                        uni = i;
                    }
                }
            }

            // Proveedores
            int prov = -1;
            for (int i = 0; i < catProveedor.Count; i++)
            {
                cmbProveedor.Items.Add(catProveedor[i]["nombre"].ToString());
                if (_accion == "Editar")
                {
                    if (catProveedor[i]["idproveedor"].ToIn32() == _producto["proveedor"].ToIn32())
                    {
                        prov = i;
                    }
                }
                else
                {
                    if (catProveedor[i]["pordefecto"].ToBool())
                    {
                        prov = i;
                    }
                }
            }
            cmbDepartamento.SelectedIndex = dep;
            cmbProveedor.SelectedIndex = prov;
            cmbUnidad.SelectedIndex = uni;

            Text = string.Format(Text, accion);
            switch (accion)
            {
                case "Agregar":
                    this.Icon = Properties.Resources.box_add;
                    btnAceptar.Image = Properties.Resources.tick_16;
                    btnAceptar.Text = "&Aceptar";
                    chkActivo.Checked = true;
                    _inicializado = true;
                    break;
                case "Editar":
                    this.Icon = Properties.Resources.box_edit;
                    btnAceptar.Image = Properties.Resources.disk_16;
                    btnAceptar.Text = "&Guardar";
                    break;
            }
            if (_producto != null)
            {
                tbCodigo.Text = _producto["codigo"].Value.ToString();
                tbDescripcion.Text = _producto["descripcion"].Value.ToString();
                ntbCosto.Text = _producto["preciocosto"].Value.ToString();
                ntbPrecio.Text = _producto["precioventa"].Value.ToString();
                ntbExistencia.Text = _producto["existencia"].Value.ToString();
                ntbMinimo.Text = _producto["minimo"].Value.ToString();
                chkInventario.Checked = _producto["inventario"].ToBool();
                chkAgranel.Checked = _producto["agranel"].ToBool();
                chkActivo.Checked = _producto["activo"].ToBool();
                _inicializado = true;
            }
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _producto["codigo"].Value = tbCodigo.Text;
            }
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _producto["descripcion"].Value = tbDescripcion.Text;
            }
        }

        private void tbCosto_TextChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _producto["preciocosto"].Value = ntbCosto.Text;
            }
        }

        private void tbPrecio_TextChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _producto["precioventa"].Value = ntbPrecio.Text;
            }
        }

        private void tbExistencia_TextChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _producto["existencia"].Value = ntbExistencia.Text;
            }
        }

        private void tbMinimo_TextChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _producto["minimo"].Value = ntbMinimo.Text;
            }
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _producto["activo"].Value = chkActivo.Checked;
            }
        }

        private void chkAgranel_CheckedChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _producto["agranel"].Value = chkAgranel.Checked;
            }
        }

        private void chkInventario_CheckedChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Editar")
            {
                _producto["inventario"].Value = chkActivo.Checked;
            }
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_inicializado && _accion == "Agregar" && cmbUnidad.SelectedIndex > 0)
            {
                chkAgranel.Checked = catUnidades[cmbUnidad.SelectedIndex]["agranel"].ToBool();
            }
            unidad = (cmbUnidad.SelectedIndex >= 0) ? catUnidades[cmbUnidad.SelectedIndex] : null;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Producto _producto = null;
            if (_accion == "Agregar")
            {
                producto = DBQueriesGeneral.ConsultaProductoPorCodigo(tbCodigo.Text);
                if (producto != null)
                {
                    if (MessageBox.Show(this, string.Format("Ya existe un producto registrado con el código: {0}, ¿Desea reemplazarlo?", tbCodigo.Text), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        producto["codigo"] = new QueryExecutor.QueryResultData(tbCodigo.Text, QueryExecutor.DataType.STRING);
                        producto["descripcion"] = new QueryExecutor.QueryResultData(tbDescripcion.Text, QueryExecutor.DataType.STRING);
                        producto["preciocosto"] = new QueryExecutor.QueryResultData(ntbCosto.Text, QueryExecutor.DataType.DOUBLE);
                        producto["precioventa"] = new QueryExecutor.QueryResultData(ntbPrecio.Text, QueryExecutor.DataType.DOUBLE);
                        producto["existencia"] = new QueryExecutor.QueryResultData(ntbExistencia.Text, QueryExecutor.DataType.DOUBLE);
                        producto["minimo"] = new QueryExecutor.QueryResultData(ntbMinimo.Text, QueryExecutor.DataType.DOUBLE);
                        producto["departamento"] = new QueryExecutor.QueryResultData(departamento["iddepartamento"].ToIn32(), QueryExecutor.DataType.INTEGER);
                        producto["nombredepartamento"] = new QueryExecutor.QueryResultData(departamento["nombre"].ToString(), QueryExecutor.DataType.STRING);
                        producto["proveedor"] = new QueryExecutor.QueryResultData(proveedor["idproveedor"].ToIn32(), QueryExecutor.DataType.INTEGER);
                        producto["nombreproveedor"] = new QueryExecutor.QueryResultData(proveedor["nombre"].ToString(), QueryExecutor.DataType.STRING);
                        producto["unidadproducto"] = new QueryExecutor.QueryResultData(unidad["idunidadproducto"].ToIn32(), QueryExecutor.DataType.INTEGER);
                        producto["nombreunidadproducto"] = new QueryExecutor.QueryResultData(unidad["nombre"].ToString(), QueryExecutor.DataType.STRING);
                        producto["inventario"] = new QueryExecutor.QueryResultData(chkInventario.Checked, QueryExecutor.DataType.BOOL);
                        producto["agranel"] = new QueryExecutor.QueryResultData(chkAgranel.Checked, QueryExecutor.DataType.BOOL);
                        producto["activo"] = new QueryExecutor.QueryResultData(chkActivo.Checked, QueryExecutor.DataType.BOOL);
                        producto.Update(DBQueriesGeneral.executor);
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    _producto = new Producto();
                    _producto["codigo"] = new QueryExecutor.QueryResultData(tbCodigo.Text, QueryExecutor.DataType.STRING);
                    _producto["descripcion"] = new QueryExecutor.QueryResultData(tbDescripcion.Text, QueryExecutor.DataType.STRING);
                    _producto["preciocosto"] = new QueryExecutor.QueryResultData(ntbCosto.Text, QueryExecutor.DataType.DOUBLE);
                    _producto["precioventa"] = new QueryExecutor.QueryResultData(ntbPrecio.Text, QueryExecutor.DataType.DOUBLE);
                    _producto["existencia"] = new QueryExecutor.QueryResultData(ntbExistencia.Text, QueryExecutor.DataType.DOUBLE);
                    _producto["minimo"] = new QueryExecutor.QueryResultData(ntbMinimo.Text, QueryExecutor.DataType.DOUBLE);
                    _producto["departamento"] = new QueryExecutor.QueryResultData(departamento["iddepartamento"].ToIn32(), QueryExecutor.DataType.INTEGER);
                    _producto["nombredepartamento"] = new QueryExecutor.QueryResultData(departamento["nombre"].ToString(), QueryExecutor.DataType.STRING);
                    _producto["proveedor"] = new QueryExecutor.QueryResultData(proveedor["idproveedor"].ToIn32(), QueryExecutor.DataType.INTEGER);
                    _producto["nombreproveedor"] = new QueryExecutor.QueryResultData(proveedor["nombre"].ToString(), QueryExecutor.DataType.STRING);
                    _producto["unidadproducto"] = new QueryExecutor.QueryResultData(unidad["idunidadproducto"].ToIn32(), QueryExecutor.DataType.INTEGER);
                    _producto["nombreunidadproducto"] = new QueryExecutor.QueryResultData(unidad["nombre"].ToString(), QueryExecutor.DataType.STRING);
                    _producto["inventario"] = new QueryExecutor.QueryResultData(chkInventario.Checked, QueryExecutor.DataType.BOOL);
                    _producto["agranel"] = new QueryExecutor.QueryResultData(chkAgranel.Checked, QueryExecutor.DataType.BOOL);
                    _producto["activo"] = new QueryExecutor.QueryResultData(chkActivo.Checked, QueryExecutor.DataType.BOOL);
                    DBQueriesGeneral.InsertaProducto(_producto);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    Close();
                }
            }
            if (_accion == "Editar")
            {
                _producto["departamento"] = new QueryExecutor.QueryResultData(departamento["iddepartamento"].ToIn32(), QueryExecutor.DataType.INTEGER);
                _producto["nombredepartamento"] = new QueryExecutor.QueryResultData(departamento["nombre"].ToString(), QueryExecutor.DataType.STRING);
                _producto["proveedor"] = new QueryExecutor.QueryResultData(proveedor["idproveedor"].ToIn32(), QueryExecutor.DataType.INTEGER);
                _producto["nombreproveedor"] = new QueryExecutor.QueryResultData(proveedor["nombre"].ToString(), QueryExecutor.DataType.STRING);
                _producto["unidadproducto"] = new QueryExecutor.QueryResultData(unidad["idunidadproducto"].ToIn32(), QueryExecutor.DataType.INTEGER);
                _producto["nombreunidadproducto"] = new QueryExecutor.QueryResultData(unidad["nombre"].ToString(), QueryExecutor.DataType.STRING);
                _producto.Update(DBQueriesGeneral.executor);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        public Producto Producto
        {
            get { return producto; }
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            departamento = (cmbDepartamento.SelectedIndex >= 0) ? catDepartamentos[cmbDepartamento.SelectedIndex] : null;
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            proveedor = (cmbProveedor.SelectedIndex >= 0) ? catProveedor[cmbProveedor.SelectedIndex] : null;
        }
    }
}
