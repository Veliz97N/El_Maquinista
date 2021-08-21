using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace El_Maquinista
{
    class BasedeDatos
    {
        //ARREGLAR LA FECHA CONCHESUMARE A DD-MM-YYYY

        #region BuscarProducto Codigo-Nombre-Categoría
        public string ConsultarBase(TextBox tbCodigoBarras)
        {
            string Producto=string.Empty;            
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            string queryIniciarConsulta = "SELECT * FROM inventario";
            MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
            MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
            ComandoBaseDatos.CommandTimeout = 60;
            try
            {
                ConexionBaseDatos.Open();
                MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (tbCodigoBarras.Text == Lector.GetString(0))
                        {
                            //Producto =         0        1         2           3              4   
                            //Producto = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion
                            Producto = Lector.GetString(0) + ";" + Lector.GetString(1) + ";" + Lector.GetString(6).Replace("$", "").Replace(".", "") + ";" + Lector.GetString(7) + ";" + Lector.GetString(8).Replace("$", "").Replace(".", "");
                            ConexionBaseDatos.Close();
                            return Producto;
                        }
                    }
                }
                ConexionBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            return Producto;
        }
        public List<string> Buscar_ProductoNombre(string nombreProducto)
        {
            List<string> ListaProductos = new List<string>();
            string Producto = string.Empty;
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            string queryIniciarConsulta = "SELECT * FROM inventario WHERE PRODUCTO LIKE"+"'%"+nombreProducto+"%'";
            MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
            MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
            ComandoBaseDatos.CommandTimeout = 60;
            try
            {
                ConexionBaseDatos.Open();
                MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        //Producto =         0        1         2           3              4   
                        //Producto = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion
                        Producto = Lector.GetString(0) + ";" + Lector.GetString(1) + ";" + Lector.GetString(6).Replace("$", "").Replace(".", "") + ";" + Lector.GetString(7) + ";" + Lector.GetString(8).Replace("$", "").Replace(".", "");
                        ListaProductos.Add(Producto);
                    }
                }
                ConexionBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            return ListaProductos;
        }

        public List<string> Buscar_ProductoCategoria(string Categoria)
        {
            List<string> ListaProductos = new List<string>();
            string Producto = string.Empty;
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            string queryIniciarConsulta = "SELECT * FROM inventario WHERE TIPO ="+"'"+Categoria+"'";
            MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
            MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
            ComandoBaseDatos.CommandTimeout = 60;
            try
            {
                ConexionBaseDatos.Open();
                MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        //Producto =         0        1         2           3              4   
                        //Producto = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion
                        Producto = Lector.GetString(0) + ";" + Lector.GetString(1) + ";" + Lector.GetString(6).Replace("$", "").Replace(".", "") + ";" + Lector.GetString(7) + ";" + Lector.GetString(8).Replace("$", "").Replace(".", "");
                        ListaProductos.Add(Producto);
                    }
                }
                ConexionBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            return ListaProductos;
        }
        #endregion

        #region Tipo de Datos
        public List<string> TipodeProductos()
        {
            List<string> ListadeProductos = new List<string>();
            string Producto = string.Empty;
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            string queryIniciarConsulta = "SELECT TIPO FROM inventario GROUP BY TIPO";//Hacerla mas vérsatil, que reciba un indicador y haga algo
            MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
            MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
            ComandoBaseDatos.CommandTimeout = 60;
            try
            {
                ConexionBaseDatos.Open();
                MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        //Producto =         0        1         2           3              4   
                        //Producto = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion
                        Producto = Lector.GetString(0);
                        ListadeProductos.Add(Producto);                      
                    }
                    return ListadeProductos;
                }
                ConexionBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            return ListadeProductos;
        }
        #endregion

        #region Cálculo de Stock
        public void ModificarStock(DataGridView dgBoleta)   
        {
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            foreach (DataGridViewRow fila in dgBoleta.Rows)
            {
                string nombre_producto = Convert.ToString(fila.Cells[2].Value);
                string cantidad_producto= Convert.ToString(fila.Cells[4].Value);
                string queryIniciarConsulta = "UPDATE inventario SET STOCK = STOCK-"+ cantidad_producto+" "+"WHERE PRODUCTO ='"+nombre_producto+"'";
                MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
                MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
                ComandoBaseDatos.CommandTimeout = 60;
                try
                {
                    ConexionBaseDatos.Open();
                    MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
                    ConexionBaseDatos.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }
        #endregion

        #region Ingresar Ventas

        static private string NumeroIdentificador = string.Empty; //Se define un string que posee el numero de identificador, el identificador relaciona la tabla boleta y venta
        public void GetNumero_Identificador() //Obtiene el numero de identificador de la ultima venta realizada y le suma 1 para aplicarlo en la venta nueva
        {            
            //VOID, DE EL NO SE OBTIENE NADA
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            string queryConsultar_Identificador = "SELECT COUNT(*) FROM ventas_el_maquinista";            
            MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion); 
            MySqlCommand ComandoBaseDatos = new MySqlCommand(queryConsultar_Identificador, ConexionBaseDatos);
            ConexionBaseDatos.Open();
            NumeroIdentificador = Convert.ToString(ComandoBaseDatos.ExecuteScalar()); //Numero  Identificador            
            if (Convert.ToInt32(NumeroIdentificador) == 0) //Si la tabla es nueva no poseera filas, por tanto el numero de identificador sera 0
            {
                NumeroIdentificador = "1"; //Se asigna uno para indicar que es la primera venta historica
            }
            else //Sino, si el numero de identificador es mayor a uno
            {
                NumeroIdentificador = Convert.ToString(Convert.ToInt32(NumeroIdentificador) + 1); //Se aumenta el identificador en uno para la venta actual
            }                        
            ConexionBaseDatos.Close();
        }

        static private string Numero_Fecha_Venta = string.Empty; //Este string almacena el numero de venta y la fecha en la que se realizo de la forma 1;2021-03-21
        public void GetNumero_Venta() //Metodo que obtiene el numero y fecha de la ultima venta realizada
        {   
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            string queryConsultar_Venta = "SELECT * FROM ventas_el_maquinista ORDER BY FECHA DESC LIMIT 1"; //Ordena los datos descendientemente segun la fecha y solo muestra el ultimo
            MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
            MySqlCommand ComandoBaseDatos = new MySqlCommand(queryConsultar_Venta, ConexionBaseDatos);
            ConexionBaseDatos.Open();
            MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
            if (Lector.HasRows) //Si existen filas en lector
            {
                while (Lector.Read()) //Lector las lee
                {
                    Numero_Fecha_Venta = Lector.GetString(1)+ (';') + Lector.GetString(2).Split(' ')[0]; //Numero_Fecha_Venta= "1;2021-03-21";
                }                
            }
            //Sino existen filas en el lector indica que no se han realizado ventas, por tanto Numero_Fecha_Venta = string.Empty
            ConexionBaseDatos.Close();
        }

        static private string Numero_Ventas_Dia = string.Empty; //Almacena el numero de ventas que se realiza por dia, este string se reinicia a uno segun condiciones
        public void IngresarVentas_Globales(string total) //Ingresa las ventas a la tabla ventas. Recibe como parametro el texto del label total de venta
            //IDENTIFICADOR - NUMERO_VENTAS_DIA - FECHA - TOTAL
        {
            //Nota: El identificador relaciona esta tabla "ventas_el_maquinista" con la de "boletas_el_maquinista"
            if (Numero_Fecha_Venta != string.Empty) //Si Numero_Fecha_Venta distinto de string.Empty entonces existen ventas
            {
                string formato = "dd-MM-yyyy"; //Se define el formato con el que se mostraran las fechas (Año, Mes, Día)
                DateTime fecha_Actual_1 = DateTime.ParseExact(DateTime.Now.ToString(formato), formato, CultureInfo.InvariantCulture); //Se obtiene la fecha actual 
                DateTime UltimaFecha = DateTime.ParseExact(Numero_Fecha_Venta.Split(';')[1], formato, CultureInfo.InvariantCulture); //Se obtiene la fecha de la ULTIMA venta realizada en el local
                if ((fecha_Actual_1 - UltimaFecha).Days >= 1) //Si la diferencia de dias entre las fechas es mayor o igual a 1 entonces se debe reiniciar el numero de ventas x día
                {
                    Numero_Ventas_Dia = "1"; //Se define a numero de ventas por dia igual a 1
                }
                else //Sino, si la diferencia es menor a 1
                {
                    Numero_Ventas_Dia = Convert.ToString(Convert.ToInt32(Numero_Fecha_Venta.Split(';')[0]) + 1); //Se suma una venta a las ventas diarias
                } 
            }
            else if (Numero_Fecha_Venta ==string.Empty) //SINO, si el Numero_Fecha_Venta es equivalente a string.Empty entonces no existen ventas
            {
                Numero_Ventas_Dia = "1"; //Por tanto sera la primera venta historica del local y se define a Numero_Fecha_Venta igual a 1
            }            
            string MontoTotal = total; //Recibe el valor del texto del lbTotalVenta
            string fecha_hora = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"); //Se obtiene la fecha y hora de la venta y se lleva al formato string igual a yyyy-MM-dd HH:mm:ss. NOTA: La hora se utilizara mas adelante para analizar distribuciones horarias en las ventas
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;"; //Conexion
            string queryIniciarConsulta = "INSERT INTO ventas_el_maquinista (IDENTIFICADOR,NUMERO_VENTAS,FECHA,TOTAL) VALUES('"+ NumeroIdentificador + "','"+ Numero_Ventas_Dia+"','"+fecha_hora+"','"+MontoTotal+"')";
            MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
            MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
            ComandoBaseDatos.CommandTimeout = 60;
            try
            {
                ConexionBaseDatos.Open();
                MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
                ConexionBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public void IngresarBoleta(DataGridView dgBoleta) //Metodo que ingresa los productos del datagridView dgBoleta a la tabla boletas_el_maquinista
        {
            //Nota: El identificador relaciona esta tabla "boletas_el_maquinista" con la de "ventas_el_maquinista"
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            foreach (DataGridViewRow fila in dgBoleta.Rows) //Para cada fila en el datagridview dgBoleta
            {                
                string CODIGO_BARRA = Convert.ToString(fila.Cells[1].Value); 
                string PRODUCTO = Convert.ToString(fila.Cells[2].Value);
                string LOCAL = "EDDY";//Convert.ToString(fila.Cells[3].Value);
                string CANTIDAD = Convert.ToString(fila.Cells[4].Value);
                string TOTAL = Convert.ToString(fila.Cells[6].Value);
                string queryIniciarConsulta = "INSERT INTO boletas_el_maquinista (IDENTIFICADOR,CODIGO_BARRA,PRODUCTO,LOCAL,CANTIDAD,TOTAL) VALUES('"+ NumeroIdentificador + "','" + CODIGO_BARRA + "','" + PRODUCTO + "','" + LOCAL + "','" + CANTIDAD + "','" + TOTAL + "')";
                MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
                MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
                ComandoBaseDatos.CommandTimeout = 60;
                try
                {
                    ConexionBaseDatos.Open();
                    MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
                    ConexionBaseDatos.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }            
        }
        #endregion

        #region Consultar Ventas

        public List<string> VentasdelDia = new List<string>();

        public void Consultar_Dia_Venta(string fecha_dia)
        {
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            string queryIniciarConsulta = "SELECT * FROM ventas_el_maquinista WHERE date_format(str_to_date(left(FECHA,10),'%d-%m-%Y'),'%Y%m%d') = date_format(str_to_date('"+fecha_dia+"','%d-%m-%Y'),'%Y%m%d'); ";
            MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
            MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
            ComandoBaseDatos.CommandTimeout = 60;
            try
            {
                ConexionBaseDatos.Open();
                MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        VentasdelDia.Add(Lector.GetString(0) + ";" + Lector.GetString(1) + ";" + Lector.GetString(2) + ";" + Lector.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("No existen datos para las fechas ingresadas");
                }
                ConexionBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public List<string> Ventas_rango_dias = new List<string>();

        public void Consultar_rango_dias_Venta(string fecha_dia_inicial, string fecha_dia_final)
        {
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            string queryIniciarConsulta = "SELECT * FROM ventas_el_maquinista WHERE date_format(str_to_date(left(FECHA,10),'%d-%m-%Y'),'%Y%m%d') >= date_format(str_to_date('" + fecha_dia_inicial + "','%d-%m-%Y'),'%Y%m%d') AND date_format(str_to_date(left(FECHA,10),'%d-%m-%Y'),'%Y%m%d') <= date_format(str_to_date('" + fecha_dia_final + "','%d-%m-%Y'),'%Y%m%d');";
            MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
            MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
            ComandoBaseDatos.CommandTimeout = 60;
            try
            {
                ConexionBaseDatos.Open();
                MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        Ventas_rango_dias.Add(Lector.GetString(0) + ";" + Lector.GetString(1) + ";" + Lector.GetString(2) + ";" + Lector.GetString(3));                        
                    }
                }
                else
                {
                    MessageBox.Show("No existen datos para las fechas ingresadas");
                }
                ConexionBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        #endregion

        #region Consultar Boleta en Funcion de la Venta
        public List<string> Detalle_Boleta = new List<string>();
        public void Consultar_Detalle_Boleta(string Identificador)
        {
            string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
            string queryIniciarConsulta = "SELECT * FROM boletas_el_maquinista WHERE IDENTIFICADOR ='" + Identificador+"';";
            MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
            MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
            ComandoBaseDatos.CommandTimeout = 60;
            try
            {
                ConexionBaseDatos.Open();
                MySqlDataReader Lector = ComandoBaseDatos.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        string producto = Lector.GetString(1) + ";" + Lector.GetString(2) + ";" + Lector.GetString(3) + ";" + Lector.GetString(4) + ";" + Lector.GetString(5);
                        Detalle_Boleta.Add(producto);
                    }
                }
                else
                {
                    MessageBox.Show("No existen datos para la venta seleccionada");
                }
                ConexionBaseDatos.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        #endregion
    }
}
