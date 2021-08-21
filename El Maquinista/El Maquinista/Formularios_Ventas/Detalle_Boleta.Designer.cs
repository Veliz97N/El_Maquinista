namespace El_Maquinista.Formularios_Ventas
{
    partial class Detalle_Boleta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgDetalle_Boleta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle_Boleta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDetalle_Boleta
            // 
            this.dgDetalle_Boleta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDetalle_Boleta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            this.dgDetalle_Boleta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDetalle_Boleta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalle_Boleta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetalle_Boleta.ColumnHeadersHeight = 65;
            this.dgDetalle_Boleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetalle_Boleta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetalle_Boleta.EnableHeadersVisualStyles = false;
            this.dgDetalle_Boleta.GridColor = System.Drawing.Color.Black;
            this.dgDetalle_Boleta.Location = new System.Drawing.Point(12, 12);
            this.dgDetalle_Boleta.Name = "dgDetalle_Boleta";
            this.dgDetalle_Boleta.ReadOnly = true;
            this.dgDetalle_Boleta.RowHeadersWidth = 51;
            this.dgDetalle_Boleta.RowTemplate.Height = 24;
            this.dgDetalle_Boleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalle_Boleta.Size = new System.Drawing.Size(998, 543);
            this.dgDetalle_Boleta.TabIndex = 0;
            // 
            // Detalle_Boleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(196)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1022, 567);
            this.Controls.Add(this.dgDetalle_Boleta);
            this.Name = "Detalle_Boleta";
            this.Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle_Boleta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDetalle_Boleta;
    }
}