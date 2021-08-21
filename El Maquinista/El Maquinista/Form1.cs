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
using FontAwesome.Sharp;

namespace El_Maquinista
{

    public partial class Principal : Form
    {
        //Carpetas
        private IconButton CurrentButton;
        private Panel LeftBorderBtn;
        private Form FormularioActivo;
        //SQL
        static string StringConexion = "datasource=127.0.0.1;port=3306;username=root;password=;database=el_maquinista;";
        static string queryIniciarConsulta = "SELECT * FROM inventario";
        static MySqlConnection ConexionBaseDatos = new MySqlConnection(StringConexion);
        MySqlCommand ComandoBaseDatos = new MySqlCommand(queryIniciarConsulta, ConexionBaseDatos);
        //FIN DEFINICION CONSTANTES

        public Principal()
        {
            InitializeComponent();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(7, IconBtn_BuscarProducto.Height);
            PanelMenu.Controls.Add(LeftBorderBtn);
            EstatusInicial();
            this.DoubleBuffered = true;
        }
        private void EstatusInicial()
        {
            panel_BuscarProducto.Visible = false;
            pn_Catalogo.Visible = false;
            dgBoleta.RowHeadersVisible = false;
            dgBoleta.Columns.Add("NVenta", "Nº de Venta"); //Se crea columna de numero de venta [0]
            dgBoleta.Columns.Add("CodigoBarra", "Código de Barras"); //Se crea columna de código de barras [1]
            dgBoleta.Columns.Add("Producto", "Producto"); //Se crea columna de ítem [2]
            dgBoleta.Columns.Add("Local", "Local"); //Se crea columna de local [3]
            dgBoleta.Columns.Add("Cantidad", "Cantidad"); //Se crea columna de cantidad  [4]
            dgBoleta.Columns.Add("PrecioSolo", "PrecioSolo"); //Se crea columna de precio solo [5]
            dgBoleta.Columns[5].Visible = false;
            dgBoleta.Columns.Add("Precio", "Precio");//Se crea columna de precio [6]
            dgBoleta.Columns.Add("APromo", "Aplica Promoción"); //Se crea columna de precio [7]
            dgBoleta.Columns[7].Visible = false;
            dgBoleta.Columns.Add("PrecioPromo", "Precio Promoción"); //Se crea columna de precio [8]
            dgBoleta.Columns[8].Visible = false;
            dgBoleta.Visible = true; //Se define la visibilidad en false
            dgBoleta.Columns[1].Visible = false;
            dgBoleta.Columns[3].Visible = false;
            IconBtn_ConfirmarVenta.Visible = false;
            lbTotalVenta.Visible = true ;
            lbVenta.Visible = true;
            tbCodigoBarras.Select();
        }
        private void EsconderSubMenu()
        {
            if (panel_BuscarProducto.Visible)
            {
                panel_BuscarProducto.Visible = false;
            }
            else if (pn_Catalogo.Visible)
            {
                pn_Catalogo.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel PanelSubMenu)
        {
            if (PanelSubMenu.Visible==false)
            {
                EsconderSubMenu();
                PanelSubMenu.Visible = true;
            }
            else
            {
                EsconderSubMenu();
            }
        }
        #region Botones Laterales Derechos
        private void IconBtn_BuscarProducto_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panel_BuscarProducto);
        }      
        
        private void btnBuscarxNombre_Click(object sender, EventArgs e)
        {
            Formularios.Busqueda_Nombre MyBusquedaNombre = new Formularios.Busqueda_Nombre();
            this.AddOwnedForm(MyBusquedaNombre);
            //BotonActivo(sender, RGBColor.color1);
            AbrirFormulariosPanel(MyBusquedaNombre);
        }
        private void btnBuscarxCategoria_Click(object sender, EventArgs e)
        {
            Formularios.ProductosCategoria MyBusquedaCateogoria = new Formularios.ProductosCategoria();
            this.AddOwnedForm(MyBusquedaCateogoria);
            AbrirFormulariosPanel(MyBusquedaCateogoria);
        }
        #endregion

