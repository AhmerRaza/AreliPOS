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
using QueryExecutor;
using Controles;

namespace Inventarios
{
    public partial class frmPrincipal : Form
    {
        // Catalagos
        List<UnidadProducto> catUnidades;
        List<Departamento> catDepartamentos;
        List<Proveedor> catProveedores;
        List<Cliente> catClientes;
        List<Producto> catProductos;

        // Seleccionados
        Departamento tdDepartamentoSeleccionado;
        Proveedor tpProveedorSeleccionado;
        Cliente tcClienteSeleccionado;
        Producto tpProductoSeleccionado;
        Producto tsProcuto;

        // Filtros
        Departamento filtroDepartamento;
        Proveedor filtroProveedor;

        int decimales = 0;
        int maxDecimales = 2;
        bool punto;

        #region Inicializar
        public frmPrincipal()
        {
            InitializeComponent();
            // Se inicializan los parametros de MySQL
            DBQueriesGeneral.executor = new MySQLExecutor(new MySQLParameters("localhost", 3306, "arelipos", "root", ""));
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        #endregion

        #region Funciones Generales

        private void Inicializar()
        {
            // Clientes
            tcMuestraClientes();

            // Unidades
            catUnidades = DBQueriesGeneral.ConsultaUnidadesProducto();
            //MuestraUnidades();

            // Departamentos
            tdMuestraDepartamentos();

            // Proveedores
            tpMuestraProveedores();

            // Productos
            tpMuestraProductos();
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            // Repinta el fondo de los tabPages
            tabPrincipal.SelectedTab.Refresh();
        }

        #endregion

        #region Inicio
        //
        #endregion

        #region Clientes

        private void tcMuestraClientes()
        {
            catClientes = DBQueriesGeneral.ConsultaClientes();
            dgvClientes.Rows.Clear();
            foreach (Cliente cliente in catClientes)
            {
                dgvClientes.Rows.Add(cliente["rfc"].Value, cliente["nombre"].Value, cliente["activo"].ToBool());
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender == btnAgregarCliente)
                {
                    frmCliente cliente = new frmCliente("Agregar");
                    if (cliente.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        tcMuestraClientes();
                    }
                }
                if (sender == btnEditarCliente)
                {
                    if (tcClienteSeleccionado["sololectura"].ToBool())
                    {
                        MessageBox.Show(this, "No se puede modificar este cliente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        frmCliente cliente = new frmCliente("Editar", ref tcClienteSeleccionado);
                        if (cliente.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                        {
                            tcMuestraCliente(tcClienteSeleccionado);
                        }
                    }
                }
                if (sender == btnEliminaCliente)
                {
                    if (tcClienteSeleccionado["sololectura"].ToBool())
                    {
                        MessageBox.Show(this, "No se puede eliminar este cliente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show(this, "¿Esta seguro de eliminar el cliente seleccionado?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (DBQueriesGeneral.EliminaCliente(tcClienteSeleccionado))
                            {
                                int row = dgvClientes.SelectedRows[0].Index;
                                dgvClientes.Rows.RemoveAt(row);
                                catClientes.RemoveAt(row);
                            }
                            else
                            {
                                MessageBox.Show(this, "No se puedo eliminar el cliente seleccionado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tcMuestraCliente(Cliente cliente)
        {
            cliente.Update(DBQueriesGeneral.executor);
            int row = dgvClientes.SelectedRows[0].Index;
            dgvClientes[0, row].Value = cliente["rfc"].Value;
            dgvClientes[1, row].Value = cliente["nombre"].Value;
            dgvClientes[2, row].Value = cliente["activo"].Value;
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            // Se selecciona el cliente
            if (dgvClientes.SelectedRows.Count > 0)
                tcClienteSeleccionado = catClientes[dgvClientes.SelectedRows[0].Index];
            else
                tcClienteSeleccionado = null;
        }

        #endregion

        #region Proveedores

        private void tpMuestraProveedores()
        {
            catProveedores = DBQueriesGeneral.ConsultaProveedoresProductos();
            dgvProveedores.Rows.Clear();
            cmbFiltroProveedor.Items.Clear();
            foreach (Proveedor prov in catProveedores)
            {
                dgvProveedores.Rows.Add(prov["nombre"].Value, prov["domingo"].ToBool(), prov["lunes"].ToBool(), prov["martes"].ToBool(), prov["miercoles"].ToBool(), prov["jueves"].ToBool(), prov["viernes"].ToBool(), prov["sabado"].ToBool(), prov["activo"].ToBool());
                dgvProveedores.Rows[dgvProveedores.RowCount - 1].Visible = !prov["filtro"].ToBool();

                cmbFiltroProveedor.Items.Add(prov["nombre"].ToString());
            }
            if (cmbFiltroProveedor.Items.Count > 0)
            {
                cmbFiltroProveedor.SelectedIndex = 0;
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender == btnAgregarProveedor)
                {
                    frmProveedor prov = new frmProveedor("Agregar");
                    if (prov.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        tpMuestraProveedores();
                    }
                }
                if (sender == btnEditarProveedor)
                {
                    if (tpProveedorSeleccionado["sololectura"].ToBool())
                    {
                        MessageBox.Show(this, "No se puede modificar este proveedor.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        frmProveedor prov = new frmProveedor("Editar", ref tpProveedorSeleccionado);
                        if (prov.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                        {
                            tpMuestraProveedor(tpProveedorSeleccionado);
                        }
                    }
                }
                if (sender == btnEliminaProveedor)
                {
                    if (tpProveedorSeleccionado["sololectura"].ToBool())
                    {
                        MessageBox.Show(this, "No se puede eliminar este proveedor.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (MessageBox.Show(this, "¿Esta seguro de eliminar el proveedor seleccionado?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (DBQueriesGeneral.EliminaProveedor(tpProveedorSeleccionado))
                            {
                                int row = dgvProveedores.SelectedRows[0].Index;
                                dgvProveedores.Rows.RemoveAt(row);
                                catProveedores.RemoveAt(row);
                                cmbFiltroProveedor.Items.RemoveAt(row);
                            }
                            else
                            {
                                MessageBox.Show(this, "No se pudo eliminar el proveedor seleccionado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tpMuestraProveedor(Proveedor proveedor)
        {
            // Se actualiza el proveedor
            proveedor.Update(DBQueriesGeneral.executor);

            // Actualiza el DataGridView
            int row = dgvProveedores.SelectedRows[0].Index;
            dgvProveedores[0, row].Value = proveedor["nombre"].Value;
            dgvProveedores[1, row].Value = proveedor["domingo"].Value;
            dgvProveedores[2, row].Value = proveedor["lunes"].Value;
            dgvProveedores[3, row].Value = proveedor["martes"].Value;
            dgvProveedores[4, row].Value = proveedor["miercoles"].Value;
            dgvProveedores[5, row].Value = proveedor["jueves"].Value;
            dgvProveedores[6, row].Value = proveedor["viernes"].Value;
            dgvProveedores[7, row].Value = proveedor["sabado"].Value;
            dgvProveedores[8, row].Value = proveedor["activo"].Value;

            // Se actualiza el ComboBox
            cmbFiltroProveedor.Items.RemoveAt(row);
            cmbFiltroProveedor.Items.Insert(row, proveedor["nombre"]);
        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                tpProveedorSeleccionado = catProveedores[dgvProveedores.SelectedRows[0].Index];
            }
            else
            {
                tpProveedorSeleccionado = null;
            }
        }

        #endregion

        #region Departamentos

        private void btnAgregaDepartamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender == btnAgregaDepartamento)
                {
                    frmDepartamento dep = new frmDepartamento("Agregar");
                    if (dep.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    {
                        tdMuestraDepartamentos();
                    }
                }
                if (tdDepartamentoSeleccionado == null)
                {
                    MessageBox.Show(this, "Debe seleccionar un departamento.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (sender == btnEditarDepartamento)
                    {
                        if (tdDepartamentoSeleccionado["sololectura"].ToBool())
                        {
                            MessageBox.Show(this, "No se puede modificar este proveedor.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            frmDepartamento dep = new frmDepartamento("Editar", tdDepartamentoSeleccionado);
                            if (dep.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                            {
                                tdMuestraDepartamento(tdDepartamentoSeleccionado);
                            }
                        }
                    }
                    if (sender == btnEliminaDepartamento)
                    {
                        if (tdDepartamentoSeleccionado["sololectura"].ToBool())
                        {
                            MessageBox.Show(this, "No se puede eliminar este proveedor.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (MessageBox.Show(this, "¿Esta seguro de eliminar el proveedor seleccionado?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                if (DBQueriesGeneral.EliminaDepartamento(tdDepartamentoSeleccionado))
                                {
                                    int row = dgvDepartamentos.SelectedRows[0].Index;
                                    dgvDepartamentos.Rows.RemoveAt(row);
                                    catDepartamentos.RemoveAt(row);
                                    cmbFiltroDepartamento.Items.RemoveAt(row);
                                }
                                else
                                {
                                    if(MessageBox.Show(this, "No se puedo eliminar el proveedor seleccionado.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        tdDepartamentoSeleccionado["activo"].Value = false.ToString();
                                        tdDepartamentoSeleccionado.Update(DBQueriesGeneral.executor);
                                        tdMuestraDepartamento(tdDepartamentoSeleccionado);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tdMuestraDepartamento(Departamento dep)
        {
            // Se actualiza la base de datos
            dep.Update(DBQueriesGeneral.executor);
            
            // Se actualiza el DataGridView
            int row = dgvDepartamentos.SelectedRows[0].Index;
            dgvDepartamentos[0, row].Value = dep["nombre"].Value;
            dgvDepartamentos[1, row].Value = dep["agranel"].Value;
            dgvDepartamentos[2, row].Value = dep["activo"].Value;

            // Se actualiza el ComboBox
            cmbFiltroDepartamento.Items.RemoveAt(row);
            cmbFiltroDepartamento.Items.Insert(row, dep["nombre"]);

        }

        private void tdMuestraDepartamentos()
        {
            catDepartamentos = DBQueriesGeneral.ConsultaDepartamentosProductos();
            dgvDepartamentos.Rows.Clear();
            cmbFiltroDepartamento.Items.Clear();
            foreach (Departamento dep in catDepartamentos)
            {
                dgvDepartamentos.Rows.Add(dep["nombre"].Value, dep["agranel"].ToBool(), dep["activo"].ToBool());
                dgvDepartamentos.Rows[dgvDepartamentos.RowCount - 1].Visible = !dep["filtro"].ToBool();

                cmbFiltroDepartamento.Items.Add(dep["nombre"].ToString());
            }
            if (cmbFiltroDepartamento.Items.Count > 0)
            {
                cmbFiltroDepartamento.SelectedIndex = 0;
            }
        }

        private void dgvDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartamentos.SelectedRows.Count > 0)
            {
                tdDepartamentoSeleccionado = catDepartamentos[dgvDepartamentos.SelectedRows[0].Index];
            }
            else
            {
                tdDepartamentoSeleccionado = null;
            }
        }

        #endregion

        #region Productos

        private void tpMuestraProductos()
        {
            catProductos = DBQueriesGeneral.ConsultaProductos();
            dgvProductos.RowCount = catProductos.Count;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (sender == btnAgregarProducto)
            {
                frmProducto prod = new frmProducto("Agregar");
                if (prod.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    tpMuestraProductos();
                    /*catProductos[dgvProductos.SelectedRows[0].Index] = prod.Producto;
                    dgvProductos.Refresh();*/
                }
            }
            if (tpProductoSeleccionado == null)
            {
                MessageBox.Show(this, "Debe seleccionar un producto.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (sender == btnEditarProducto)
                {
                    // Si solo es un producto
                    if (dgvProductos.SelectedRows.Count == 1)
                    {
                        frmProducto prod = new frmProducto("Editar", tpProductoSeleccionado);
                        if (prod.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                        {
                            tpMuestraProducto(dgvProductos.SelectedRows[0].Index, tpProductoSeleccionado, dgvProductos);
                        }
                    }
                    if (dgvProductos.SelectedRows.Count > 1)
                    {
                        List<Producto> seleccionados = new List<Producto>();
                        for (int i = 0; i < dgvProductos.SelectedRows.Count; i++)
                        {
                            seleccionados.Add(catProductos[dgvProductos.SelectedRows[i].Index]);
                        }
                        frmModificaProductos prods = new frmModificaProductos(seleccionados.ToArray());
                        if (prods.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            for (int i = 0; i < seleccionados.Count; i++)
                            {
                                tpMuestraProducto(dgvProductos.SelectedRows[i].Index, seleccionados[i], dgvProductos);
                            }
                        }
                    }
                }
                if (sender == btnEliminaProducto)
                {
                    bool plural = dgvProductos.SelectedRows.Count > 1;
                    if (MessageBox.Show(this, !plural ? "¿Esta seguro de eliminar el producto seleccionado?" : "¿Esta seguro de eliminar los productos seleccionados?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvProductos.SelectedRows)
                        {
                            if (DBQueriesGeneral.EliminaProducto(catProductos[row.Index]))
                            {
                                int rowIdx = dgvProductos.SelectedRows[0].Index;
                                dgvProductos.Rows.RemoveAt(rowIdx);
                                catProductos.RemoveAt(rowIdx);
                            }
                            else
                            {
                                if (MessageBox.Show(this, "No se puedo eliminar el producto seleccionado, ¿desea desactivarlo?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    catProductos[row.Index]["activo"].Value = false.ToString();
                                    catProductos[row.Index].Update(DBQueriesGeneral.executor);
                                    tpMuestraProducto(dgvProductos.SelectedRows[0].Index, catProductos[row.Index], dgvProductos);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void tpMuestraProducto(int row, Producto producto, DataGridView dgv)
        {
            dgv[0, row].Value = producto["codigo"].Value;
            dgv[1, row].Value = producto["descripcion"].Value;
            dgv[2, row].Value = producto["preciocosto"].Value;
            dgv[3, row].Value = producto["precioventa"].Value;
            dgv[4, row].Value = producto["existencia"].Value;
            dgv[5, row].Value = producto["minimo"].Value;
            dgv[6, row].Value = producto["nombredepartamento"].Value;
            dgv[7, row].Value = producto["nombreproveedor"].Value;
            dgv[8, row].Value = producto["nombreunidadproducto"].Value;
            dgv[9, row].Value = producto["inventario"].Value;
        }

        #endregion

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            tpProductoSeleccionado = (dgvProductos.SelectedRows.Count > 0) ? catProductos[dgvProductos.SelectedRows[0].Index] : null;
        }

        private void tabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabPrincipal.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    tbProducto.Focus();
                    break;
            }
        }

        private void tbProductoSurtir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                BuscarProducto();
            }
        }

        private void tbCantidadSurtir_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validas = ".0123456789";
            if (!char.IsControl(e.KeyChar))
            {
                punto = e.KeyChar == '.';
                if (!validas.Contains(e.KeyChar) && decimales < maxDecimales)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnSurtir_Click(object sender, EventArgs e)
        {
            if (tsProcuto == null)
            {
                MessageBox.Show(this, "Debe seleccionar un producto", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double surtir = Convert.ToDouble(ntbSurtir.Text);
                bool agranel = tsProcuto["agranel"].ToBool();
                int isuritr = (int)surtir;
                bool iguales = surtir == isuritr;
                if (!agranel && surtir != isuritr)
                {
                    MessageBox.Show(this, "Este producto solo permite valores enteros.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ntbSurtir.Focus();
                    return;
                }
                tsProcuto["existencia"].Value = tsProcuto["existencia"].ToDouble() + surtir;
                tsProcuto.Update(DBQueriesGeneral.executor);
                tbExistencia.Text = tsProcuto["existencia"].ToDouble().ToString("N2");
                ntbSurtir.Clear();
                MessageBox.Show(this, "Se ha surtido correctamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BuscarProducto()
        {
            tsProcuto = DBQueriesGeneral.ConsultaProductoPorCodigo(tbProducto.Text);
            if (tsProcuto != null)
            {
                tbProducto.SelectAll();
                tbDescripcion.Text = tsProcuto["descripcion"].ToString();
                tbExistencia.Text = tsProcuto["existencia"].ToDouble().ToString("N2");
                ntbSurtir.Focus();
            }
            else
            {
                MessageBox.Show(this, "No se encontró un producto con ese código.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbFiltroDescripcion_TextChanged(object sender, EventArgs e)
        {
            BuscaProductoFiltros();
        }

        private void BuscaProductoFiltros()
        {
            dgvProductos.RowCount = 0;
            catProductos = DBQueriesGeneral.ConsultaProductosFiltros(tbFiltroDescripcion.Text, filtroDepartamento, filtroProveedor);
            dgvProductos.RowCount = catProductos.Count;
        }

        private void cmbFiltroDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroDepartamento = (cmbFiltroDepartamento.Items.Count >= 0) ? catDepartamentos[cmbFiltroDepartamento.SelectedIndex] : null;
            BuscaProductoFiltros();
            dgvProductos.Focus();
        }

        private void cmbFiltroProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtroProveedor = (cmbFiltroProveedor.Items.Count >= 0) ? catProveedores[cmbFiltroProveedor.SelectedIndex] : null;
            BuscaProductoFiltros();
            dgvProductos.Focus();
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
