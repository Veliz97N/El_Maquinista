using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace El_Maquinista
{
    class ClaseVentaInmediata
    {
        
        
        int venta = 0;
        int fila = 0;
        public bool FindProduct_Boleta(DataGridView dgBoleta,string producto) //Falta agregar el codigo de barras cabron jejejjeje
        {
            if (dgBoleta.Rows.Count > 0) //Si el datagrid Boleta tiene mas de una fila
            {
                for (int x = 0; x < dgBoleta.Rows.Count; x++) //Para cada x menor a la cantidad de filas del datagrid 
                {
                    //Producto =         0        1         2           3              4   
                    //Producto = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion
                    if (Convert.ToString(dgBoleta.Rows[x].Cells[1].Value) == producto.Split(';')[0] && producto.Split(';')[0]!="") //Si la posicion de ese datagrid coincide con el codigo de barras del producto 
                    {
                        fila = x;
                        //MessageBox.Show("ENTRE A IGUALDAD DE CODIGO DE BARRAS");
                        return true;
                        
                    }                    
                    else if(Convert.ToString(dgBoleta.Rows[x].Cells[2].Value) == producto.Split(';')[1] && producto.Split(';')[0] == "")
                    {
                        fila = x;
                        //MessageBox.Show("ENTRE A IGUALDAD DE Producto");
                        return true;                        
                    }
                }
            }            
            return false;
        }
        public void AddProducto_Boleta(DataGridView dgBoleta, string producto, bool existeProducto,string cantidad)
        {
            //Producto =         0        1         2           3              4   
            //Producto = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion
            dgBoleta.Visible = true;
            if (existeProducto)
            {
                dgBoleta.Rows[fila].Cells[4].Value = Convert.ToString(Convert.ToInt32(dgBoleta.Rows[fila].Cells[4].Value) + Convert.ToInt32(cantidad));
            }
            else
            {
                dgBoleta.Rows.Add(); //Se añade una fila
                int Venta = dgBoleta.Rows.Count;
                dgBoleta.Rows[Venta - 1].Cells[0].Value = Venta;//La columna 0 de la fila agregada es Número de Venta
                dgBoleta.Rows[Venta - 1].Cells[1].Value = producto.Split(';')[0];//FormularioPrincipal.tbCodigoBarras.Text; //Se agrega la columna 1
                dgBoleta.Rows[Venta - 1].Cells[2].Value = producto.Split(';')[1]; //Se agrega la columna 2
                //dgBoleta.Rows[Venta - 1].Cells[3].Value = //Local //Se agrega la columna 3
                dgBoleta.Rows[Venta - 1].Cells[4].Value = cantidad; //Se agrega la columna 4
                dgBoleta.Rows[Venta - 1].Cells[5].Value = producto.Split(';')[2];
                //dgBoleta.Rows[Venta - 1].Cells[6].Value = producto.Split(';')[2];
                dgBoleta.Rows[Venta - 1].Cells[7].Value = producto.Split(';')[3]; //Se agrega la columna 7
                dgBoleta.Rows[Venta - 1].Cells[8].Value = producto.Split(';')[4]; //Se agrega la columna 8                                             
            }
        }
        public List<List<String>> CreateList_Promocion(DataGridView dgBoleta) //Funcion que creara las listas "Si aplica promocion - No aplica promocion
        {
            //******************************EN ESTA FUNCION HAY UN ERROR**********************************************
            
            List<string> Lista_Si_AplicaPromocion = new List<string>(); //Creo lista SI APLICA PROMOCION para los productos que si aplican
            List<string> Lista_No_AplicaPromocion = new List<string>(); //Creo lista NO APLICA PROMOCION para los productos que no aplican
            List<List<string>> List_Promocion = new List<List<string>>();//Creo una lista donde se añadiran ambas listas
            foreach (DataGridViewRow fila in dgBoleta.Rows) //Para cada fila en el datagrid boleta
            {
                int Cantidad = Convert.ToInt32(fila.Cells[4].Value); //Se define un entero cantidad que corresponde a la cantidad presentada en el datagridBoleta
                string Producto_Cantidad = Convert.ToString(fila.Cells[1].Value) +";"+Convert.ToString(fila.Cells[2].Value) +";"+ Convert.ToString(fila.Cells[5].Value)+";"+
                Convert.ToString(fila.Cells[7].Value) + ";"+Convert.ToString(fila.Cells[8].Value) + ";"+Convert.ToString(Cantidad); //Se define un string que contiene datos del producto + la cantidad 
                //Producto_Cantidad =         0        1         2           3              4            5 
                //Producto_Cantidad = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion;Cantidad

                if (Producto_Cantidad.Split(';')[3] == "Si") //Si el producto aplica promocion
                {
                    //MessageBox.Show(Producto_Cantidad+ "  SI");
                    if (Cantidad % 2 == 0) //Si la cantidad del producto que aplica promocion es un numero par
                    {
                        int Par = Cantidad / 2; //Obtengo el numero de promociones
                        fila.Cells[6].Value = Convert.ToString(Par * Convert.ToInt32(Producto_Cantidad.Split(';')[4])); //Obtengo el total multiplicando el numero de promos por el precio de cada promo
                    }
                    else //Si el numero no es par
                    {
                        int Par = Cantidad / 2; // Obtengo la cantidad de promos ingresadas
                        int Impar = Cantidad % 2;//Obtengo el resto de la division
                        fila.Cells[6].Value = Convert.ToString(Par * Convert.ToInt32(Producto_Cantidad.Split(';')[4]) + Impar * Convert.ToInt32(Producto_Cantidad.Split(';')[2])); //Obtengo el total multiplicando y sumando el total de promos y el total de items solos
                    }
                    Lista_Si_AplicaPromocion.Add(Producto_Cantidad); //Agrego el elemento a una lista para todos los que SI APLICAN PROMOCION
                }                                               
                else if (Producto_Cantidad.Split(';')[3] == "No") //Si el producto NO APLICA PROMO
                {
                    fila.Cells[6].Value = Convert.ToString(Convert.ToInt32(Producto_Cantidad.Split(';')[2]) * Convert.ToInt32(Producto_Cantidad.Split(';')[5]));
                    Lista_No_AplicaPromocion.Add(Producto_Cantidad); //Se añade a la lista de los que no aplican promocion
                }
            }
            List_Promocion.Add(Lista_Si_AplicaPromocion); //Agrego a la lista general la LISTA_SI_APLICAPROMOCION
            List_Promocion.Add(Lista_No_AplicaPromocion);//Agrego a la lista general la LISTA_NO_APLICAPROMOCION
            return List_Promocion;
        }
        public void ClasificarPromociones(List<string>Si_AplicaPromocion)
        {
            var ComparativaPromocion = Si_AplicaPromocion.GroupBy(x => x.Split(';')[4]); //Los agrupa segun el valor de la promo en una sublista, ejempplo
            //Lista de los 1100 --> [1,2,3,4] y asi xde
            foreach (var Promos in ComparativaPromocion)
            {
                int cantidadPar = 0;
                int PrecioSolo = 0;
                foreach (var Promo in Promos)
                {
                    cantidadPar += Convert.ToInt32(Promo.Split(';')[5]);
                    PrecioSolo = Convert.ToInt32(Promo.Split(';')[2]);
                }
                if (cantidadPar % 2 == 0)
                {
                    int Par = cantidadPar / 2;
                    venta += Convert.ToInt32(Par * Convert.ToInt32(Promos.Key));
                }
                else
                {
                    int Par = cantidadPar / 2;
                    int Impar = cantidadPar % 2;
                    venta += (Par * Convert.ToInt32(Promos.Key)) + (Impar * Convert.ToInt32(PrecioSolo));
                }
            }
        }
        public int CalcularMontoVenta(List<string>No_AplicaPromocion)
        {
            foreach (string producto in No_AplicaPromocion)
            {
                venta += Convert.ToInt32(producto.Split(';')[2]) * Convert.ToInt32(producto.Split(';')[5]);
            }            
            return venta;
        }
    }
}