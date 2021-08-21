namespace El_Maquinista
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.dgBoleta = new System.Windows.Forms.DataGridView();
            this.tbCodigoBarras = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbProductoPrincipal = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbCodigoBarras = new System.Windows.Forms.Label();
            this.EP_Principal = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbTotalVenta = new System.Windows.Forms.Label();
            this.lbVenta = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.IconBtn_Catalogo = new FontAwesome.Sharp.IconButton();
            this.IconBtn_Estadisticas = new FontAwesome.Sharp.IconButton();
            this.IconBtn_Ventas = new FontAwesome.Sharp.IconButton();
            this.IconBtn_Usuarios = new FontAwesome.Sharp.IconButton();
            this.panel_BuscarProducto = new System.Windows.Forms.Panel();
            this.btnBuscarxCategoria = new System.Windows.Forms.Button();
            this.btnBuscarxNombre = new System.Windows.Forms.Button();
            this.IconBtn_BuscarProducto = new FontAwesome.Sharp.IconButton();
            this.pbLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Producto = new System.Windows.Forms.Panel();
            this.gpProducto = new System.Windows.Forms.GroupBox();
            this.lbStockDisponible = new System.Windows.Forms.Label();
            this.tbStockDisponible = new System.Windows.Forms.TextBox();
            this.IconBtn_LimpiarBoleta = new FontAwesome.Sharp.IconButton();
            this.IconBtn_RemoverProducto = new FontAwesome.Sharp.IconButton();
            this.IconBtn_AgregarProducto = new FontAwesome.Sharp.IconButton();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.IconBtn_ConfirmarVenta = new FontAwesome.Sharp.IconButton();
            this.panel_BoletaProductos = new System.Windows.Forms.Panel();
            this.gpBoleta = new System.Windows.Forms.GroupBox();
            this.pn_Catalogo = new System.Windows.Forms.Panel();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.btnModificar_RemoverProducto = new FontAwesome.Sharp.IconButton();
            this.btnIngresarStock = new FontAwesome.Sharp.IconButton();
            this.IconBtn_Configuraciones = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgBoleta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Principal)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.panel_BuscarProducto.SuspendLayout();
            this.pbLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Producto.SuspendLayout();
            this.gpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.panel_BoletaProductos.SuspendLayout();
            this.gpBoleta.SuspendLayout();
            this.pn_Catalogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBoleta
            // 
            this.dgBoleta.AllowUserToAddRows = false;
            this.dgBoleta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgBoleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgBoleta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            this.dgBoleta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgBoleta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgBoleta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBoleta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBoleta.ColumnHeadersHeight = 60;
            this.dgBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgBoleta.EnableHeadersVisualStyles = false;
            this.dgBoleta.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgBoleta.Location = new System.Drawing.Point(23, 46);
            this.dgBoleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgBoleta.Name = "dgBoleta";
            this.dgBoleta.ReadOnly = true;
            this.dgBoleta.RowHeadersVisible = false;
            this.dgBoleta.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgBoleta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBoleta.RowTemplate.Height = 24;
            this.dgBoleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBoleta.Size = new System.Drawing.Size(677, 799);
            this.dgBoleta.TabIndex = 0;
            // 
            // tbCodigoBarras
            // 
            this.tbCodigoBarras.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigoBarras.Location = new System.Drawing.Point(313, 64);
            this.tbCodigoBarras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigoBarras.Name = "tbCodigoBarras";
            this.tbCodigoBarras.Size = new System.Drawing.Size(428, 37);
            this.tbCodigoBarras.TabIndex = 9;
            this.tbCodigoBarras.TextChanged += new System.EventHandler(this.tbCodigoBarras_TextChanged);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(313, 286);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(428, 37);
            this.tbPrecio.TabIndex = 16;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(7, 289);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(79, 28);
            this.lbPrecio.TabIndex = 15;
            this.lbPrecio.Text = "Precio";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(313, 213);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(428, 37);
            this.tbCantidad.TabIndex = 14;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            // 
            // tbProductoPrincipal
            // 
            this.tbProductoPrincipal.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductoPrincipal.Location = new System.Drawing.Point(313, 140);
            this.tbProductoPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProductoPrincipal.Name = "tbProductoPrincipal";
            this.tbProductoPrincipal.ReadOnly = true;
            this.tbProductoPrincipal.Size = new System.Drawing.Size(428, 37);
            this.tbProductoPrincipal.TabIndex = 13;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(7, 217);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(112, 28);
            this.lbCantidad.TabIndex = 12;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.Location = new System.Drawing.Point(7, 144);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(110, 28);
            this.lbProducto.TabIndex = 11;
            this.lbProducto.Text = "Producto";
            // 
            // lbCodigoBarras
            // 
            this.lbCodigoBarras.AutoSize = true;
            this.lbCodigoBarras.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoBarras.Location = new System.Drawing.Point(7, 68);
            this.lbCodigoBarras.Name = "lbCodigoBarras";
            this.lbCodigoBarras.Size = new System.Drawing.Size(196, 28);
            this.lbCodigoBarras.TabIndex = 10;
            this.lbCodigoBarras.Text = "Código de Barras";
            // 
            // EP_Principal
            // 
            this.EP_Principal.ContainerControl = this;
            // 
            // lbTotalVenta
            // 
            this.lbTotalVenta.AutoSize = true;
            this.lbTotalVenta.Font = new System.Drawing.Font("Book Antiqua", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalVenta.Location = new System.Drawing.Point(459, 885);
            this.lbTotalVenta.Name = "lbTotalVenta";
            this.lbTotalVenta.Size = new System.Drawing.Size(45, 52);
            this.lbTotalVenta.TabIndex = 2;
            this.lbTotalVenta.Text = "$";
            // 
            // lbVenta
            // 
            this.lbVenta.AutoSize = true;
            this.lbVenta.Font = new System.Drawing.Font("Book Antiqua", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenta.Location = new System.Drawing.Point(306, 885);
            this.lbVenta.Name = "lbVenta";
            this.lbVenta.Size = new System.Drawing.Size(128, 52);
            this.lbVenta.TabIndex = 1;
            this.lbVenta.Text = "Total";
            // 
            // PanelMenu
            // 
            this.PanelMenu.AutoScroll = true;
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.PanelMenu.Controls.Add(this.IconBtn_Configuraciones);
            this.PanelMenu.Controls.Add(this.pn_Catalogo);
            this.PanelMenu.Controls.Add(this.IconBtn_Catalogo);
            this.PanelMenu.Controls.Add(this.IconBtn_Estadisticas);
            this.PanelMenu.Controls.Add(this.IconBtn_Ventas);
            this.PanelMenu.Controls.Add(this.IconBtn_Usuarios);
            this.PanelMenu.Controls.Add(this.panel_BuscarProducto);
            this.PanelMenu.Controls.Add(this.IconBtn_BuscarProducto);
            this.PanelMenu.Controls.Add(this.pbLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(337, 1010);
            this.PanelMenu.TabIndex = 13;
            // 
            // IconBtn_Catalogo
            // 
            this.IconBtn_Catalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconBtn_Catalogo.FlatAppearance.BorderSize = 0;
            this.IconBtn_Catalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconBtn_Catalogo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_Catalogo.ForeColor = System.Drawing.Color.Black;
            this.IconBtn_Catalogo.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.IconBtn_Catalogo.IconColor = System.Drawing.Color.Black;
            this.IconBtn_Catalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_Catalogo.IconSize = 50;
            this.IconBtn_Catalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_Catalogo.Location = new System.Drawing.Point(0, 608);
            this.IconBtn_Catalogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_Catalogo.Name = "IconBtn_Catalogo";
            this.IconBtn_Catalogo.Size = new System.Drawing.Size(337, 73);
            this.IconBtn_Catalogo.TabIndex = 23;
            this.IconBtn_Catalogo.Text = "Catálogo";
            this.IconBtn_Catalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_Catalogo.UseVisualStyleBackColor = true;
            this.IconBtn_Catalogo.Click += new System.EventHandler(this.IconBtn_Catalogo_Click_1);
            // 
            // IconBtn_Estadisticas
            // 
            this.IconBtn_Estadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconBtn_Estadisticas.FlatAppearance.BorderSize = 0;
            this.IconBtn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconBtn_Estadisticas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_Estadisticas.ForeColor = System.Drawing.Color.Black;
            this.IconBtn_Estadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            this.IconBtn_Estadisticas.IconColor = System.Drawing.Color.Black;
            this.IconBtn_Estadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_Estadisticas.IconSize = 50;
            this.IconBtn_Estadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_Estadisticas.Location = new System.Drawing.Point(0, 535);
            this.IconBtn_Estadisticas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_Estadisticas.Name = "IconBtn_Estadisticas";
            this.IconBtn_Estadisticas.Size = new System.Drawing.Size(337, 73);
            this.IconBtn_Estadisticas.TabIndex = 20;
            this.IconBtn_Estadisticas.Text = "Estadísticas";
            this.IconBtn_Estadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_Estadisticas.UseVisualStyleBackColor = true;
            // 
            // IconBtn_Ventas
            // 
            this.IconBtn_Ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconBtn_Ventas.FlatAppearance.BorderSize = 0;
            this.IconBtn_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconBtn_Ventas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_Ventas.ForeColor = System.Drawing.Color.Black;
            this.IconBtn_Ventas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.IconBtn_Ventas.IconColor = System.Drawing.Color.Black;
            this.IconBtn_Ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_Ventas.IconSize = 50;
            this.IconBtn_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_Ventas.Location = new System.Drawing.Point(0, 462);
            this.IconBtn_Ventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_Ventas.Name = "IconBtn_Ventas";
            this.IconBtn_Ventas.Size = new System.Drawing.Size(337, 73);
            this.IconBtn_Ventas.TabIndex = 18;
            this.IconBtn_Ventas.Text = "Ventas";
            this.IconBtn_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_Ventas.UseVisualStyleBackColor = true;
            this.IconBtn_Ventas.Click += new System.EventHandler(this.IconBtn_Ventas_Click_1);
            // 
            // IconBtn_Usuarios
            // 
            this.IconBtn_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconBtn_Usuarios.FlatAppearance.BorderSize = 0;
            this.IconBtn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconBtn_Usuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_Usuarios.ForeColor = System.Drawing.Color.Black;
            this.IconBtn_Usuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.IconBtn_Usuarios.IconColor = System.Drawing.Color.Black;
            this.IconBtn_Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_Usuarios.IconSize = 50;
            this.IconBtn_Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_Usuarios.Location = new System.Drawing.Point(0, 389);
            this.IconBtn_Usuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_Usuarios.Name = "IconBtn_Usuarios";
            this.IconBtn_Usuarios.Size = new System.Drawing.Size(337, 73);
            this.IconBtn_Usuarios.TabIndex = 13;
            this.IconBtn_Usuarios.Text = "Usuarios";
            this.IconBtn_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_Usuarios.UseVisualStyleBackColor = true;
            // 
            // panel_BuscarProducto
            // 
            this.panel_BuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.panel_BuscarProducto.Controls.Add(this.btnBuscarxCategoria);
            this.panel_BuscarProducto.Controls.Add(this.btnBuscarxNombre);
            this.panel_BuscarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_BuscarProducto.Location = new System.Drawing.Point(0, 269);
            this.panel_BuscarProducto.Name = "panel_BuscarProducto";
            this.panel_BuscarProducto.Size = new System.Drawing.Size(337, 120);
            this.panel_BuscarProducto.TabIndex = 17;
            // 
            // btnBuscarxCategoria
            // 
            this.btnBuscarxCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarxCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarxCategoria.FlatAppearance.BorderSize = 0;
            this.btnBuscarxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarxCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarxCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarxCategoria.Location = new System.Drawing.Point(0, 60);
            this.btnBuscarxCategoria.Name = "btnBuscarxCategoria";
            this.btnBuscarxCategoria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBuscarxCategoria.Size = new System.Drawing.Size(337, 60);
            this.btnBuscarxCategoria.TabIndex = 1;
            this.btnBuscarxCategoria.Text = "Buscar Por Categoría";
            this.btnBuscarxCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarxCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarxCategoria.UseVisualStyleBackColor = false;
            this.btnBuscarxCategoria.Click += new System.EventHandler(this.btnBuscarxCategoria_Click);
            // 
            // btnBuscarxNombre
            // 
            this.btnBuscarxNombre.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarxNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarxNombre.FlatAppearance.BorderSize = 0;
            this.btnBuscarxNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarxNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarxNombre.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarxNombre.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarxNombre.Name = "btnBuscarxNombre";
            this.btnBuscarxNombre.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBuscarxNombre.Size = new System.Drawing.Size(337, 60);
            this.btnBuscarxNombre.TabIndex = 0;
            this.btnBuscarxNombre.Text = "Buscar Por Nombre";
            this.btnBuscarxNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarxNombre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarxNombre.UseVisualStyleBackColor = false;
            this.btnBuscarxNombre.Click += new System.EventHandler(this.btnBuscarxNombre_Click);
            // 
            // IconBtn_BuscarProducto
            // 
            this.IconBtn_BuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.IconBtn_BuscarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconBtn_BuscarProducto.FlatAppearance.BorderSize = 0;
            this.IconBtn_BuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconBtn_BuscarProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_BuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.IconBtn_BuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IconBtn_BuscarProducto.IconColor = System.Drawing.Color.Black;
            this.IconBtn_BuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_BuscarProducto.IconSize = 50;
            this.IconBtn_BuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_BuscarProducto.Location = new System.Drawing.Point(0, 196);
            this.IconBtn_BuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_BuscarProducto.Name = "IconBtn_BuscarProducto";
            this.IconBtn_BuscarProducto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.IconBtn_BuscarProducto.Size = new System.Drawing.Size(337, 73);
            this.IconBtn_BuscarProducto.TabIndex = 11;
            this.IconBtn_BuscarProducto.Text = "Buscar Producto";
            this.IconBtn_BuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_BuscarProducto.UseVisualStyleBackColor = false;
            this.IconBtn_BuscarProducto.Click += new System.EventHandler(this.IconBtn_BuscarProducto_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.pbLogo.Controls.Add(this.pictureBox1);
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(337, 196);
            this.pbLogo.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::El_Maquinista.Properties.Resources.El_Maquinista;
            this.pictureBox1.Location = new System.Drawing.Point(57, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_Producto
            // 
            this.panel_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            this.panel_Producto.Controls.Add(this.gpProducto);
            this.panel_Producto.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Producto.Location = new System.Drawing.Point(337, 0);
            this.panel_Producto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Producto.Name = "panel_Producto";
            this.panel_Producto.Size = new System.Drawing.Size(846, 1010);
            this.panel_Producto.TabIndex = 17;
            // 
            // gpProducto
            // 
            this.gpProducto.Controls.Add(this.lbStockDisponible);
            this.gpProducto.Controls.Add(this.tbStockDisponible);
            this.gpProducto.Controls.Add(this.lbCodigoBarras);
            this.gpProducto.Controls.Add(this.tbCodigoBarras);
            this.gpProducto.Controls.Add(this.lbProducto);
            this.gpProducto.Controls.Add(this.lbCantidad);
            this.gpProducto.Controls.Add(this.lbPrecio);
            this.gpProducto.Controls.Add(this.IconBtn_LimpiarBoleta);
            this.gpProducto.Controls.Add(this.IconBtn_RemoverProducto);
            this.gpProducto.Controls.Add(this.IconBtn_AgregarProducto);
            this.gpProducto.Controls.Add(this.pbProducto);
            this.gpProducto.Controls.Add(this.tbProductoPrincipal);
            this.gpProducto.Controls.Add(this.tbCantidad);
            this.gpProducto.Controls.Add(this.tbPrecio);
            this.gpProducto.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpProducto.Location = new System.Drawing.Point(25, 15);
            this.gpProducto.Margin = new System.Windows.Forms.Padding(4);
            this.gpProducto.Name = "gpProducto";
            this.gpProducto.Padding = new System.Windows.Forms.Padding(4);
            this.gpProducto.Size = new System.Drawing.Size(803, 982);
            this.gpProducto.TabIndex = 21;
            this.gpProducto.TabStop = false;
            this.gpProducto.Text = "Producto";
            // 
            // lbStockDisponible
            // 
            this.lbStockDisponible.AutoSize = true;
            this.lbStockDisponible.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockDisponible.Location = new System.Drawing.Point(7, 374);
            this.lbStockDisponible.Name = "lbStockDisponible";
            this.lbStockDisponible.Size = new System.Drawing.Size(174, 28);
            this.lbStockDisponible.TabIndex = 20;
            this.lbStockDisponible.Text = "Stock Producto";
            // 
            // tbStockDisponible
            // 
            this.tbStockDisponible.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockDisponible.Location = new System.Drawing.Point(313, 371);
            this.tbStockDisponible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStockDisponible.Name = "tbStockDisponible";
            this.tbStockDisponible.ReadOnly = true;
            this.tbStockDisponible.Size = new System.Drawing.Size(428, 37);
            this.tbStockDisponible.TabIndex = 21;
            // 
            // IconBtn_LimpiarBoleta
            // 
            this.IconBtn_LimpiarBoleta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_LimpiarBoleta.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.IconBtn_LimpiarBoleta.IconColor = System.Drawing.Color.Black;
            this.IconBtn_LimpiarBoleta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_LimpiarBoleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_LimpiarBoleta.Location = new System.Drawing.Point(595, 872);
            this.IconBtn_LimpiarBoleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_LimpiarBoleta.Name = "IconBtn_LimpiarBoleta";
            this.IconBtn_LimpiarBoleta.Size = new System.Drawing.Size(195, 92);
            this.IconBtn_LimpiarBoleta.TabIndex = 19;
            this.IconBtn_LimpiarBoleta.Text = "Limpiar Boleta";
            this.IconBtn_LimpiarBoleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_LimpiarBoleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_LimpiarBoleta.UseVisualStyleBackColor = true;
            this.IconBtn_LimpiarBoleta.Click += new System.EventHandler(this.IconBtn_LimpiarBoleta_Click);
            // 
            // IconBtn_RemoverProducto
            // 
            this.IconBtn_RemoverProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_RemoverProducto.IconChar = FontAwesome.Sharp.IconChar.StoreSlash;
            this.IconBtn_RemoverProducto.IconColor = System.Drawing.Color.Black;
            this.IconBtn_RemoverProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_RemoverProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_RemoverProducto.Location = new System.Drawing.Point(304, 872);
            this.IconBtn_RemoverProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_RemoverProducto.Name = "IconBtn_RemoverProducto";
            this.IconBtn_RemoverProducto.Size = new System.Drawing.Size(205, 92);
            this.IconBtn_RemoverProducto.TabIndex = 18;
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
            this.IconBtn_AgregarProducto.Location = new System.Drawing.Point(7, 872);
            this.IconBtn_AgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_AgregarProducto.Name = "IconBtn_AgregarProducto";
            this.IconBtn_AgregarProducto.Size = new System.Drawing.Size(235, 92);
            this.IconBtn_AgregarProducto.TabIndex = 17;
            this.IconBtn_AgregarProducto.Text = "Agregar Producto";
            this.IconBtn_AgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_AgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_AgregarProducto.UseVisualStyleBackColor = true;
            this.IconBtn_AgregarProducto.Click += new System.EventHandler(this.IconBtn_AgregarProducto_Click);
            // 
            // pbProducto
            // 
            this.pbProducto.Location = new System.Drawing.Point(193, 447);
            this.pbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(467, 398);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProducto.TabIndex = 3;
            this.pbProducto.TabStop = false;
            // 
            // IconBtn_ConfirmarVenta
            // 
            this.IconBtn_ConfirmarVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_ConfirmarVenta.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.IconBtn_ConfirmarVenta.IconColor = System.Drawing.Color.Black;
            this.IconBtn_ConfirmarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_ConfirmarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_ConfirmarVenta.Location = new System.Drawing.Point(7, 872);
            this.IconBtn_ConfirmarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_ConfirmarVenta.Name = "IconBtn_ConfirmarVenta";
            this.IconBtn_ConfirmarVenta.Size = new System.Drawing.Size(229, 92);
            this.IconBtn_ConfirmarVenta.TabIndex = 20;
            this.IconBtn_ConfirmarVenta.Text = "Confirmar Venta";
            this.IconBtn_ConfirmarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_ConfirmarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_ConfirmarVenta.UseVisualStyleBackColor = true;
            this.IconBtn_ConfirmarVenta.Click += new System.EventHandler(this.IconBtn_ConfirmarVenta_Click);
            // 
            // panel_BoletaProductos
            // 
            this.panel_BoletaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            this.panel_BoletaProductos.Controls.Add(this.gpBoleta);
            this.panel_BoletaProductos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_BoletaProductos.Location = new System.Drawing.Point(1176, 0);
            this.panel_BoletaProductos.Margin = new System.Windows.Forms.Padding(4);
            this.panel_BoletaProductos.Name = "panel_BoletaProductos";
            this.panel_BoletaProductos.Size = new System.Drawing.Size(748, 1010);
            this.panel_BoletaProductos.TabIndex = 18;
            // 
            // gpBoleta
            // 
            this.gpBoleta.Controls.Add(this.dgBoleta);
            this.gpBoleta.Controls.Add(this.lbTotalVenta);
            this.gpBoleta.Controls.Add(this.IconBtn_ConfirmarVenta);
            this.gpBoleta.Controls.Add(this.lbVenta);
            this.gpBoleta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoleta.Location = new System.Drawing.Point(14, 15);
            this.gpBoleta.Margin = new System.Windows.Forms.Padding(4);
            this.gpBoleta.Name = "gpBoleta";
            this.gpBoleta.Padding = new System.Windows.Forms.Padding(4);
            this.gpBoleta.Size = new System.Drawing.Size(721, 982);
            this.gpBoleta.TabIndex = 21;
            this.gpBoleta.TabStop = false;
            this.gpBoleta.Text = "Boleta";
            // 
            // pn_Catalogo
            // 
            this.pn_Catalogo.Controls.Add(this.btnIngresarStock);
            this.pn_Catalogo.Controls.Add(this.btnModificar_RemoverProducto);
            this.pn_Catalogo.Controls.Add(this.btnAgregarProducto);
            this.pn_Catalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Catalogo.Location = new System.Drawing.Point(0, 681);
            this.pn_Catalogo.Name = "pn_Catalogo";
            this.pn_Catalogo.Size = new System.Drawing.Size(337, 180);
            this.pn_Catalogo.TabIndex = 24;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProducto.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(337, 60);
            this.btnAgregarProducto.TabIndex = 0;
            this.btnAgregarProducto.Text = "Agregar Nuevo Producto";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnModificar_RemoverProducto
            // 
            this.btnModificar_RemoverProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar_RemoverProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificar_RemoverProducto.IconColor = System.Drawing.Color.Black;
            this.btnModificar_RemoverProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar_RemoverProducto.Location = new System.Drawing.Point(0, 60);
            this.btnModificar_RemoverProducto.Name = "btnModificar_RemoverProducto";
            this.btnModificar_RemoverProducto.Size = new System.Drawing.Size(337, 60);
            this.btnModificar_RemoverProducto.TabIndex = 1;
            this.btnModificar_RemoverProducto.Text = "Modificar/Eliminar Producto";
            this.btnModificar_RemoverProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar_RemoverProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar_RemoverProducto.UseVisualStyleBackColor = true;
            this.btnModificar_RemoverProducto.Click += new System.EventHandler(this.btnModificar_RemoverProducto_Click);
            // 
            // btnIngresarStock
            // 
            this.btnIngresarStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngresarStock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIngresarStock.IconColor = System.Drawing.Color.Black;
            this.btnIngresarStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresarStock.Location = new System.Drawing.Point(0, 120);
            this.btnIngresarStock.Name = "btnIngresarStock";
            this.btnIngresarStock.Size = new System.Drawing.Size(337, 60);
            this.btnIngresarStock.TabIndex = 2;
            this.btnIngresarStock.Text = "Modificar Stock Producto";
            this.btnIngresarStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIngresarStock.UseVisualStyleBackColor = true;
            this.btnIngresarStock.Click += new System.EventHandler(this.btnIngresarStock_Click);
            // 
            // IconBtn_Configuraciones
            // 
            this.IconBtn_Configuraciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconBtn_Configuraciones.FlatAppearance.BorderSize = 0;
            this.IconBtn_Configuraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconBtn_Configuraciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconBtn_Configuraciones.ForeColor = System.Drawing.Color.Black;
            this.IconBtn_Configuraciones.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.IconBtn_Configuraciones.IconColor = System.Drawing.Color.Black;
            this.IconBtn_Configuraciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBtn_Configuraciones.IconSize = 50;
            this.IconBtn_Configuraciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconBtn_Configuraciones.Location = new System.Drawing.Point(0, 861);
            this.IconBtn_Configuraciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconBtn_Configuraciones.Name = "IconBtn_Configuraciones";
            this.IconBtn_Configuraciones.Size = new System.Drawing.Size(337, 73);
            this.IconBtn_Configuraciones.TabIndex = 27;
            this.IconBtn_Configuraciones.Text = "Configuraciones";
            this.IconBtn_Configuraciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconBtn_Configuraciones.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1924, 1010);
            this.Controls.Add(this.panel_BoletaProductos);
            this.Controls.Add(this.panel_Producto);
            this.Controls.Add(this.PanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El Maquinista";
            ((System.ComponentModel.ISupportInitialize)(this.dgBoleta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_Principal)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.panel_BuscarProducto.ResumeLayout(false);
            this.pbLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Producto.ResumeLayout(false);
            this.gpProducto.ResumeLayout(false);
            this.gpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.panel_BoletaProductos.ResumeLayout(false);
            this.gpBoleta.ResumeLayout(false);
            this.gpBoleta.PerformLayout();
            this.pn_Catalogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbProducto;
        private System.Windows.Forms.Label lbCodigoBarras;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbPrecio;
        public System.Windows.Forms.TextBox tbCodigoBarras;
        public System.Windows.Forms.TextBox tbCantidad;
        public System.Windows.Forms.TextBox tbProductoPrincipal;
        public System.Windows.Forms.TextBox tbPrecio;
        public System.Windows.Forms.ErrorProvider EP_Principal;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel pbLogo;
        public System.Windows.Forms.Label lbTotalVenta;
        private FontAwesome.Sharp.IconButton IconBtn_BuscarProducto;
        private FontAwesome.Sharp.IconButton IconBtn_AgregarProducto;
        private FontAwesome.Sharp.IconButton IconBtn_LimpiarBoleta;
        private FontAwesome.Sharp.IconButton IconBtn_RemoverProducto;
        private System.Windows.Forms.Panel panel_Producto;
        private System.Windows.Forms.GroupBox gpProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_BoletaProductos;
        private System.Windows.Forms.GroupBox gpBoleta;
        public System.Windows.Forms.DataGridView dgBoleta;
        public System.Windows.Forms.Label lbVenta;
        public FontAwesome.Sharp.IconButton IconBtn_ConfirmarVenta;
        private System.Windows.Forms.Panel panel_BuscarProducto;
        private System.Windows.Forms.Button btnBuscarxCategoria;
        private System.Windows.Forms.Button btnBuscarxNombre;
        private FontAwesome.Sharp.IconButton IconBtn_Usuarios;
        private FontAwesome.Sharp.IconButton IconBtn_Ventas;
        private FontAwesome.Sharp.IconButton IconBtn_Catalogo;
        private FontAwesome.Sharp.IconButton IconBtn_Estadisticas;
        private System.Windows.Forms.Label lbStockDisponible;
        public System.Windows.Forms.TextBox tbStockDisponible;
        private FontAwesome.Sharp.IconButton IconBtn_Configuraciones;
        private System.Windows.Forms.Panel pn_Catalogo;
        private FontAwesome.Sharp.IconButton btnIngresarStock;
        private FontAwesome.Sharp.IconButton btnModificar_RemoverProducto;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
    }
}

