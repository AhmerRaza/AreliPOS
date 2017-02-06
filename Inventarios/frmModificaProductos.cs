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
    public partial class frmModificaProductos : Form
    {
        Producto[] productos;
        List<UnidadProducto> catUnidades;
        UnidadProducto unidad;
        List<Departamento> catDepartamentos;
        Departamento departamento;
        List<Proveedor> catProveedor;
        Proveedor proveedor;

        public frmModificaProductos(Producto[] productos)
        {
            InitializeComponent();

            // Se inicializa
            this.productos = productos;
            catDepartamentos = DBQueriesGeneral.ConsultaDepartamentosProductos();
            catUnidades = DBQueriesGeneral.ConsultaUnidadesProducto();
            catProveedor = DBQueriesGeneral.ConsultaProveedoresProductos();
            foreach (Departamento dep in catDepartamentos)
            {
                cmbDepartamento.Items.Add(dep["nombre"].ToString());
            }
            foreach (Proveedor prov in catProveedor)
            {
                cmbProveedor.Items.Add(prov["nombre"].ToString());
            }
            foreach (UnidadProducto unidad in catUnidades)
            {
                cmbUnidad.Items.Add(unidad["nombre"].ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Debe seleccionar un departamento.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Debe seleccionar un proveedor.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbUnidad.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Debe seleccionar una unidad.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (Producto _producto in productos)
            {
                _producto["inventario"] = new QueryExecutor.QueryResultData(chkInventario.Checked, QueryExecutor.DataType.BOOL);
                _producto["agranel"] = new QueryExecutor.QueryResultData(chkAgranel.Checked, QueryExecutor.DataType.BOOL);
                _producto["activo"] = new QueryExecutor.QueryResultData(chkActivo.Checked, QueryExecutor.DataType.BOOL);
                _producto["departamento"] = new QueryExecutor.QueryResultData(departamento["iddepartamento"].ToIn32(), QueryExecutor.DataType.INTEGER);
                _producto["nombredepartamento"] = new QueryExecutor.QueryResultData(departamento["nombre"].ToString(), QueryExecutor.DataType.STRING);
                _producto["proveedor"] = new QueryExecutor.QueryResultData(proveedor["idproveedor"].ToIn32(), QueryExecutor.DataType.INTEGER);
                _producto["nombreproveedor"] = new QueryExecutor.QueryResultData(proveedor["nombre"].ToString(), QueryExecutor.DataType.STRING);
                _producto["unidadproducto"] = new QueryExecutor.QueryResultData(unidad["idunidadproducto"].ToIn32(), QueryExecutor.DataType.INTEGER);
                _producto["nombreunidadproducto"] = new QueryExecutor.QueryResultData(unidad["nombre"].ToString(), QueryExecutor.DataType.STRING);
                _producto.Update(DBQueriesGeneral.executor);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            departamento = (cmbDepartamento.SelectedIndex >= 0) ? catDepartamentos[cmbDepartamento.SelectedIndex] : null;
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            proveedor = (cmbProveedor.SelectedIndex >= 0) ? catProveedor[cmbProveedor.SelectedIndex] : null;
        }

        private void cmbUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            unidad = (cmbUnidad.SelectedIndex >= 0) ? catUnidades[cmbUnidad.SelectedIndex] : null;
        }
    }
}
