namespace El_Maquinista.Formularios_Ventas
{
    partial class Calendario_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbFechasInicial = new System.Windows.Forms.Label();
            this.lbRangoFechas = new System.Windows.Forms.Label();
            this.lbFechaFinal = new System.Windows.Forms.Label();
            this.gbFechasSeleccionadas = new System.Windows.Forms.GroupBox();
            this.cbRango_Fechas = new System.Windows.Forms.CheckBox();
            this.dpFecha_Final = new System.Windows.Forms.DateTimePicker();
            this.dpFecha_Inicial = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.dgInformacion_Ventas = new System.Windows.Forms.DataGridView();
            this.lbVenta_Seleccionada = new System.Windows.Forms.Label();
            this.lbVenta_Numero = new System.Windows.Forms.Label();
            this.lbFecha_Numero = new System.Windows.Forms.Label();
            this.lbFecha_Seleccionada = new System.Windows.Forms.Label();
            this.lbHora_Numero = new System.Windows.Forms.Label();
            this.lbHoraSeleccionada = new System.Windows.Forms.Label();
            this.lbTotal_Numero = new System.Windows.Forms.Label();
            this.lbTotalVenta_Seleccionada = new System.Windows.Forms.Label();
            this.btn_DetalleBoleta = new FontAwesome.Sharp.IconButton();
            this.gpBoxVentas = new System.Windows.Forms.GroupBox();
            this.lbTOTALVENTA_NUMERICO = new System.Windows.Forms.Label();
            this.lbTOTALVENTA_INTERVALO = new System.Windows.Forms.Label();
            this.gbFechasSeleccionadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInformacion_Ventas)).BeginInit();
            this.gpBoxVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFechasInicial
            // 
            this.lbFechasInicial.AutoSize = true;
            this.lbFechasInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechasInicial.Location = new System.Drawing.Point(15, 28);
            this.lbFechasInicial.Name = "lbFechasInicial";
            this.lbFechasInicial.Size = new System.Drawing.Size(127, 24);
            this.lbFechasInicial.TabIndex = 1;
            this.lbFechasInicial.Text = "Fecha Inicial";
            // 
            // lbRangoFechas
            // 
            this.lbRangoFechas.AutoSize = true;
            this.lbRangoFechas.Location = new System.Drawing.Point(251, 28);
            this.lbRangoFechas.Name = "lbRangoFechas";
            this.lbRangoFechas.Size = new System.Drawing.Size(0, 17);
            this.lbRangoFechas.TabIndex = 2;
            // 
            // lbFechaFinal
            // 
            this.lbFechaFinal.AutoSize = true;
            this.lbFechaFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaFinal.Location = new System.Drawing.Point(15, 126);
            this.lbFechaFinal.Name = "lbFechaFinal";
            this.lbFechaFinal.Size = new System.Drawing.Size(118, 24);
            this.lbFechaFinal.TabIndex = 3;
            this.lbFechaFinal.Text = "Fecha Final";
            this.lbFechaFinal.Visible = false;
            // 
            // gbFechasSeleccionadas
            // 
            this.gbFechasSeleccionadas.Controls.Add(this.cbRango_Fechas);
            this.gbFechasSeleccionadas.Controls.Add(this.dpFecha_Final);
            this.gbFechasSeleccionadas.Controls.Add(this.dpFecha_Inicial);
            this.gbFechasSeleccionadas.Controls.Add(this.lbFechasInicial);
            this.gbFechasSeleccionadas.Controls.Add(this.lbRangoFechas);
            this.gbFechasSeleccionadas.Controls.Add(this.btnConsultar);
            this.gbFechasSeleccionadas.Controls.Add(this.lbFechaFinal);
            this.gbFechasSeleccionadas.Location = new System.Drawing.Point(12, 12);
            this.gbFechasSeleccionadas.Name = "gbFechasSeleccionadas";
            this.gbFechasSeleccionadas.Size = new System.Drawing.Size(1178, 207);
            this.gbFechasSeleccionadas.TabIndex = 8;
            this.gbFechasSeleccionadas.TabStop = false;
            // 
            // cbRango_Fechas
            // 
            this.cbRango_Fechas.AutoSize = true;
            this.cbRango_Fechas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRango_Fechas.Location = new System.Drawing.Point(479, 27);
            this.cbRango_Fechas.Name = "cbRango_Fechas";
            this.cbRango_Fechas.Size = new System.Drawing.Size(264, 27);
            this.cbRango_Fechas.TabIndex = 10;
            this.cbRango_Fechas.Text = "Habilitar Rango de Fechas";
            this.cbRango_Fechas.UseVisualStyleBackColor = true;
            this.cbRango_Fechas.CheckedChanged += new System.EventHandler(this.cbRango_Fechas_CheckedChanged);
            // 
            // dpFecha_Final
            // 
            this.dpFecha_Final.CustomFormat = "dd-MM-yyyy";
            this.dpFecha_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFecha_Final.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFecha_Final.Location = new System.Drawing.Point(228, 119);
            this.dpFecha_Final.Name = "dpFecha_Final";
            this.dpFecha_Final.Size = new System.Drawing.Size(184, 30);
            this.dpFecha_Final.TabIndex = 9;
            this.dpFecha_Final.Visible = false;
            this.dpFecha_Final.ValueChanged += new System.EventHandler(this.dpFecha_Final_ValueChanged);
            // 
            // dpFecha_Inicial
            // 
            this.dpFecha_Inicial.CustomFormat = "dd-MM-yyyy";
            this.dpFecha_Inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFecha_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFecha_Inicial.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dpFecha_Inicial.Location = new System.Drawing.Point(228, 27);
            this.dpFecha_Inicial.Name = "dpFecha_Inicial";
            this.dpFecha_Inicial.Size = new System.Drawing.Size(184, 30);
            this.dpFecha_Inicial.TabIndex = 8;
            this.dpFecha_Inicial.ValueChanged += new System.EventHandler(this.dpFecha_Inicial_ValueChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.PooStorm;
            this.btnConsultar.IconColor = System.Drawing.Color.Black;
            this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultar.Location = new System.Drawing.Point(479, 106);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(219, 68);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar Fecha";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.Location = new System.Drawing.Point(955, 295);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(189, 92);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // dgInformacion_Ventas
            // 
            this.dgInformacion_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgInformacion_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            this.dgInformacion_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgInformacion_Ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInformacion_Ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgInformacion_Ventas.ColumnHeadersHeight = 55;
            this.dgInformacion_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgInformacion_Ventas.EnableHeadersVisualStyles = false;
            this.dgInformacion_Ventas.GridColor = System.Drawing.Color.Black;
            this.dgInformacion_Ventas.Location = new System.Drawing.Point(38, 36);
            this.dgInformacion_Ventas.Name = "dgInformacion_Ventas";
            this.dgInformacion_Ventas.ReadOnly = true;
            this.dgInformacion_Ventas.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgInformacion_Ventas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgInformacion_Ventas.RowTemplate.Height = 24;
            this.dgInformacion_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInformacion_Ventas.Size = new System.Drawing.Size(672, 351);
            this.dgInformacion_Ventas.TabIndex = 9;
            this.dgInformacion_Ventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInformacion_Ventas_CellClick);
            this.dgInformacion_Ventas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgInformacion_Ventas_RowsAdded);
            this.dgInformacion_Ventas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgInformacion_Ventas_RowsRemoved);
            this.dgInformacion_Ventas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgInformacion_Ventas_KeyUp);
            // 
            // lbVenta_Seleccionada
            // 
            this.lbVenta_Seleccionada.AutoSize = true;
            this.lbVenta_Seleccionada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenta_Seleccionada.Location = new System.Drawing.Point(738, 36);
            this.lbVenta_Seleccionada.Name = "lbVenta_Seleccionada";
            this.lbVenta_Seleccionada.Size = new System.Drawing.Size(189, 23);
            this.lbVenta_Seleccionada.TabIndex = 10;
            this.lbVenta_Seleccionada.Text = "Venta Seleccionada:";
            // 
            // lbVenta_Numero
            // 
            this.lbVenta_Numero.AutoSize = true;
            this.lbVenta_Numero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenta_Numero.Location = new System.Drawing.Point(1003, 36);
            this.lbVenta_Numero.Name = "lbVenta_Numero";
            this.lbVenta_Numero.Size = new System.Drawing.Size(79, 23);
            this.lbVenta_Numero.TabIndex = 11;
            this.lbVenta_Numero.Text = "Número";
            // 
            // lbFecha_Numero
            // 
            this.lbFecha_Numero.AutoSize = true;
            this.lbFecha_Numero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha_Numero.Location = new System.Drawing.Point(1003, 92);
            this.lbFecha_Numero.Name = "lbFecha_Numero";
            this.lbFecha_Numero.Size = new System.Drawing.Size(79, 23);
            this.lbFecha_Numero.TabIndex = 13;
            this.lbFecha_Numero.Text = "Número";
            // 
            // lbFecha_Seleccionada
            // 
            this.lbFecha_Seleccionada.AutoSize = true;
            this.lbFecha_Seleccionada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha_Seleccionada.Location = new System.Drawing.Point(738, 92);
            this.lbFecha_Seleccionada.Name = "lbFecha_Seleccionada";
            this.lbFecha_Seleccionada.Size = new System.Drawing.Size(193, 23);
            this.lbFecha_Seleccionada.TabIndex = 12;
            this.lbFecha_Seleccionada.Text = "Fecha Seleccionada:";
            // 
            // lbHora_Numero
            // 
            this.lbHora_Numero.AutoSize = true;
            this.lbHora_Numero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora_Numero.Location = new System.Drawing.Point(1003, 153);
            this.lbHora_Numero.Name = "lbHora_Numero";
            this.lbHora_Numero.Size = new System.Drawing.Size(79, 23);
            this.lbHora_Numero.TabIndex = 15;
            this.lbHora_Numero.Text = "Número";
            // 
            // lbHoraSeleccionada
            // 
            this.lbHoraSeleccionada.AutoSize = true;
            this.lbHoraSeleccionada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoraSeleccionada.Location = new System.Drawing.Point(738, 153);
            this.lbHoraSeleccionada.Name = "lbHoraSeleccionada";
            this.lbHoraSeleccionada.Size = new System.Drawing.Size(181, 23);
            this.lbHoraSeleccionada.TabIndex = 14;
            this.lbHoraSeleccionada.Text = "Hora Seleccionada:";
            // 
            // lbTotal_Numero
            // 
            this.lbTotal_Numero.AutoSize = true;
            this.lbTotal_Numero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal_Numero.Location = new System.Drawing.Point(1003, 213);
            this.lbTotal_Numero.Name = "lbTotal_Numero";
            this.lbTotal_Numero.Size = new System.Drawing.Size(79, 23);
            this.lbTotal_Numero.TabIndex = 17;
            this.lbTotal_Numero.Text = "Número";
            // 
            // lbTotalVenta_Seleccionada
            // 
            this.lbTotalVenta_Seleccionada.AutoSize = true;
            this.lbTotalVenta_Seleccionada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalVenta_Seleccionada.Location = new System.Drawing.Point(738, 213);
            this.lbTotalVenta_Seleccionada.Name = "lbTotalVenta_Seleccionada";
            this.lbTotalVenta_Seleccionada.Size = new System.Drawing.Size(181, 23);
            this.lbTotalVenta_Seleccionada.TabIndex = 16;
            this.lbTotalVenta_Seleccionada.Text = "Total Seleccionado:";
            // 
            // btn_DetalleBoleta
            // 
            this.btn_DetalleBoleta.IconChar = FontAwesome.Sharp.IconChar.PooStorm;
            this.btn_DetalleBoleta.IconColor = System.Drawing.Color.Black;
            this.btn_DetalleBoleta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DetalleBoleta.Location = new System.Drawing.Point(742, 295);
            this.btn_DetalleBoleta.Name = "btn_DetalleBoleta";
            this.btn_DetalleBoleta.Size = new System.Drawing.Size(189, 92);
            this.btn_DetalleBoleta.TabIndex = 11;
            this.btn_DetalleBoleta.Text = "Detalle Boleta";
            this.btn_DetalleBoleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DetalleBoleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DetalleBoleta.UseVisualStyleBackColor = true;
            this.btn_DetalleBoleta.Click += new System.EventHandler(this.btn_DetalleBoleta_Click);
            // 
            // gpBoxVentas
            // 
            this.gpBoxVentas.Controls.Add(this.lbTOTALVENTA_NUMERICO);
            this.gpBoxVentas.Controls.Add(this.lbTOTALVENTA_INTERVALO);
            this.gpBoxVentas.Controls.Add(this.dgInformacion_Ventas);
            this.gpBoxVentas.Controls.Add(this.btn_DetalleBoleta);
            this.gpBoxVentas.Controls.Add(this.lbVenta_Seleccionada);
            this.gpBoxVentas.Controls.Add(this.lbTotal_Numero);
            this.gpBoxVentas.Controls.Add(this.btnLimpiar);
            this.gpBoxVentas.Controls.Add(this.lbVenta_Numero);
            this.gpBoxVentas.Controls.Add(this.lbTotalVenta_Seleccionada);
            this.gpBoxVentas.Controls.Add(this.lbFecha_Seleccionada);
            this.gpBoxVentas.Controls.Add(this.lbHora_Numero);
            this.gpBoxVentas.Controls.Add(this.lbFecha_Numero);
            this.gpBoxVentas.Controls.Add(this.lbHoraSeleccionada);
            this.gpBoxVentas.Location = new System.Drawing.Point(12, 245);
            this.gpBoxVentas.Name = "gpBoxVentas";
            this.gpBoxVentas.Size = new System.Drawing.Size(1178, 503);
            this.gpBoxVentas.TabIndex = 18;
            this.gpBoxVentas.TabStop = false;
            // 
            // lbTOTALVENTA_NUMERICO
            // 
            this.lbTOTALVENTA_NUMERICO.AutoSize = true;
            this.lbTOTALVENTA_NUMERICO.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTALVENTA_NUMERICO.Location = new System.Drawing.Point(500, 419);
            this.lbTOTALVENTA_NUMERICO.Name = "lbTOTALVENTA_NUMERICO";
            this.lbTOTALVENTA_NUMERICO.Size = new System.Drawing.Size(31, 32);
            this.lbTOTALVENTA_NUMERICO.TabIndex = 19;
            this.lbTOTALVENTA_NUMERICO.Text = "$";
            // 
            // lbTOTALVENTA_INTERVALO
            // 
            this.lbTOTALVENTA_INTERVALO.AutoSize = true;
            this.lbTOTALVENTA_INTERVALO.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTOTALVENTA_INTERVALO.Location = new System.Drawing.Point(248, 419);
            this.lbTOTALVENTA_INTERVALO.Name = "lbTOTALVENTA_INTERVALO";
            this.lbTOTALVENTA_INTERVALO.Size = new System.Drawing.Size(173, 32);
            this.lbTOTALVENTA_INTERVALO.TabIndex = 18;
            this.lbTOTALVENTA_INTERVALO.Text = "Total Ventas ";
            // 
            // Calendario_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1200, 758);
            this.Controls.Add(this.gpBoxVentas);
            this.Controls.Add(this.gbFechasSeleccionadas);
            this.Name = "Calendario_Ventas";
            this.Text = "Calendario de Ventas";
            this.gbFechasSeleccionadas.ResumeLayout(false);
            this.gbFechasSeleccionadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInformacion_Ventas)).EndInit();
            this.gpBoxVentas.ResumeLayout(false);
            this.gpBoxVentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbFechasInicial;
        private System.Windows.Forms.Label lbRangoFechas;
        private System.Windows.Forms.Label lbFechaFinal;
        private FontAwesome.Sharp.IconButton btnConsultar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.GroupBox gbFechasSeleccionadas;
        private System.Windows.Forms.DateTimePicker dpFecha_Inicial;
        private System.Windows.Forms.DateTimePicker dpFecha_Final;
        private System.Windows.Forms.CheckBox cbRango_Fechas;
        public System.Windows.Forms.DataGridView dgInformacion_Ventas;
        private System.Windows.Forms.Label lbVenta_Seleccionada;
        private System.Windows.Forms.Label lbVenta_Numero;
        private System.Windows.Forms.Label lbFecha_Numero;
        private System.Windows.Forms.Label lbFecha_Seleccionada;
        private System.Windows.Forms.Label lbHora_Numero;
        private System.Windows.Forms.Label lbHoraSeleccionada;
        private System.Windows.Forms.Label lbTotal_Numero;
        private System.Windows.Forms.Label lbTotalVenta_Seleccionada;
        private FontAwesome.Sharp.IconButton btn_DetalleBoleta;
        private System.Windows.Forms.GroupBox gpBoxVentas;
        private System.Windows.Forms.Label lbTOTALVENTA_NUMERICO;
        private System.Windows.Forms.Label lbTOTALVENTA_INTERVALO;
    }
}