namespace El_Maquinista.Formularios_Catalogo
{
    partial class Modificar_Stock_Producto
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
            this.lbCodigoBarras = new System.Windows.Forms.Label();
            this.tbCodigo_Barras = new System.Windows.Forms.TextBox();
            this.lbStockActual = new System.Windows.Forms.Label();
            this.tbStockActual = new System.Windows.Forms.TextBox();
            this.lbIngresar_Remover_Stock = new System.Windows.Forms.Label();
            this.tbStockFinal = new System.Windows.Forms.TextBox();
            this.lbStockFinal = new System.Windows.Forms.Label();
            this.rbIngresar_Stock = new System.Windows.Forms.RadioButton();
            this.rbRemoverStock = new System.Windows.Forms.RadioButton();
            this.IngresarStock_Numerico = new System.Windows.Forms.NumericUpDown();
            this.btn_Confirmar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.IngresarStock_Numerico)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigoBarras
            // 
            this.lbCodigoBarras.AutoSize = true;
            this.lbCodigoBarras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoBarras.Location = new System.Drawing.Point(31, 39);
            this.lbCodigoBarras.Name = "lbCodigoBarras";
            this.lbCodigoBarras.Size = new System.Drawing.Size(165, 23);
            this.lbCodigoBarras.TabIndex = 0;
            this.lbCodigoBarras.Text = "Codigo de Barras";
            // 
            // tbCodigo_Barras
            // 
            this.tbCodigo_Barras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo_Barras.Location = new System.Drawing.Point(332, 36);
            this.tbCodigo_Barras.Name = "tbCodigo_Barras";
            this.tbCodigo_Barras.Size = new System.Drawing.Size(338, 30);
            this.tbCodigo_Barras.TabIndex = 1;
            // 
            // lbStockActual
            // 
            this.lbStockActual.AutoSize = true;
            this.lbStockActual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockActual.Location = new System.Drawing.Point(31, 115);
            this.lbStockActual.Name = "lbStockActual";
            this.lbStockActual.Size = new System.Drawing.Size(119, 23);
            this.lbStockActual.TabIndex = 2;
            this.lbStockActual.Text = "Stock Actual";
            // 
            // tbStockActual
            // 
            this.tbStockActual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockActual.Location = new System.Drawing.Point(332, 112);
            this.tbStockActual.Name = "tbStockActual";
            this.tbStockActual.Size = new System.Drawing.Size(338, 30);
            this.tbStockActual.TabIndex = 3;
            // 
            // lbIngresar_Remover_Stock
            // 
            this.lbIngresar_Remover_Stock.AutoSize = true;
            this.lbIngresar_Remover_Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngresar_Remover_Stock.Location = new System.Drawing.Point(31, 260);
            this.lbIngresar_Remover_Stock.Name = "lbIngresar_Remover_Stock";
            this.lbIngresar_Remover_Stock.Size = new System.Drawing.Size(139, 23);
            this.lbIngresar_Remover_Stock.TabIndex = 4;
            this.lbIngresar_Remover_Stock.Text = "Ingresar Stock";
            // 
            // tbStockFinal
            // 
            this.tbStockFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockFinal.Location = new System.Drawing.Point(328, 339);
            this.tbStockFinal.Name = "tbStockFinal";
            this.tbStockFinal.Size = new System.Drawing.Size(342, 30);
            this.tbStockFinal.TabIndex = 7;
            // 
            // lbStockFinal
            // 
            this.lbStockFinal.AutoSize = true;
            this.lbStockFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockFinal.Location = new System.Drawing.Point(31, 342);
            this.lbStockFinal.Name = "lbStockFinal";
            this.lbStockFinal.Size = new System.Drawing.Size(107, 23);
            this.lbStockFinal.TabIndex = 6;
            this.lbStockFinal.Text = "Stock Final";
            // 
            // rbIngresar_Stock
            // 
            this.rbIngresar_Stock.AutoSize = true;
            this.rbIngresar_Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngresar_Stock.Location = new System.Drawing.Point(154, 185);
            this.rbIngresar_Stock.Name = "rbIngresar_Stock";
            this.rbIngresar_Stock.Size = new System.Drawing.Size(160, 27);
            this.rbIngresar_Stock.TabIndex = 8;
            this.rbIngresar_Stock.TabStop = true;
            this.rbIngresar_Stock.Text = "Ingresar Stock";
            this.rbIngresar_Stock.UseVisualStyleBackColor = true;
            // 
            // rbRemoverStock
            // 
            this.rbRemoverStock.AutoSize = true;
            this.rbRemoverStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRemoverStock.Location = new System.Drawing.Point(426, 185);
            this.rbRemoverStock.Name = "rbRemoverStock";
            this.rbRemoverStock.Size = new System.Drawing.Size(166, 27);
            this.rbRemoverStock.TabIndex = 9;
            this.rbRemoverStock.TabStop = true;
            this.rbRemoverStock.Text = "Remover Stock";
            this.rbRemoverStock.UseVisualStyleBackColor = true;
            // 
            // IngresarStock_Numerico
            // 
            this.IngresarStock_Numerico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresarStock_Numerico.Location = new System.Drawing.Point(328, 260);
            this.IngresarStock_Numerico.Name = "IngresarStock_Numerico";
            this.IngresarStock_Numerico.Size = new System.Drawing.Size(342, 30);
            this.IngresarStock_Numerico.TabIndex = 10;
            this.IngresarStock_Numerico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Confirmar.IconColor = System.Drawing.Color.Black;
            this.btn_Confirmar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Confirmar.Location = new System.Drawing.Point(207, 425);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(174, 51);
            this.btn_Confirmar.TabIndex = 11;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.Location = new System.Drawing.Point(468, 425);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(174, 51);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Modificar_Stock_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.IngresarStock_Numerico);
            this.Controls.Add(this.rbRemoverStock);
            this.Controls.Add(this.rbIngresar_Stock);
            this.Controls.Add(this.tbStockFinal);
            this.Controls.Add(this.lbStockFinal);
            this.Controls.Add(this.lbIngresar_Remover_Stock);
            this.Controls.Add(this.tbStockActual);
            this.Controls.Add(this.lbStockActual);
            this.Controls.Add(this.tbCodigo_Barras);
            this.Controls.Add(this.lbCodigoBarras);
            this.Name = "Modificar_Stock_Producto";
            this.Text = "Modificar_Stock_Producto";
            ((System.ComponentModel.ISupportInitialize)(this.IngresarStock_Numerico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoBarras;
        private System.Windows.Forms.TextBox tbCodigo_Barras;
        private System.Windows.Forms.Label lbStockActual;
        private System.Windows.Forms.TextBox tbStockActual;
        private System.Windows.Forms.Label lbIngresar_Remover_Stock;
        private System.Windows.Forms.TextBox tbStockFinal;
        private System.Windows.Forms.Label lbStockFinal;
        private System.Windows.Forms.RadioButton rbIngresar_Stock;
        private System.Windows.Forms.RadioButton rbRemoverStock;
        private System.Windows.Forms.NumericUpDown IngresarStock_Numerico;
        private FontAwesome.Sharp.IconButton btn_Confirmar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
    }
}