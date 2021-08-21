namespace El_Maquinista.Formularios
{
    partial class Busqueda_Nombre
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
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txbBuscarProducto = new System.Windows.Forms.TextBox();
            this.dgProductosEncontrados = new System.Windows.Forms.DataGridView();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.IconBtn_AgregarProducto = new FontAwesome.Sharp.IconButton();
            this.IconBtn_RemoverProducto = new FontAwesome.Sharp.IconButton();
            this.IconButton_Limpiar = new FontAwesome.Sharp.IconButton();
            this.IconButton_BuscarProducto = new FontAwesome.Sharp.IconButton();
            this.EP_BusquedaNombre = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosEncontrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_BusquedaNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(22, 29);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(201, 27);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // txbBuscarProducto
            // 
            this.txbBuscarProducto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscarProducto.Location = new System.Drawing.Point(358, 26);
            this.txbBuscarProducto.Name = "txbBuscarProducto";
            this.txbBuscarProducto.Size = new System.Drawing.Size(406, 34);
            this.txbBuscarProducto.TabIndex = 1;
            // 
            // dgProductosEncontrados
            // 
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
            this.dgProductosEncontrados.Location = new System.Drawing.Point(27, 153);
            this.dgProductosEncontrados.Name = "dgProductosEncontrados";
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
            this.dgProductosEncontrados.Size = new System.Drawing.Size(737, 541);
            this.dgProductosEncontrados.TabIndex = 2;
            this.dgProductosEncontrados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductosEncontrados_CellClick);
            // 
            // pbProducto
            // 
            this.pbProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProducto.Location = new System.Drawing.Point(27, 718);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(249, 245);
            this.pbProducto.TabIndex = 3;
            this.pbProducto.TabStop = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(297, 732);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 27);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(297, 800);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 27);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(481, 729);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(283, 34);
            this.txbCantidad.TabIndex = 6;
            this.txbCantidad.TextChanged += new System.EventHandler(this.txbCantidad_TextChanged);
            // 
            // txbPrecio
            // 
            this.txbPrecio.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecio.Location = new System.Drawing.Point(481, 797);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(283, 34);
            this.txbPrecio.TabIndex = 7;
            // 
            // IconBtn_AgregarProducto
            // 
            this.IconBtn_AgregarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_AgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.IconBtn_AgregarProducto.IconColor = System.Drawing.Color.Black;
            this.IconBtn_AgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_AgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_AgregarProducto.Location = new System.Drawing.Point(302, 871);
            this.IconBtn_AgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_AgregarProducto.Name = "IconBtn_AgregarProducto";
            this.IconBtn_AgregarProducto.Size = new System.Drawing.Size(235, 92);
            this.IconBtn_AgregarProducto.TabIndex = 18;
            this.IconBtn_AgregarProducto.Text = "Agregar Producto";
            this.IconBtn_AgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_AgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_AgregarProducto.UseVisualStyleBackColor = true;
            this.IconBtn_AgregarProducto.Click += new System.EventHandler(this.IconBtn_AgregarProducto_Click);
            // 
            // IconBtn_RemoverProducto
            // 
            this.IconBtn_RemoverProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_RemoverProducto.IconChar = FontAwesome.Sharp.IconChar.StoreSlash;
            this.IconBtn_RemoverProducto.IconColor = System.Drawing.Color.Black;
            this.IconBtn_RemoverProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_RemoverProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_RemoverProducto.Location = new System.Drawing.Point(559, 871);
            this.IconBtn_RemoverProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_RemoverProducto.Name = "IconBtn_RemoverProducto";
            this.IconBtn_RemoverProducto.Size = new System.Drawing.Size(205, 92);
            this.IconBtn_RemoverProducto.TabIndex = 19;
            this.IconBtn_RemoverProducto.Text = "Remover Producto";
            this.IconBtn_RemoverProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_RemoverProducto.UseVisualStyleBackColor = true;
            // 
            // IconButton_Limpiar
            // 
            this.IconButton_Limpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconButton_Limpiar.IconColor = System.Drawing.Color.Black;
            this.IconButton_Limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconButton_Limpiar.Location = new System.Drawing.Point(545, 82);
            this.IconButton_Limpiar.Name = "IconButton_Limpiar";
            this.IconButton_Limpiar.Size = new System.Drawing.Size(219, 46);
            this.IconButton_Limpiar.TabIndex = 20;
            this.IconButton_Limpiar.Text = "Limpiar";
            this.IconButton_Limpiar.UseVisualStyleBackColor = true;
            this.IconButton_Limpiar.Click += new System.EventHandler(this.IconButton_Limpiar_Click);
            // 
            // IconButton_BuscarProducto
            // 
            this.IconButton_BuscarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconButton_BuscarProducto.IconColor = System.Drawing.Color.Black;
            this.IconButton_BuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconButton_BuscarProducto.Location = new System.Drawing.Point(302, 82);
            this.IconButton_BuscarProducto.Name = "IconButton_BuscarProducto";
            this.IconButton_BuscarProducto.Size = new System.Drawing.Size(219, 46);
            this.IconButton_BuscarProducto.TabIndex = 21;
            this.IconButton_BuscarProducto.Text = "Buscar";
            this.IconButton_BuscarProducto.UseVisualStyleBackColor = true;
            this.IconButton_BuscarProducto.Click += new System.EventHandler(this.IconButton_BuscarProducto_Click);
            // 
            // EP_BusquedaNombre
            // 
            this.EP_BusquedaNombre.ContainerControl = this;
            // 
            // Busqueda_Nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(799, 1010);
            this.Controls.Add(this.IconButton_BuscarProducto);
            this.Controls.Add(this.IconButton_Limpiar);
            this.Controls.Add(this.IconBtn_RemoverProducto);
            this.Controls.Add(this.IconBtn_AgregarProducto);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.dgProductosEncontrados);
            this.Controls.Add(this.txbBuscarProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Name = "Busqueda_Nombre";
            this.Text = "Busqueda_Nombre";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductosEncontrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_BusquedaNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.DataGridView dgProductosEncontrados;
        private System.Windows.Forms.PictureBox pbProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.TextBox txbPrecio;
        private FontAwesome.Sharp.IconButton IconBtn_AgregarProducto;
        private FontAwesome.Sharp.IconButton IconBtn_RemoverProducto;
        public System.Windows.Forms.TextBox txbBuscarProducto;
        private FontAwesome.Sharp.IconButton IconButton_Limpiar;
        private FontAwesome.Sharp.IconButton IconButton_BuscarProducto;
        private System.Windows.Forms.ErrorProvider EP_BusquedaNombre;
    }
}