namespace AreliPOS.Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.tlpProducto = new System.Windows.Forms.TableLayoutPanel();
            this.btnCatalago = new System.Windows.Forms.Button();
            this.tlpDetalleVenta = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.tlpProducto.SuspendLayout();
            this.tlpDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEntrada
            // 
            this.tbEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEntrada.Location = new System.Drawing.Point(92, 4);
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(483, 36);
            this.tbEntrada.TabIndex = 1;
            this.tbEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEntrada_KeyPress);
            // 
            // tlpProducto
            // 
            this.tlpProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProducto.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpProducto.ColumnCount = 3;
            this.tlpProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpProducto.Controls.Add(this.btnCatalago, 2, 0);
            this.tlpProducto.Controls.Add(this.label1, 0, 0);
            this.tlpProducto.Controls.Add(this.tbEntrada, 1, 0);
            this.tlpProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpProducto.Location = new System.Drawing.Point(12, 12);
            this.tlpProducto.Name = "tlpProducto";
            this.tlpProducto.RowCount = 1;
            this.tlpProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProducto.Size = new System.Drawing.Size(701, 45);
            this.tlpProducto.TabIndex = 1;
            // 
            // btnCatalago
            // 
            this.btnCatalago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCatalago.Image = global::AreliPOS.Ventas.Properties.Resources.book_open_32;
            this.btnCatalago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalago.Location = new System.Drawing.Point(582, 4);
            this.btnCatalago.Name = "btnCatalago";
            this.btnCatalago.Size = new System.Drawing.Size(115, 37);
            this.btnCatalago.TabIndex = 2;
            this.btnCatalago.Text = "Catálogo";
            this.btnCatalago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCatalago.UseVisualStyleBackColor = true;
            this.btnCatalago.Click += new System.EventHandler(this.btnCatalago_Click);
            // 
            // tlpDetalleVenta
            // 
            this.tlpDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDetalleVenta.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDetalleVenta.ColumnCount = 1;
            this.tlpDetalleVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDetalleVenta.Controls.Add(this.dgvDetalleVenta, 0, 0);
            this.tlpDetalleVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpDetalleVenta.Location = new System.Drawing.Point(12, 63);
            this.tlpDetalleVenta.Name = "tlpDetalleVenta";
            this.tlpDetalleVenta.RowCount = 1;
            this.tlpDetalleVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDetalleVenta.Size = new System.Drawing.Size(701, 368);
            this.tlpDetalleVenta.TabIndex = 2;
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleVenta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colCantidad,
            this.colPrecio,
            this.colImporte});
            this.dgvDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(4, 4);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(693, 360);
            this.dgvDetalleVenta.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCodigo.Width = 65;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCantidad
            // 
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0.00";
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCantidad.Width = 79;
            // 
            // colPrecio
            // 
            this.colPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.colPrecio.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPrecio.Width = 59;
            // 
            // colImporte
            // 
            this.colImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.colImporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.colImporte.HeaderText = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            this.colImporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colImporte.Width = 70;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Image = global::AreliPOS.Ventas.Properties.Resources.Cash48;
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(578, 437);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(135, 58);
            this.btnCobrar.TabIndex = 3;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 507);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.tlpDetalleVenta);
            this.Controls.Add(this.tlpProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AreliPOS - Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tlpProducto.ResumeLayout(false);
            this.tlpProducto.PerformLayout();
            this.tlpDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatalago;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpProducto;
        private System.Windows.Forms.TableLayoutPanel tlpDetalleVenta;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.Button btnCobrar;

    }
}

