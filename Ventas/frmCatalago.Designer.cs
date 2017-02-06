namespace AreliPOS.Ventas
{
    partial class frmCatalago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalago));
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.tlpProducto = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbBuscar.SuspendLayout();
            this.tlpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.tlpProducto);
            this.gbBuscar.Location = new System.Drawing.Point(12, 12);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(599, 51);
            this.gbBuscar.TabIndex = 0;
            this.gbBuscar.TabStop = false;
            // 
            // tlpProducto
            // 
            this.tlpProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProducto.BackColor = System.Drawing.Color.Transparent;
            this.tlpProducto.ColumnCount = 2;
            this.tlpProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProducto.Controls.Add(this.label2, 0, 0);
            this.tlpProducto.Controls.Add(this.tbBuscar, 1, 0);
            this.tlpProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpProducto.Location = new System.Drawing.Point(0, 7);
            this.tlpProducto.Name = "tlpProducto";
            this.tlpProducto.RowCount = 1;
            this.tlpProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProducto.Size = new System.Drawing.Size(597, 45);
            this.tlpProducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBuscar
            // 
            this.tbBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(77, 3);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(517, 36);
            this.tbBuscar.TabIndex = 1;
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductos.Location = new System.Drawing.Point(12, 70);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(597, 279);
            this.dgvProductos.TabIndex = 6;
            this.dgvProductos.VirtualMode = true;
            this.dgvProductos.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvProductos_CellValueNeeded);
            // 
            // colProdCodigo
            // 
            this.colProdCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colProdCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colProdCodigo.HeaderText = "Código";
            this.colProdCodigo.Name = "colProdCodigo";
            this.colProdCodigo.ReadOnly = true;
            this.colProdCodigo.Width = 65;
            // 
            // colProdDescrip
            // 
            this.colProdDescrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colProdDescrip.DefaultCellStyle = dataGridViewCellStyle3;
            this.colProdDescrip.HeaderText = "Descripción";
            this.colProdDescrip.Name = "colProdDescrip";
            this.colProdDescrip.ReadOnly = true;
            this.colProdDescrip.Width = 88;
            // 
            // colProdCosto
            // 
            this.colProdCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle4.Format = "C2";
            this.colProdCosto.DefaultCellStyle = dataGridViewCellStyle4;
            this.colProdCosto.HeaderText = "Costo";
            this.colProdCosto.Name = "colProdCosto";
            this.colProdCosto.ReadOnly = true;
            this.colProdCosto.Visible = false;
            // 
            // colProdPrecio
            // 
            this.colProdPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle5.Format = "C2";
            this.colProdPrecio.DefaultCellStyle = dataGridViewCellStyle5;
            this.colProdPrecio.HeaderText = "Precio";
            this.colProdPrecio.Name = "colProdPrecio";
            this.colProdPrecio.ReadOnly = true;
            this.colProdPrecio.Width = 62;
            // 
            // colProdExistencia
            // 
            this.colProdExistencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.colProdExistencia.DefaultCellStyle = dataGridViewCellStyle6;
            this.colProdExistencia.HeaderText = "Existencia";
            this.colProdExistencia.Name = "colProdExistencia";
            this.colProdExistencia.ReadOnly = true;
            this.colProdExistencia.Visible = false;
            // 
            // colProdMinimo
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle7.Format = "N2";
            this.colProdMinimo.DefaultCellStyle = dataGridViewCellStyle7;
            this.colProdMinimo.HeaderText = "Minimo";
            this.colProdMinimo.Name = "colProdMinimo";
            this.colProdMinimo.ReadOnly = true;
            this.colProdMinimo.Visible = false;
            // 
            // colProdDepartamento
            // 
            this.colProdDepartamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colProdDepartamento.DefaultCellStyle = dataGridViewCellStyle8;
            this.colProdDepartamento.HeaderText = "Departamento";
            this.colProdDepartamento.Name = "colProdDepartamento";
            this.colProdDepartamento.ReadOnly = true;
            this.colProdDepartamento.Width = 99;
            // 
            // colProdProveedor
            // 
            this.colProdProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colProdProveedor.DefaultCellStyle = dataGridViewCellStyle9;
            this.colProdProveedor.HeaderText = "Proveedor";
            this.colProdProveedor.Name = "colProdProveedor";
            this.colProdProveedor.ReadOnly = true;
            this.colProdProveedor.Width = 81;
            // 
            // colProdUnidad
            // 
            this.colProdUnidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.colProdUnidad.DefaultCellStyle = dataGridViewCellStyle10;
            this.colProdUnidad.HeaderText = "Unidad";
            this.colProdUnidad.Name = "colProdUnidad";
            this.colProdUnidad.ReadOnly = true;
            this.colProdUnidad.Visible = false;
            // 
            // colProdInventario
            // 
            this.colProdInventario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdInventario.HeaderText = "Inventario";
            this.colProdInventario.Name = "colProdInventario";
            this.colProdInventario.ReadOnly = true;
            this.colProdInventario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProdInventario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colProdInventario.Visible = false;
            // 
            // colProdActivo
            // 
            this.colProdActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colProdActivo.HeaderText = "Activo";
            this.colProdActivo.Name = "colProdActivo";
            this.colProdActivo.ReadOnly = true;
            this.colProdActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colProdActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colProdActivo.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::AreliPOS.Ventas.Properties.Resources.tick16;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(459, 355);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(71, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AreliPOS.Ventas.Properties.Resources.cross;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(536, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmCatalago
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(623, 391);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.gbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatalago";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Catálago";
            this.gbBuscar.ResumeLayout(false);
            this.tlpProducto.ResumeLayout(false);
            this.tlpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.TableLayoutPanel tlpProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.DataGridView dgvProductos;
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
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}