        #region ConfiguracionBotones
        private void BotonActivo(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                BotonDesactivado();
                CurrentButton = (IconButton)senderBtn;
                CurrentButton.BackColor = Color.FromArgb(37, 36, 81);
                CurrentButton.ForeColor = color;
                CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
                CurrentButton.IconColor = color;
                CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border Button
                LeftBorderBtn.BackColor = color;
                LeftBorderBtn.Location = new Point(0, CurrentButton.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront();
            }
        }
        private void BotonDesactivado()
        {
            if (CurrentButton != null)
            {
                CurrentButton.BackColor = Color.FromArgb(32, 43, 87);
                CurrentButton.ForeColor = Color.Gainsboro;
                CurrentButton.TextAlign = ContentAlignment.MiddleLeft;
                CurrentButton.IconColor = Color.Gainsboro;
                CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion

        //ACA HAY OTRAS WEAS ********************************** ORDENAR CODIGOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        public void Limpiar()
        {            
            tbProductoPrincipal.Text = String.Empty; // Nombre del producto.
            tbCantidad.Text = String.Empty; //Cantidad del producto.
            tbPrecio.Text = String.Empty; //Precio del producto, este precio depende de la cantidad.
            pbProducto.Image = null; //Imagen del producto.            
            tbCodigoBarras.Select();
        }
        public void Ocultar_Labels()
        {
            IconBtn_ConfirmarVenta.Visible = false;
            lbTotalVenta.Visible = false;
            lbVenta.Visible = false;
        }
        string Producto;
        
        private void tbCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            BasedeDatos MyBaseDatos = new BasedeDatos();
            if (tbCodigoBarras.Text!="")
            {
                Producto=MyBaseDatos.ConsultarBase(tbCodigoBarras);
                if (Producto != string.Empty)
                {
                    tbProductoPrincipal.Text = Producto.Split(';')[1];
                    tbCantidad.Text = "1";
                    tbPrecio.Text = Producto.Split(';')[2];
                    EP_Principal.Clear();
                }
                else
                {
                    EP_Principal.SetError(tbCodigoBarras,"No se ha encontrado el producto");
                    Limpiar();
                }
            }
            else
            {
                Limpiar();
            }           
        }       
        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            bool CantidadNumerico = int.TryParse(tbCantidad.Text, out int cantidad);
            if (tbCantidad.Text != "" && CantidadNumerico)
            {
                EP_Principal.Clear();
                if (Producto.Split(';')[3] == "Si" && cantidad%2 == 0)
                {
                    int cantidadPar = (cantidad / 2);
                    tbPrecio.Text = "$" + Convert.ToString(cantidadPar* Convert.ToInt32(Producto.Split(';')[4].Replace("$", "").Replace(".", "")));
                }
                else if(Producto.Split(';')[3] == "Si" && cantidad % 2 == 1)
                {
                    int cantidadPar = (cantidad / 2);
                    int restoCantidad = (cantidad % 2);
                    tbPrecio.Text = "$" + Convert.ToString(cantidadPar * Convert.ToInt32(Producto.Split(';')[4].Replace("$", "").Replace(".", "")) + restoCantidad* Convert.ToInt32(Producto.Split(';')[2]));
                }
                else
                {
                    tbPrecio.Text = "$" + Convert.ToString(cantidad * Convert.ToInt32(Producto.Split(';')[2]));
                }
            }
            else
            {
                EP_Principal.SetError(tbCantidad, "El valor de cantidad ingresado no es válido");
                tbPrecio.Text = "Ingrese un valor númerico en cantidad";
            }            
        }
        //Estructura 
        private struct RGBColor
        {
          public static Color color1= Color.FromArgb(172,126,241 );
          public static Color color2= Color.FromArgb(249,118,176 );
          public static Color color3= Color.FromArgb(253,138,114 );
          public static Color color4= Color.FromArgb(95,77,221   );
          public static Color color5= Color.FromArgb(249,88,155  );
          public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void AbrirFormulariosPanel(Form Formulario)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            panel_Producto.Controls.Add(Formulario);
            panel_Producto.Tag = Formulario;
            Formulario.BringToFront();
            Formulario.Show();                        
        }

