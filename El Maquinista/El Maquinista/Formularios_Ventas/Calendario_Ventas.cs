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
    public partial class Calendario_Ventas : Form
    {
        //OBJETIVO DE HOY EN LA NOCHE: DEJAR LISTO EL INGRESAR O MODIFICAR STOCK Y CATALOGO DE 10 PM HACIA ABAJO
        public Calendario_Ventas()
        {
            InitializeComponent();
            string formato = "dd-MM-yyyy";
            fecha_inicial = dpFecha_Inicial.Value.ToString(formato);
            Inicializar_Datagridview();
            Inicializar_Labels();
        }

        #region Incializar Componentes
        private void Inicializar_Datagridview()
        {
            dgInformacion_Ventas.RowHeadersVisible = false;
            dgInformacion_Ventas.AllowUserToAddRows = false;
            dgInformacion_Ventas.Visible = false; //ACA PONERLE FALSOOO *************************************************************************
            dgInformacion_Ventas.Columns.Add("IDENTIFICADOR","Identificador");
            dgInformacion_Ventas.Columns[0].Visible = false;
            dgInformacion_Ventas.Columns.Add("NUMERO_VENTA_DIA", "Venta del Día");
            dgInformacion_Ventas.Columns.Add("FECHA", "Fecha");
            dgInformacion_Ventas.Columns.Add("HORA", "Hora");
            dgInformacion_Ventas.Columns.Add("TOTAL_VENTA", "Total de Venta");
        }
        private void Inicializar_Labels()
        {
            lbFecha_Numero.Visible = false;
            lbFecha_Seleccionada.Visible = false;
            lbHoraSeleccionada.Visible = false;
            lbHora_Numero.Visible = false;
            lbTotalVenta_Seleccionada.Visible = false;
            lbTotal_Numero.Visible = false;
            lbVenta_Numero.Visible = false;
            lbVenta_Seleccionada.Visible = false;
            btn_DetalleBoleta.Visible = false;
            btnLimpiar.Visible = false;
            lbTOTALVENTA_INTERVALO.Visible = false;
            lbTOTALVENTA_NUMERICO.Visible = false;
            lbTOTALVENTA_INTERVALO.Visible = false;
            lbTOTALVENTA_NUMERICO.Visible = false;
        }
        private void Visibiliziar_Labels()
        {
            lbFecha_Numero.Visible =  true;
            lbFecha_Seleccionada.Visible =  true;
            lbHoraSeleccionada.Visible =   true;
            lbHora_Numero.Visible =        true;
            lbTotalVenta_Seleccionada.Visible = true;
            lbTotal_Numero.Visible =  true;
            lbVenta_Numero.Visible =       true;
            lbVenta_Seleccionada.Visible =   true;
            btn_DetalleBoleta.Visible =  true;
            lbTOTALVENTA_INTERVALO.Visible = true;
            lbTOTALVENTA_NUMERICO.Visible = true;
            btnLimpiar.Visible = true;
        }
        #endregion

        #region Cambio de Fechas
        private void cbRango_Fechas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRango_Fechas.Checked == true)
            {
                lbFechaFinal.Visible = true;
                dpFecha_Final.Visible = true;
            }
            else
            {
                lbFechaFinal.Visible = false;
                dpFecha_Final.Visible = false;
            }
        }
        private string fecha_inicial = string.Empty;
        private string fecha_final = string.Empty;
        private bool distintos_dias = false;
        private void dpFecha_Inicial_ValueChanged(object sender, EventArgs e)
        {
            string formato = "dd-MM-yyyy";
            fecha_inicial = dpFecha_Inicial.Value.ToString(formato);
        }

        private void dpFecha_Final_ValueChanged(object sender, EventArgs e)
        {
            string formato = "dd-MM-yyyy";
            fecha_final = dpFecha_Final.Value.ToString(formato);
            if ((dpFecha_Final.Value - dpFecha_Inicial.Value).Days >= 1)
            {
                distintos_dias = true;
            }
            else
            {
                distintos_dias = false;
                MessageBox.Show("Ingrese una fecha distinta o mayor a la fecha inicial");
            }
        }
        #endregion

        #region Limpiar Formulario
        private void Limpiar()
        {
            dgInformacion_Ventas.Rows.Clear();
            lbFechaFinal.Visible = false;
            dpFecha_Final.Visible = false;
            dgInformacion_Ventas.Visible = false;
            Inicializar_Labels();

        }
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion

        #region Buscar Informacion segun Fecha
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgInformacion_Ventas.Rows.Clear();
            BasedeDatos MyBaseDatos = new BasedeDatos();
            if (dpFecha_Final.Visible == true && distintos_dias == true)
            {
                MyBaseDatos.Consultar_rango_dias_Venta(fecha_inicial, fecha_final);
                
                for (int x = 0; x < MyBaseDatos.Ventas_rango_dias.Count; x++)
                {
                    dgInformacion_Ventas.Rows.Add();
                    dgInformacion_Ventas.Rows[x].Cells[0].Value = MyBaseDatos.Ventas_rango_dias[x].Split(';')[0];
                    dgInformacion_Ventas.Rows[x].Cells[1].Value = MyBaseDatos.Ventas_rango_dias[x].Split(';')[1];
                    dgInformacion_Ventas.Rows[x].Cells[2].Value = MyBaseDatos.Ventas_rango_dias[x].Split(';')[2].Split(' ')[0];
                    dgInformacion_Ventas.Rows[x].Cells[3].Value = MyBaseDatos.Ventas_rango_dias[x].Split(';')[2].Split(' ')[1];
                    dgInformacion_Ventas.Rows[x].Cells[4].Value = MyBaseDatos.Ventas_rango_dias[x].Split(';')[3];
                }
                
                if (dgInformacion_Ventas.Rows.Count >= 1)
                {
                    CalcularTotalVenta_rangoFechas();                    
                }
                try
                {
                    fila = 0;
                    dgInformacion_Ventas.Rows[fila].Selected = true;
                    EstablecerVenta(fila);
                }
                catch
                {}
            }
            else 
            {
                MyBaseDatos.Consultar_Dia_Venta(fecha_inicial);
                for (int x = 0; x < MyBaseDatos.VentasdelDia.Count; x++)
                {
                    dgInformacion_Ventas.Rows.Add();
                    dgInformacion_Ventas.Rows[x].Cells[0].Value = MyBaseDatos.VentasdelDia[x].Split(';')[0];
                    dgInformacion_Ventas.Rows[x].Cells[1].Value = MyBaseDatos.VentasdelDia[x].Split(';')[1];
                    dgInformacion_Ventas.Rows[x].Cells[2].Value = MyBaseDatos.VentasdelDia[x].Split(';')[2].Split(' ')[0];
                    dgInformacion_Ventas.Rows[x].Cells[3].Value = MyBaseDatos.VentasdelDia[x].Split(';')[2].Split(' ')[1];
                    dgInformacion_Ventas.Rows[x].Cells[4].Value = MyBaseDatos.VentasdelDia[x].Split(';')[3];
                }
                if (dgInformacion_Ventas.Rows.Count >= 1)
                {
                    CalcularTotalVenta_rangoFechas();
                }
                try
                {
                    fila = 0;
                    dgInformacion_Ventas.Rows[fila].Selected = true;
                    EstablecerVenta(fila);
                }
                catch
                { }
            }            
        }
        private void CalcularTotalVenta_rangoFechas()
        {
            int totalventa = 0;
            foreach (DataGridViewRow fila in dgInformacion_Ventas.Rows)
            {
                totalventa += Convert.ToInt32(Convert.ToString(fila.Cells[4].Value).Replace('$',' '));
            }
            lbTOTALVENTA_NUMERICO.Text = "$ "+Convert.ToString(totalventa);
        }
        #endregion

        #region Buscar Boleta de Venta
        private int fila;
        private void EstablecerVenta(int fila)
        {
            lbVenta_Numero.Text = Convert.ToString(dgInformacion_Ventas.Rows[fila].Cells[1].Value);
            lbFecha_Numero.Text = Convert.ToString(dgInformacion_Ventas.Rows[fila].Cells[2].Value);
            lbHora_Numero.Text = Convert.ToString(dgInformacion_Ventas.Rows[fila].Cells[3].Value);
            lbTotal_Numero.Text = Convert.ToString(dgInformacion_Ventas.Rows[fila].Cells[4].Value);
        }
        private void dgInformacion_Ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            EstablecerVenta(fila);
        }
        private void dgInformacion_Ventas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                fila = dgInformacion_Ventas.CurrentRow.Index;
                EstablecerVenta(fila);
            }
        }

        private void btn_DetalleBoleta_Click(object sender, EventArgs e)
        {
            Formularios_Ventas.Detalle_Boleta MyDetalle_Boleta = new Detalle_Boleta(Convert.ToString(dgInformacion_Ventas.Rows[fila].Cells[0].Value));
            MyDetalle_Boleta.ShowDialog();
        }
        #endregion

        #region Contabilizar filas datagrid
        private void VerificarCantidadFilas_datagridview()
        {
            if (dgInformacion_Ventas.Rows.Count >= 1)
            {
                Visibiliziar_Labels();                
                dgInformacion_Ventas.Visible = true;
            }
            else
            {                
                Inicializar_Labels();
                dgInformacion_Ventas.Visible = false;
            }
        }

        private void dgInformacion_Ventas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            VerificarCantidadFilas_datagridview();            
        }

        private void dgInformacion_Ventas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            VerificarCantidadFilas_datagridview();            
        }
        #endregion


    }
}