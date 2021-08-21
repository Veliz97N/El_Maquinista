using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Maquinista.Formularios
{
    public partial class ProductosCategoria : Form
    {
        //ERROR EN EL PRODUCTO, NO SE BORRA LA WEA
        //MAÑANA ARREGLAR ESTO

        public ProductosCategoria()
        {
            InitializeComponent();
            CargarTipodeProductos_ComboBOX();              
            Inicializar_DataGrid();            
            cb_Categorias.SelectedIndex = 0;
        }
        #region Inicializando Componentes
        private void Inicializar_DataGrid()
        {
            dgProductosEncontrados.RowHeadersVisible = false;
            dgProductosEncontrados.AllowUserToAddRows = false;
            
            dgProductosEncontrados.ReadOnly = true;
            //dgProductosEncontrados.Columns.Add("NVenta", "Nº de Venta"); //Se crea columna de numero de venta [0]
            dgProductosEncontrados.Columns.Add("CodigoBarra", "Código de Barras"); //Se crea columna de código de barras [1]
            dgProductosEncontrados.Columns[0].Visible = false;
            dgProductosEncontrados.Columns.Add("Producto", "Producto"); //Se crea columna de ítem [2]
                                                                       //dgProductosEncontrados.Columns.Add("Local", "Local"); //Se crea columna de local [3]
                                                                       //dgProductosEncontrados.Columns.Add("Cantidad", "Cantidad"); //Se crea columna de cantidad  [4]
            dgProductosEncontrados.Columns.Add("PrecioSolo", "Precio"); //Se crea columna de precio solo [5]
                                                                       //dgProductosEncontrados.Columns.Add("Precio", "Precio");//Se crea columna de precio [6]
            dgProductosEncontrados.Columns.Add("APromo", "Aplica Promoción"); //Se crea columna de precio [7]
            dgProductosEncontrados.Columns.Add("PrecioPromo", "Precio Promoción"); //Se crea columna de precio [8]
        }
        private void CargarProductos_Categoria(string Categoria)
        {
            dgProductosEncontrados.Rows.Clear();
            //Cargar Productos Segun Categoria
            BasedeDatos MyBaseDatos = new BasedeDatos();
            
            List<string>ListaProductos_Categoria=MyBaseDatos.Buscar_ProductoCategoria(Categoria);
            if (ListaProductos_Categoria.Count >= 1)
            {

                for (int x = 0; x < ListaProductos_Categoria.Count; x++)
                {
                    dgProductosEncontrados.Rows.Add();
                    //Producto =         0        1         2           3              4   
                    //Producto = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion
                    dgProductosEncontrados.Rows[x].Cells[0].Value = ListaProductos_Categoria[x].Split(';')[0]; //Columna Codigo de Barras se anota el codigo de barras
                    dgProductosEncontrados.Rows[x].Cells[1].Value = ListaProductos_Categoria[x].Split(';')[1]; //Columna Producto se anota el Nombre del Producto
                    dgProductosEncontrados.Rows[x].Cells[2].Value = ListaProductos_Categoria[x].Split(';')[2]; //Columna PrecioSolo se anota el Precio del Producto Individual
                    dgProductosEncontrados.Rows[x].Cells[3].Value = ListaProductos_Categoria[x].Split(';')[3]; //Columna APromo se anota si aplica promocion
                    dgProductosEncontrados.Rows[x].Cells[4].Value = ListaProductos_Categoria[x].Split(';')[4]; //Columna PrecioPromo se anota el Precio de la promocion
                }
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias. Revise el nombre del producto escrito");
            }            
        }
        private void CargarTipodeProductos_ComboBOX()
        {
            BasedeDatos MyBaseDatos = new BasedeDatos();
            List<string> ListaTipoProducto = MyBaseDatos.TipodeProductos();
            foreach (string Tipo_Producto in ListaTipoProducto)
            {
                cb_Categorias.Items.Add(Tipo_Producto);
            }
        }
        private void cb_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Categoria = Convert.ToString(cb_Categorias.SelectedItem);
            CargarProductos_Categoria(Categoria);

        }
        #endregion


        #region Obtencion Producto y Cálculo de Costos
        int posicionProductoSeleccionado;
        string ProductoSeleccionado = string.Empty;
        private void dgProductosEncontrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicionProductoSeleccionado = e.RowIndex;
            //ProductoSeleccionado =         0        1         2           3              4            5 
            //ProductoSeleccionado = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion;Cantidad
            ProductoSeleccionado = dgProductosEncontrados.Rows[posicionProductoSeleccionado].Cells[0].Value + ";" + dgProductosEncontrados.Rows[posicionProductoSeleccionado].Cells[1].Value + ";" + dgProductosEncontrados.Rows[posicionProductoSeleccionado].Cells[2].Value
            + ";" + dgProductosEncontrados.Rows[posicionProductoSeleccionado].Cells[3].Value + ";" + dgProductosEncontrados.Rows[posicionProductoSeleccionado].Cells[4].Value;
            txbCantidad.Text = "1";
            txbPrecio.Text = ProductoSeleccionado.Split(';')[2];
            if (ProductoSeleccionado != string.Empty)
                IconBtn_AgregarProducto.Enabled = true;
        }
        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            bool CantidadNumerico = int.TryParse(txbCantidad.Text, out int cantidad);
            if (txbCantidad.Text != "" && CantidadNumerico)
            {
                EP_BusquedaCategoria.Clear();
                if (ProductoSeleccionado.Split(';')[3] == "Si" && cantidad % 2 == 0)
                {
                    int cantidadPar = (cantidad / 2);
                    txbPrecio.Text = "$" + Convert.ToString(cantidadPar * Convert.ToInt32(ProductoSeleccionado.Split(';')[4].Replace("$", "").Replace(".", "")));
                }
                else if (ProductoSeleccionado.Split(';')[3] == "Si" && cantidad % 2 == 1)
                {
                    int cantidadPar = (cantidad / 2);
                    int restoCantidad = (cantidad % 2);
                    txbPrecio.Text = "$" + Convert.ToString(cantidadPar * Convert.ToInt32(ProductoSeleccionado.Split(';')[4].Replace("$", "").Replace(".", "")) + restoCantidad * Convert.ToInt32(ProductoSeleccionado.Split(';')[2]));
                }
                else
                {
                    txbPrecio.Text = "$" + Convert.ToString(cantidad * Convert.ToInt32(ProductoSeleccionado.Split(';')[2]));
                }
            }
            else
            {
                EP_BusquedaCategoria.SetError(txbCantidad, "El valor de cantidad ingresado no es válido");
                txbPrecio.Text = "Ingrese un valor númerico en cantidad";
            }
        }
        #endregion


        #region Producto a Boleta
        private void IconBtn_AgregarProducto_Click(object sender, EventArgs e)
        {
            ClaseVentaInmediata MyClaseVentaInmediata = new ClaseVentaInmediata();

            Principal MyPrincipal = Owner as Principal;
            if (ProductoSeleccionado != string.Empty && Convert.ToInt32(txbCantidad.Text) > 0)
            {
                MyClaseVentaInmediata.AddProducto_Boleta(MyPrincipal.dgBoleta, ProductoSeleccionado, MyClaseVentaInmediata.FindProduct_Boleta(MyPrincipal.dgBoleta, ProductoSeleccionado), txbCantidad.Text);
                MyClaseVentaInmediata.CreateList_Promocion(MyPrincipal.dgBoleta);
                MyClaseVentaInmediata.ClasificarPromociones(MyClaseVentaInmediata.CreateList_Promocion(MyPrincipal.dgBoleta)[0]);//MyClaseVentaInmediata.CreateList_Promocion(dgBoleta,Producto)[0]);                
                MyPrincipal.lbTotalVenta.Text = "$ " + Convert.ToString(MyClaseVentaInmediata.CalcularMontoVenta(MyClaseVentaInmediata.CreateList_Promocion(MyPrincipal.dgBoleta)[1]));
                MyPrincipal.IconBtn_ConfirmarVenta.Visible = true; //Hago visible el boton de vender
                MyPrincipal.lbTotalVenta.Visible = true; //Hago visible el boton de total venta
                MyPrincipal.lbVenta.Visible = true; //Hago visible el boton de venta
                MyPrincipal.tbCodigoBarras.Text = string.Empty; //Establezco en vacio el boton codigo de barras. Esto se hace para agregar otro producto
            }
            ProductoSeleccionado = string.Empty;
            IconBtn_AgregarProducto.Enabled = false;
            IconBtn_RemoverProducto.Enabled = false;
            txbCantidad.Text = string.Empty;
            txbPrecio.Text = string.Empty;
            EP_BusquedaCategoria.Clear();
            //dgProductosEncontrados.Rows[posicionProductoSeleccionado].DefaultCellStyle.BackColor = Color.White;
        }

        private void IconBtn_RemoverProducto_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
