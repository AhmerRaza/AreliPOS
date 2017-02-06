namespace Inventarios
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.tabSurtir = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSurtir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ntbSurtir = new Controles.NumericTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbExistencia = new System.Windows.Forms.TextBox();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ccRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClienteActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEliminaCliente = new System.Windows.Forms.Button();
            this.ilIconos32 = new System.Windows.Forms.ImageList(this.components);
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.tabProveedores = new System.Windows.Forms.TabPage();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnEliminaProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.colNombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomingo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLunes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMartes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMiercoles = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colJueves = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colViernes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSabado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProvActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabDepartamentos = new System.Windows.Forms.TabPage();
            this.btnEliminaDepartamento = new System.Windows.Forms.Button();
            this.btnEditarDepartamento = new System.Windows.Forms.Button();
            this.btnAgregaDepartamento = new System.Windows.Forms.Button();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDepActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cmbFiltroProveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFiltroDepartamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFiltroDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colProdCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdInventario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProdActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEliminaProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.ilIconos16 = new System.Windows.Forms.ImageList(this.components);
            this.tabPrincipal.SuspendLayout();
            this.tabSurtir.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.tabDepartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.tabProductos.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrincipal.Controls.Add(this.tabInicio);
            this.tabPrincipal.Controls.Add(this.tabSurtir);
            this.tabPrincipal.Controls.Add(this.tabClientes);
            this.tabPrincipal.Controls.Add(this.tabProveedores);
            this.tabPrincipal.Controls.Add(this.tabDepartamentos);
            this.tabPrincipal.Controls.Add(this.tabProductos);
            this.tabPrincipal.ImageList = this.ilIconos32;
            this.tabPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(868, 546);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.SelectedIndexChanged += new System.EventHandler(this.tabPrincipal_SelectedIndexChanged);
            // 
            // tabInicio
            // 
            this.tabInicio.ImageKey = "go-home-32.png";
            this.tabInicio.Location = new System.Drawing.Point(4, 39);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(860, 503);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // tabSurtir
            // 
            this.tabSurtir.Controls.Add(this.groupBox1);
            this.tabSurtir.ImageKey = "box_surtir_32.png";
            this.tabSurtir.Location = new System.Drawing.Point(4, 39);
            this.tabSurtir.Name = "tabSurtir";
            this.tabSurtir.Padding = new System.Windows.Forms.Padding(3);
            this.tabSurtir.Size = new System.Drawing.Size(860, 503);
            this.tabSurtir.TabIndex = 5;
            this.tabSurtir.Text = "Surtir";
            this.tabSurtir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSurtir);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 415);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Surtir Producto";
            // 
            // btnSurtir
            // 
            this.btnSurtir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurtir.Image = global::Inventarios.Properties.Resources.box_add_32;
            this.btnSurtir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSurtir.Location = new System.Drawing.Point(271, 150);
            this.btnSurtir.Name = "btnSurtir";
            this.btnSurtir.Size = new System.Drawing.Size(104, 53);
            this.btnSurtir.TabIndex = 3;
            this.btnSurtir.Text = "&Surtir";
            this.btnSurtir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSurtir.UseVisualStyleBackColor = true;
            this.btnSurtir.Click += new System.EventHandler(this.btnSurtir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ntbSurtir, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbProducto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbExistencia, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 125);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ntbSurtir
            // 
            this.ntbSurtir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntbSurtir.HaveDot = false;
            this.ntbSurtir.Location = new System.Drawing.Point(102, 97);
            this.ntbSurtir.Name = "ntbSurtir";
            this.ntbSurtir.Size = new System.Drawing.Size(263, 24);
            this.ntbSurtir.TabIndex = 4;
            this.ntbSurtir.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Surtir:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbProducto
            // 
            this.tbProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProducto.Location = new System.Drawing.Point(102, 4);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(263, 24);
            this.tbProducto.TabIndex = 1;
            this.tbProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductoSurtir_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Existencia:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescripcion.Location = new System.Drawing.Point(102, 35);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.Size = new System.Drawing.Size(263, 24);
            this.tbDescripcion.TabIndex = 4;
            this.tbDescripcion.TabStop = false;
            // 
            // tbExistencia
            // 
            this.tbExistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbExistencia.Location = new System.Drawing.Point(102, 66);
            this.tbExistencia.Name = "tbExistencia";
            this.tbExistencia.ReadOnly = true;
            this.tbExistencia.Size = new System.Drawing.Size(263, 24);
            this.tbExistencia.TabIndex = 5;
            this.tbExistencia.TabStop = false;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.dgvClientes);
            this.tabClientes.Controls.Add(this.btnEliminaCliente);
            this.tabClientes.Controls.Add(this.btnEditarCliente);
            this.tabClientes.Controls.Add(this.btnAgregarCliente);
            this.tabClientes.ImageKey = "group_32.png";
            this.tabClientes.Location = new System.Drawing.Point(4, 39);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(860, 503);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccRFC,
            this.ccNombre,
            this.colClienteActivo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.Location = new System.Drawing.Point(83, 6);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(771, 491);
            this.dgvClientes.TabIndex = 3;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // ccRFC
            // 
            this.ccRFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccRFC.DefaultCellStyle = dataGridViewCellStyle2;
            this.ccRFC.HeaderText = "RFC";
            this.ccRFC.Name = "ccRFC";
            this.ccRFC.ReadOnly = true;
            this.ccRFC.Width = 53;
            // 
            // ccNombre
            // 
            this.ccNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ccNombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.ccNombre.HeaderText = "Nombre";
            this.ccNombre.Name = "ccNombre";
            this.ccNombre.ReadOnly = true;
            // 
            // colClienteActivo
            // 
            this.colClienteActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colClienteActivo.HeaderText = "Activo";
            this.colClienteActivo.Name = "colClienteActivo";
            this.colClienteActivo.ReadOnly = true;
            this.colClienteActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colClienteActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colClienteActivo.Width = 62;
            // 
            // btnEliminaCliente
            // 
            this.btnEliminaCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminaCliente.ImageKey = "user_delete_32.png";
            this.btnEliminaCliente.ImageList = this.ilIconos32;
            this.btnEliminaCliente.Location = new System.Drawing.Point(6, 150);
            this.btnEliminaCliente.Name = "btnEliminaCliente";
            this.btnEliminaCliente.Size = new System.Drawing.Size(71, 66);
            this.btnEliminaCliente.TabIndex = 2;
            this.btnEliminaCliente.Text = "Eliminar Cliente";
            this.btnEliminaCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminaCliente.UseVisualStyleBackColor = true;
            this.btnEliminaCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // ilIconos32
            // 
            this.ilIconos32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIconos32.ImageStream")));
            this.ilIconos32.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIconos32.Images.SetKeyName(0, "go-home-32.png");
            this.ilIconos32.Images.SetKeyName(1, "group_32.png");
            this.ilIconos32.Images.SetKeyName(2, "category_32.png");
            this.ilIconos32.Images.SetKeyName(3, "cart_box_32.png");
            this.ilIconos32.Images.SetKeyName(4, "user_add_32.png");
            this.ilIconos32.Images.SetKeyName(5, "user_delete_32.png");
            this.ilIconos32.Images.SetKeyName(6, "user_edit_32.png");
            this.ilIconos32.Images.SetKeyName(7, "lorry_32.png");
            this.ilIconos32.Images.SetKeyName(8, "box_surtir_32.png");
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarCliente.ImageKey = "user_edit_32.png";
            this.btnEditarCliente.ImageList = this.ilIconos32;
            this.btnEditarCliente.Location = new System.Drawing.Point(6, 78);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(71, 66);
            this.btnEditarCliente.TabIndex = 1;
            this.btnEditarCliente.Text = "Modificar Cliente";
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarCliente.ImageKey = "user_add_32.png";
            this.btnAgregarCliente.ImageList = this.ilIconos32;
            this.btnAgregarCliente.Location = new System.Drawing.Point(6, 6);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(71, 66);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Nuevo Cliente";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // tabProveedores
            // 
            this.tabProveedores.Controls.Add(this.btnEditarProveedor);
            this.tabProveedores.Controls.Add(this.btnEliminaProveedor);
            this.tabProveedores.Controls.Add(this.btnAgregarProveedor);
            this.tabProveedores.Controls.Add(this.dgvProveedores);
            this.tabProveedores.ImageKey = "lorry_32.png";
            this.tabProveedores.Location = new System.Drawing.Point(4, 39);
            this.tabProveedores.Name = "tabProveedores";
            this.tabProveedores.Size = new System.Drawing.Size(860, 503);
            this.tabProveedores.TabIndex = 2;
            this.tabProveedores.Text = "Proveedores";
            this.tabProveedores.UseVisualStyleBackColor = true;
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.Image = global::Inventarios.Properties.Resources.lorry_edit_32;
            this.btnEditarProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarProveedor.Location = new System.Drawing.Point(6, 78);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(71, 66);
            this.btnEditarProveedor.TabIndex = 10;
            this.btnEditarProveedor.Text = "Modificar Proveedor";
            this.btnEditarProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarProveedor.UseVisualStyleBackColor = true;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnEliminaProveedor
            // 
            this.btnEliminaProveedor.Image = global::Inventarios.Properties.Resources.lorry_delete_32;
            this.btnEliminaProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminaProveedor.Location = new System.Drawing.Point(6, 150);
            this.btnEliminaProveedor.Name = "btnEliminaProveedor";
            this.btnEliminaProveedor.Size = new System.Drawing.Size(71, 66);
            this.btnEliminaProveedor.TabIndex = 9;
            this.btnEliminaProveedor.Text = "Elimina Proveedor";
            this.btnEliminaProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminaProveedor.UseVisualStyleBackColor = true;
            this.btnEliminaProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Image = global::Inventarios.Properties.Resources.lorry_add_32;
            this.btnAgregarProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(6, 6);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(71, 66);
            this.btnAgregarProveedor.TabIndex = 4;
            this.btnAgregarProveedor.Text = "Nuevo Proveedor";
            this.btnAgregarProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToResizeColumns = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreProveedor,
            this.colDomingo,
            this.colLunes,
            this.colMartes,
            this.colMiercoles,
            this.colJueves,
            this.colViernes,
            this.colSabado,
            this.colProvActivo});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProveedores.Location = new System.Drawing.Point(83, 6);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(774, 488);
            this.dgvProveedores.TabIndex = 7;
            this.dgvProveedores.SelectionChanged += new System.EventHandler(this.dgvProveedores_SelectionChanged);
            // 
            // colNombreProveedor
            // 
            this.colNombreProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colNombreProveedor.DefaultCellStyle = dataGridViewCellStyle6;
            this.colNombreProveedor.HeaderText = "Nombre";
            this.colNombreProveedor.Name = "colNombreProveedor";
            this.colNombreProveedor.ReadOnly = true;
            // 
            // colDomingo
            // 
            this.colDomingo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDomingo.HeaderText = "Dom";
            this.colDomingo.Name = "colDomingo";
            this.colDomingo.ReadOnly = true;
            this.colDomingo.Width = 35;
            // 
            // colLunes
            // 
            this.colLunes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLunes.HeaderText = "Lun";
            this.colLunes.Name = "colLunes";
            this.colLunes.ReadOnly = true;
            this.colLunes.Width = 31;
            // 
            // colMartes
            // 
            this.colMartes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMartes.HeaderText = "Mar";
            this.colMartes.Name = "colMartes";
            this.colMartes.ReadOnly = true;
            this.colMartes.Width = 31;
            // 
            // colMiercoles
            // 
            this.colMiercoles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMiercoles.HeaderText = "Mier";
            this.colMiercoles.Name = "colMiercoles";
            this.colMiercoles.ReadOnly = true;
            this.colMiercoles.Width = 33;
            // 
            // colJueves
            // 
            this.colJueves.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colJueves.HeaderText = "Jue";
            this.colJueves.Name = "colJueves";
            this.colJueves.ReadOnly = true;
            this.colJueves.Width = 30;
            // 
            // colViernes
            // 
            this.colViernes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colViernes.HeaderText = "Vier";
            this.colViernes.Name = "colViernes";
            this.colViernes.ReadOnly = true;
            this.colViernes.Width = 31;
            // 
            // colSabado
            // 
            this.colSabado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSabado.HeaderText = "Sab";
            this.colSabado.Name = "colSabado";
            this.colSabado.ReadOnly = true;
            this.colSabado.Width = 32;
            // 
            // colProvActivo
            // 
            this.colProvActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colProvActivo.HeaderText = "Activo";
            this.colProvActivo.Name = "colProvActivo";
            this.colProvActivo.ReadOnly = true;
            this.colProvActivo.Width = 43;
            // 
            // tabDepartamentos
            // 
            this.tabDepartamentos.Controls.Add(this.btnEliminaDepartamento);
            this.tabDepartamentos.Controls.Add(this.btnEditarDepartamento);
            this.tabDepartamentos.Controls.Add(this.btnAgregaDepartamento);
            this.tabDepartamentos.Controls.Add(this.dgvDepartamentos);
            this.tabDepartamentos.ImageKey = "category_32.png";
            this.tabDepartamentos.Location = new System.Drawing.Point(4, 39);
            this.tabDepartamentos.Name = "tabDepartamentos";
            this.tabDepartamentos.Size = new System.Drawing.Size(860, 503);
            this.tabDepartamentos.TabIndex = 3;
            this.tabDepartamentos.Text = "Departamentos";
            this.tabDepartamentos.UseVisualStyleBackColor = true;
            // 
            // btnEliminaDepartamento
            // 
            this.btnEliminaDepartamento.Image = global::Inventarios.Properties.Resources.category_delete_32;
            this.btnEliminaDepartamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminaDepartamento.Location = new System.Drawing.Point(6, 150);
            this.btnEliminaDepartamento.Name = "btnEliminaDepartamento";
            this.btnEliminaDepartamento.Size = new System.Drawing.Size(71, 66);
            this.btnEliminaDepartamento.TabIndex = 2;
            this.btnEliminaDepartamento.Text = "Eliminar Depto";
            this.btnEliminaDepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminaDepartamento.UseVisualStyleBackColor = true;
            this.btnEliminaDepartamento.Click += new System.EventHandler(this.btnAgregaDepartamento_Click);
            // 
            // btnEditarDepartamento
            // 
            this.btnEditarDepartamento.Image = global::Inventarios.Properties.Resources.category_edit_32;
            this.btnEditarDepartamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarDepartamento.Location = new System.Drawing.Point(6, 78);
            this.btnEditarDepartamento.Name = "btnEditarDepartamento";
            this.btnEditarDepartamento.Size = new System.Drawing.Size(71, 66);
            this.btnEditarDepartamento.TabIndex = 1;
            this.btnEditarDepartamento.Text = "Modificar Depto";
            this.btnEditarDepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarDepartamento.UseVisualStyleBackColor = true;
            this.btnEditarDepartamento.Click += new System.EventHandler(this.btnAgregaDepartamento_Click);
            // 
            // btnAgregaDepartamento
            // 
            this.btnAgregaDepartamento.Image = global::Inventarios.Properties.Resources.category_add_32;
            this.btnAgregaDepartamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregaDepartamento.Location = new System.Drawing.Point(6, 6);
            this.btnAgregaDepartamento.Name = "btnAgregaDepartamento";
            this.btnAgregaDepartamento.Size = new System.Drawing.Size(71, 66);
            this.btnAgregaDepartamento.TabIndex = 0;
            this.btnAgregaDepartamento.Text = "Nuevo Depto";
            this.btnAgregaDepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregaDepartamento.UseVisualStyleBackColor = true;
            this.btnAgregaDepartamento.Click += new System.EventHandler(this.btnAgregaDepartamento_Click);
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AllowUserToAddRows = false;
            this.dgvDepartamentos.AllowUserToDeleteRows = false;
            this.dgvDepartamentos.AllowUserToResizeColumns = false;
            this.dgvDepartamentos.AllowUserToResizeRows = false;
            this.dgvDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.colDepActivo});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartamentos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDepartamentos.Location = new System.Drawing.Point(83, 6);
            this.dgvDepartamentos.MultiSelect = false;
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.ReadOnly = true;
            this.dgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartamentos.Size = new System.Drawing.Size(774, 488);
            this.dgvDepartamentos.TabIndex = 4;
            this.dgvDepartamentos.SelectionChanged += new System.EventHandler(this.dgvDepartamentos_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewCheckBoxColumn1.HeaderText = "A Granel";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.Width = 54;
            // 
            // colDepActivo
            // 
            this.colDepActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDepActivo.HeaderText = "Activo";
            this.colDepActivo.Name = "colDepActivo";
            this.colDepActivo.ReadOnly = true;
            this.colDepActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDepActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDepActivo.Width = 62;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.gbFiltros);
            this.tabProductos.Controls.Add(this.dgvProductos);
            this.tabProductos.Controls.Add(this.btnEliminaProducto);
            this.tabProductos.Controls.Add(this.btnEditarProducto);
            this.tabProductos.Controls.Add(this.btnAgregarProducto);
            this.tabProductos.ImageKey = "cart_box_32.png";
            this.tabProductos.Location = new System.Drawing.Point(4, 39);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(860, 503);
            this.tabProductos.TabIndex = 4;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltros.Controls.Add(this.cmbFiltroProveedor);
            this.gbFiltros.Controls.Add(this.label7);
            this.gbFiltros.Controls.Add(this.cmbFiltroDepartamento);
            this.gbFiltros.Controls.Add(this.label6);
            this.gbFiltros.Controls.Add(this.tbFiltroDescripcion);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Location = new System.Drawing.Point(83, 6);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(774, 53);
            this.gbFiltros.TabIndex = 6;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filstros:";
            // 
            // cmbFiltroProveedor
            // 
            this.cmbFiltroProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroProveedor.FormattingEnabled = true;
            this.cmbFiltroProveedor.Location = new System.Drawing.Point(551, 19);
            this.cmbFiltroProveedor.Name = "cmbFiltroProveedor";
            this.cmbFiltroProveedor.Size = new System.Drawing.Size(159, 21);
            this.cmbFiltroProveedor.TabIndex = 5;
            this.cmbFiltroProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroProveedor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Proveedor:";
            // 
            // cmbFiltroDepartamento
            // 
            this.cmbFiltroDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroDepartamento.FormattingEnabled = true;
            this.cmbFiltroDepartamento.Location = new System.Drawing.Point(321, 19);
            this.cmbFiltroDepartamento.Name = "cmbFiltroDepartamento";
            this.cmbFiltroDepartamento.Size = new System.Drawing.Size(159, 21);
            this.cmbFiltroDepartamento.TabIndex = 3;
            this.cmbFiltroDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroDepartamento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Departamento:";
            // 
            // tbFiltroDescripcion
            // 
            this.tbFiltroDescripcion.Location = new System.Drawing.Point(78, 19);
            this.tbFiltroDescripcion.Name = "tbFiltroDescripcion";
            this.tbFiltroDescripcion.Size = new System.Drawing.Size(154, 20);
            this.tbFiltroDescripcion.TabIndex = 1;
            this.tbFiltroDescripcion.TextChanged += new System.EventHandler(this.tbFiltroDescripcion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descripción:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProdCodigo,
            this.colProdDescrip,
            this.colProdCosto,
            this.colProdPrecio,
            this.colProdExistencia,
            this.colProdMinimo,
            this.colProdDepartamento,
            this.colProdProveedor,
            this.colProdUnidad,
            this.colProdInventario,
            this.colProdActivo});
            this.dgvProductos.ContextMenuStrip = this.cmsProductos;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvProductos.Location = new System.Drawing.Point(83, 65);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(774, 429);
            this.dgvProductos.TabIndex = 5;
            this.dgvProductos.VirtualMode = true;
            this.dgvProductos.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvProductos_CellValueNeeded);
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // colProdCodigo
            // 
            this.colProdCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colProdCodigo.DefaultCellStyle = dataGridViewCellStyle12;
            this.colProdCodigo.HeaderText = "Código";
            this.colProdCodigo.Name = "colProdCodigo";
            this.colProdCodigo.ReadOnly = true;
            this.colProdCodigo.Width = 65;
            // 
            // colProdDescrip
            // 
            this.colProdDescrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colProdDescrip.DefaultCellStyle = dataGridViewCellStyle13;
            this.colProdDescrip.HeaderText = "Descripción";
            this.colProdDescrip.Name = "colProdDescrip";
            this.colProdDescrip.ReadOnly = true;
            this.colProdDescrip.Width = 88;
            // 
            // colProdCosto
            // 
            this.colProdCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle14.Format = "C2";
            this.colProdCosto.DefaultCellStyle = dataGridViewCellStyle14;
            this.colProdCosto.HeaderText = "Costo";
            this.colProdCosto.Name = "colProdCosto";
            this.colProdCosto.ReadOnly = true;
            this.colProdCosto.Width = 59;
            // 
            // colProdPrecio
            // 
            this.colProdPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle15.Format = "C2";
            this.colProdPrecio.DefaultCellStyle = dataGridViewCellStyle15;
            this.colProdPrecio.HeaderText = "Precio";
            this.colProdPrecio.Name = "colProdPrecio";
            this.colProdPrecio.ReadOnly = true;
            this.colProdPrecio.Width = 62;
            // 
            // colProdExistencia
            // 
            this.colProdExistencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = "0.00";
            this.colProdExistencia.DefaultCellStyle = dataGridViewCellStyle16;
            this.colProdExistencia.HeaderText = "Existencia";
            this.colProdExistencia.Name = "colProdExistencia";
            this.colProdExistencia.ReadOnly = true;
            this.colProdExistencia.Width = 80;
            // 
            // colProdMinimo
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle17.Format = "N2";
            this.colProdMinimo.DefaultCellStyle = dataGridViewCellStyle17;
            this.colProdMinimo.HeaderText = "Minimo";
            this.colProdMinimo.Name = "colProdMinimo";
            this.colProdMinimo.ReadOnly = true;
            // 
            // colProdDepartamento
            // 
            this.colProdDepartamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colProdDepartamento.DefaultCellStyle = dataGridViewCellStyle18;
            this.colProdDepartamento.HeaderText = "Departamento";
            this.colProdDepartamento.Name = "colProdDepartamento";
            this.colProdDepartamento.ReadOnly = true;
            this.colProdDepartamento.Width = 99;
            // 
            // colProdProveedor
            // 
            this.colProdProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colProdProveedor.DefaultCellStyle = dataGridViewCellStyle19;
            this.colProdProveedor.HeaderText = "Proveedor";
            this.colProdProveedor.Name = "colProdProveedor";
            this.colProdProveedor.ReadOnly = true;
            this.colProdProveedor.Width = 81;
            // 
            // colProdUnidad
            // 
            this.colProdUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colProdUnidad.DefaultCellStyle = dataGridViewCellStyle20;
            this.colProdUnidad.HeaderText = "Unidad";
            this.colProdUnidad.Name = "colProdUnidad";
            this.colProdUnidad.ReadOnly = true;
            this.colProdUnidad.Width = 66;
            // 
            // colProdInventario
            // 
            this.colProdInventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdInventario.HeaderText = "Inventario";
            this.colProdInventario.Name = "colProdInventario";
            this.colProdInventario.ReadOnly = true;
            this.colProdInventario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProdInventario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colProdInventario.Width = 79;
            // 
            // colProdActivo
            // 
            this.colProdActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdActivo.HeaderText = "Activo";
            this.colProdActivo.Name = "colProdActivo";
            this.colProdActivo.ReadOnly = true;
            this.colProdActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProdActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colProdActivo.Width = 62;
            // 
            // cmsProductos
            // 
            this.cmsProductos.Name = "cmsProductos";
            this.cmsProductos.Size = new System.Drawing.Size(61, 4);
            // 
            // btnEliminaProducto
            // 
            this.btnEliminaProducto.Image = global::Inventarios.Properties.Resources.box_delete_32;
            this.btnEliminaProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminaProducto.Location = new System.Drawing.Point(6, 150);
            this.btnEliminaProducto.Name = "btnEliminaProducto";
            this.btnEliminaProducto.Size = new System.Drawing.Size(71, 66);
            this.btnEliminaProducto.TabIndex = 2;
            this.btnEliminaProducto.Text = "Eliminar Producto";
            this.btnEliminaProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminaProducto.UseVisualStyleBackColor = true;
            this.btnEliminaProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Image = global::Inventarios.Properties.Resources.box_edit_32;
            this.btnEditarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarProducto.Location = new System.Drawing.Point(6, 78);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(71, 66);
            this.btnEditarProducto.TabIndex = 1;
            this.btnEditarProducto.Text = "Modificar Producto";
            this.btnEditarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Image = global::Inventarios.Properties.Resources.box_add_32;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProducto.Location = new System.Drawing.Point(6, 6);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(71, 66);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Nuevo Producto";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // ilIconos16
            // 
            this.ilIconos16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIconos16.ImageStream")));
            this.ilIconos16.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIconos16.Images.SetKeyName(0, "user_add_16.png");
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 570);
            this.Controls.Add(this.tabPrincipal);
            this.DoubleBuffered = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventarios";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.tabPrincipal.ResumeLayout(false);
            this.tabSurtir.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.tabDepartamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.tabProductos.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabProveedores;
        private System.Windows.Forms.TabPage tabDepartamentos;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.ImageList ilIconos32;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.ImageList ilIconos16;
        private System.Windows.Forms.Button btnEliminaCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnEliminaProveedor;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnAgregaDepartamento;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.Button btnEditarDepartamento;
        private System.Windows.Forms.Button btnEliminaDepartamento;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnEliminaProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TabPage tabSurtir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbExistencia;
        private System.Windows.Forms.Button btnSurtir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccNombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colClienteActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProveedor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDomingo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colLunes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMartes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMiercoles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colJueves;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colViernes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSabado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProvActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDepActivo;
        private Controles.NumericTextBox ntbSurtir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdExistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdUnidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProdInventario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colProdActivo;
        private System.Windows.Forms.ContextMenuStrip cmsProductos;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.TextBox tbFiltroDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFiltroDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFiltroProveedor;
        private System.Windows.Forms.Label label7;
    }
}

