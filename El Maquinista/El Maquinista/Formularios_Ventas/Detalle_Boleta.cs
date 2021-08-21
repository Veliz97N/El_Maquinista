using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Maquinista.Formularios_Ventas
{
    public partial class Detalle_Boleta : Form
    {
        public Detalle_Boleta(string Identificador)
        {
            InitializeComponent();
            InicializarBoleta();
            RellenarBoleta(Identificador);
        }
        private void InicializarBoleta()
        {
            dgDetalle_Boleta.RowHeadersVisible = false;
            dgDetalle_Boleta.AllowUserToAddRows = false;
            dgDetalle_Boleta.Columns.Add("CODIGO_BARRA","Código de Barras");
            dgDetalle_Boleta.Columns.Add("PRODUCTO", "Producto");
            dgDetalle_Boleta.Columns.Add("LOCAL", "Local");
            dgDetalle_Boleta.Columns.Add("CANTIDAD", "Cantidad");
            dgDetalle_Boleta.Columns.Add("TOTAL_VENTA", "Total");
        }
        private void RellenarBoleta(string Identificador)
        {
            BasedeDatos MyBaseDatos = new BasedeDatos();
            MyBaseDatos.Consultar_Detalle_Boleta(Identificador);
            for (int x = 0; x< MyBaseDatos.Detalle_Boleta.Count; x++)
            {
                dgDetalle_Boleta.Rows.Add();
                dgDetalle_Boleta.Rows[x].Cells[0].Value = MyBaseDatos.Detalle_Boleta[x].Split(';')[0];
                dgDetalle_Boleta.Rows[x].Cells[1].Value = MyBaseDatos.Detalle_Boleta[x].Split(';')[1];
                dgDetalle_Boleta.Rows[x].Cells[2].Value = MyBaseDatos.Detalle_Boleta[x].Split(';')[2];
                dgDetalle_Boleta.Rows[x].Cells[3].Value = MyBaseDatos.Detalle_Boleta[x].Split(';')[3];
                dgDetalle_Boleta.Rows[x].Cells[4].Value = MyBaseDatos.Detalle_Boleta[x].Split(';')[4];
            }
            
        }
    }
}
