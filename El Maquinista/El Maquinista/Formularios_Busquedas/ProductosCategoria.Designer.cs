namespace El_Maquinista.Formularios
{
    partial class ProductosCategoria
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgProductosEncontrados = new System.Windows.Forms.DataGridView();
            this.lblCategoriaSeleccionada = new System.Windows.Forms.Label();
            this.IconBtn_RemoverProducto = new FontAwesome.Sharp.IconButton();
            this.IconBtn_AgregarProducto = new FontAwesome.Sharp.IconButton();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.EP_BusquedaCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.cb_Categorias = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosEncontrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_BusquedaCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProductosEncontrados
            // 
            this.dgProductosEncontrados.AllowUserToAddRows = false;
            this.dgProductosEncontrados.AllowUserToResizeColumns = false;
            this.dgProductosEncontrados.AllowUserToResizeRows = false;
            this.dgProductosEncontrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgProductosEncontrados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            this.dgProductosEncontrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProductosEncontrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgProductosEncontrados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductosEncontrados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProductosEncontrados.ColumnHeadersHeight = 55;
            this.dgProductosEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgProductosEncontrados.EnableHeadersVisualStyles = false;
            this.dgProductosEncontrados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgProductosEncontrados.Location = new System.Drawing.Point(17, 85);
            this.dgProductosEncontrados.Name = "dgProductosEncontrados";
            this.dgProductosEncontrados.ReadOnly = true;
            this.dgProductosEncontrados.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgProductosEncontrados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProductosEncontrados.RowTemplate.Height = 24;
            this.dgProductosEncontrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductosEncontrados.Size = new System.Drawing.Size(770, 581);
            this.dgProductosEncontrados.TabIndex = 0;
            this.dgProductosEncontrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductosEncontrados_CellClick);
            // 
            // lblCategoriaSeleccionada
            // 
            this.lblCategoriaSeleccionada.AutoSize = true;
            this.lblCategoriaSeleccionada.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaSeleccionada.Location = new System.Drawing.Point(12, 25);
            this.lblCategoriaSeleccionada.Name = "lblCategoriaSeleccionada";
            this.lblCategoriaSeleccionada.Size = new System.Drawing.Size(267, 27);
            this.lblCategoriaSeleccionada.TabIndex = 1;
            this.lblCategoriaSeleccionada.Text = "Categoría Seleccionada";
            // 
            // IconBtn_RemoverProducto
            // 
            this.IconBtn_RemoverProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_RemoverProducto.IconChar = FontAwesome.Sharp.IconChar.StoreSlash;
            this.IconBtn_RemoverProducto.IconColor = System.Drawing.Color.Black;
            this.IconBtn_RemoverProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_RemoverProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_RemoverProducto.Location = new System.Drawing.Point(549, 844);
            this.IconBtn_RemoverProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_RemoverProducto.Name = "IconBtn_RemoverProducto";
            this.IconBtn_RemoverProducto.Size = new System.Drawing.Size(205, 92);
            this.IconBtn_RemoverProducto.TabIndex = 26;
            this.IconBtn_RemoverProducto.Text = "Remover Producto";
            this.IconBtn_RemoverProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_RemoverProducto.UseVisualStyleBackColor = true;
            this.IconBtn_RemoverProducto.Click += new System.EventHandler(this.IconBtn_RemoverProducto_Click);
            // 
            // IconBtn_AgregarProducto
            // 
            this.IconBtn_AgregarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_AgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.IconBtn_AgregarProducto.IconColor = System.Drawing.Color.Black;
            this.IconBtn_AgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_AgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_AgregarProducto.Location = new System.Drawing.Point(292, 844);
            this.IconBtn_AgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_AgregarProducto.Name = "IconBtn_AgregarProducto";
            this.IconBtn_AgregarProducto.Size = new System.Drawing.Size(235, 92);
            this.IconBtn_AgregarProducto.TabIndex = 25;
            this.IconBtn_AgregarProducto.Text = "Agregar Producto";
            this.IconBtn_AgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_AgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_AgregarProducto.UseVisualStyleBackColor = true;
            this.IconBtn_AgregarProducto.Click += new System.EventHandler(this.IconBtn_AgregarProducto_Click);
            // 
            // txbPrecio
            // 
            this.txbPrecio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(471, 770);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(283, 34);
            this.txbPrecio.TabIndex = 24;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(471, 702);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(283, 34);
            this.txbCantidad.TabIndex = 23;
            this.txbCantidad.TextChanged += new System.EventHandler(this.txbCantidad_TextChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(287, 773);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 27);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(287, 705);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 27);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad";
            // 
            // pbProducto
            // 
            this.pbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProducto.Location = new System.Drawing.Point(17, 691);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(249, 245);
            this.pbProducto.TabIndex = 20;
            this.pbProducto.TabStop = false;
            // 
            // EP_BusquedaCategoria
            // 
            this.EP_BusquedaCategoria.ContainerControl = this;
            // 
            // cb_Categorias
            // 
            this.cb_Categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Categorias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Categorias.FormattingEnabled = true;
            this.cb_Categorias.Location = new System.Drawing.Point(395, 24);
            this.cb_Categorias.Name = "cb_Categorias";
            this.cb_Categorias.Size = new System.Drawing.Size(392, 31);
            this.cb_Categorias.TabIndex = 2;
            this.cb_Categorias.SelectedIndexChanged += new System.EventHandler(this.cb_Categorias_SelectedIndexChanged);
            // 
            // ProductosCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(799, 1010);
            this.Controls.Add(this.IconBtn_RemoverProducto);
            this.Controls.Add(this.IconBtn_AgregarProducto);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.cb_Categorias);
            this.Controls.Add(this.lblCategoriaSeleccionada);
            this.Controls.Add(this.dgProductosEncontrados);
            this.Name = "ProductosCategoria";
            this.Text = "ProductosCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosEncontrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_BusquedaCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductosEncontrados;
        private System.Windows.Forms.Label lblCategoriaSeleccionada;
        private FontAwesome.Sharp.IconButton IconBtn_RemoverProducto;
        private FontAwesome.Sharp.IconButton IconBtn_AgregarProducto;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.PictureBox pbProducto;
        private System.Windows.Forms.ErrorProvider EP_BusquedaCategoria;
        private System.Windows.Forms.ComboBox cb_Categorias;
    }
}