        private void IconBtn_Usuarios_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, RGBColor.color2);
        }

        private void IconBtn_Ventas_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, RGBColor.color3);
        }

        private void IconBtn_Estadisticas_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, RGBColor.color4);
        }

        private void IconBtn_Catalogo_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, RGBColor.color5);
        }

        private void IconBtn_Configuraciones_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, RGBColor.color6);
        }

        private void IconBtn_AgregarProducto_Click(object sender, EventArgs e)
        {
            ClaseVentaInmediata MyClaseVentaInmediata = new ClaseVentaInmediata();
            if (tbProductoPrincipal.Text != string.Empty && Convert.ToInt32(tbCantidad.Text) > 0)
            {
                MyClaseVentaInmediata.AddProducto_Boleta(dgBoleta, Producto, MyClaseVentaInmediata.FindProduct_Boleta(dgBoleta, Producto), tbCantidad.Text);
                MyClaseVentaInmediata.CreateList_Promocion(dgBoleta); //Aca hay un error 
                MyClaseVentaInmediata.ClasificarPromociones(MyClaseVentaInmediata.CreateList_Promocion(dgBoleta)[0]);//MyClaseVentaInmediata.CreateList_Promocion(dgBoleta,Producto)[0]);                
                lbTotalVenta.Text = "$ " + Convert.ToString(MyClaseVentaInmediata.CalcularMontoVenta(MyClaseVentaInmediata.CreateList_Promocion(dgBoleta)[1]));

                IconBtn_ConfirmarVenta.Visible = true; //Hago visible el boton de vender
                lbTotalVenta.Visible = true; //Hago visible el boton de total venta
                lbVenta.Visible = true; //Hago visible el boton de venta
                tbCodigoBarras.Text = string.Empty; //Establezco en vacio el boton codigo de barras. Esto se hace para agregar otro producto
                Limpiar(); //Limpio todos los demas textbox relacionado al producto del codigo de barras
                tbCodigoBarras.Select(); //Selecciono el textbox código de barras
            }
        }

        private void IconBtn_RemoverProducto_Click(object sender, EventArgs e)
        {
            if (dgBoleta.Rows.Count >= 1)
            {
                ClaseVentaInmediata MyClaseVentaInmediata = new ClaseVentaInmediata();
                dgBoleta.Rows.Remove(dgBoleta.CurrentRow);
                MyClaseVentaInmediata.CreateList_Promocion(dgBoleta); //Aca hay un error 
                MyClaseVentaInmediata.ClasificarPromociones(MyClaseVentaInmediata.CreateList_Promocion(dgBoleta)[0]);//MyClaseVentaInmediata.CreateList_Promocion(dgBoleta,Producto)[0]);                
                lbTotalVenta.Text = "$ " + Convert.ToString(MyClaseVentaInmediata.CalcularMontoVenta(MyClaseVentaInmediata.CreateList_Promocion(dgBoleta)[1]));

            }
        }

        private void IconBtn_LimpiarBoleta_Click(object sender, EventArgs e)
        {
            ClaseVentaInmediata MyClaseVentaInmediata = new ClaseVentaInmediata();
            dgBoleta.Rows.Clear();
            tbCodigoBarras.Text = string.Empty;
            Limpiar();
            Ocultar_Labels();
            MyClaseVentaInmediata.CreateList_Promocion(dgBoleta); //Aca hay un error 
            MyClaseVentaInmediata.ClasificarPromociones(MyClaseVentaInmediata.CreateList_Promocion(dgBoleta)[0]);//MyClaseVentaInmediata.CreateList_Promocion(dgBoleta,Producto)[0]);                
            lbTotalVenta.Text = "$ " + Convert.ToString(MyClaseVentaInmediata.CalcularMontoVenta(MyClaseVentaInmediata.CreateList_Promocion(dgBoleta)[1]));
            //CalculoVenta();
        }

        private void IconBtn_ConfirmarVenta_Click(object sender, EventArgs e)
        {
            BasedeDatos MyBasedeDatos = new BasedeDatos();
            MyBasedeDatos.GetNumero_Identificador();
            MyBasedeDatos.GetNumero_Venta();
            MyBasedeDatos.IngresarBoleta(dgBoleta);
            MyBasedeDatos.IngresarVentas_Globales(lbTotalVenta.Text);            
            MyBasedeDatos.ModificarStock(dgBoleta);

            dgBoleta.Rows.Clear();
            Limpiar();
            lbTotalVenta.Text = "$0";
            //Guardar la venta en SQL
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            
            Reset();
        }

        private void Reset()
        {
            panel_Producto.Visible = true;
            panel_BoletaProductos.Visible = true;
        }

        #region Ventas
        private void IconBtn_Ventas_Click_1(object sender, EventArgs e)
        {
            Formularios_Ventas.Calendario_Ventas MyVentas_Local = new Formularios_Ventas.Calendario_Ventas();
            MyVentas_Local.ShowDialog();
        }

        #endregion

        #region Catalogo

        private void IconBtn_Catalogo_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(pn_Catalogo);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Formularios_Catalogo.AgrearNuevoProducto MyAgregar_Nuevo_Producto = new Formularios_Catalogo.AgrearNuevoProducto();
            MyAgregar_Nuevo_Producto.ShowDialog();
        }

        private void btnModificar_RemoverProducto_Click(object sender, EventArgs e)
        {
            Formularios_Catalogo.Modificar_Eliminar_Producto MyModificar_Eliminar_Producto = new Formularios_Catalogo.Modificar_Eliminar_Producto();
            MyModificar_Eliminar_Producto.ShowDialog();
        }

        private void btnIngresarStock_Click(object sender, EventArgs e)
        {
            Formularios_Catalogo.Modificar_Stock_Producto MyModificar_Stock_Producto = new Formularios_Catalogo.Modificar_Stock_Producto();
            MyModificar_Stock_Producto.ShowDialog();
        }
        #endregion
    }
}
