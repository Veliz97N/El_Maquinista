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
    public partial class Busqueda_Nombre : Form
    {
        public Busqueda_Nombre()
        {
            InitializeComponent();
            CondicionInicial();
            CondicionInicial_Datagrid();
        }
        Label text;
        DataGridView dg_Boleta = new DataGridView();
        public Busqueda_Nombre(Label texto)
        {
            InitializeComponent();
            CondicionInicial();
            CondicionInicial_Datagrid();
            text = texto;
        }
        #region Inicialización Componentes
        private void CondicionInicial()
        {
            dgProductosEncontrados.Visible = false;
            IconBtn_AgregarProducto.Visible = false;
            IconBtn_RemoverProducto.Visible = false;            
            txbCantidad.Visible = false;
            txbPrecio.Visible = false;
            pbProducto.Visible = false;
            lblCantidad.Visible = false;
            lblPrecio.Visible = false;
        }
        private void CondicionInicial_Datagrid()
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
        private void Condicion_ProductoEncontrado()
        {
            dgProductosEncontrados.Visible =  true;
            IconBtn_AgregarProducto.Visible = true;
            IconBtn_RemoverProducto.Visible = true;
            txbCantidad.Visible =             true;
            txbPrecio.Visible =               true;
            pbProducto.Visible =              true;
            lblCantidad.Visible =             true;
            lblPrecio.Visible = true; //false;
        }
        #endregion

        #region Buscar Producto
        private void IconButton_BuscarProducto_Click(object sender, EventArgs e)
        {
            dgProductosEncontrados.Rows.Clear();
            BasedeDatos MyBaseDatos = new BasedeDatos();
            string productoABuscar = txbBuscarProducto.Text;
            List<string>ListadoProductos=MyBaseDatos.Buscar_ProductoNombre(productoABuscar);
            if (ListadoProductos.Count >= 1)
            {
                Condicion_ProductoEncontrado();

                for (int x = 0; x < ListadoProductos.Count; x++)
                {
                    dgProductosEncontrados.Rows.Add();
                    //Producto =         0        1         2           3              4   
                    //Producto = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion
                    dgProductosEncontrados.Rows[x].Cells[0].Value = ListadoProductos[x].Split(';')[0]; //Columna Codigo de Barras se anota el codigo de barras
                    dgProductosEncontrados.Rows[x].Cells[1].Value = ListadoProductos[x].Split(';')[1]; //Columna Producto se anota el Nombre del Producto
                    dgProductosEncontrados.Rows[x].Cells[2].Value = ListadoProductos[x].Split(';')[2]; //Columna PrecioSolo se anota el Precio del Producto Individual
                    dgProductosEncontrados.Rows[x].Cells[3].Value = ListadoProductos[x].Split(';')[3]; //Columna APromo se anota si aplica promocion
                    dgProductosEncontrados.Rows[x].Cells[4].Value = ListadoProductos[x].Split(';')[4]; //Columna PrecioPromo se anota el Precio de la promocion
                }
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias. Revise el nombre del producto escrito");
            }
        }

        private void IconButton_Limpiar_Click(object sender, EventArgs e)
        {
            txbBuscarProducto.Text = string.Empty;
            dgProductosEncontrados.Rows.Clear();
            CondicionInicial();
        }
        #endregion

        #region Obtencion Producto y Cálculo de Costos

        int posicionProductoSeleccionado;
        string ProductoSeleccionado=string.Empty;
        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            bool CantidadNumerico = int.TryParse(txbCantidad.Text, out int cantidad);
            if (txbCantidad.Text != "" && CantidadNumerico)
            {
                EP_BusquedaNombre.Clear();
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
                EP_BusquedaNombre.SetError(txbCantidad, "El valor de cantidad ingresado no es válido");
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
            EP_BusquedaNombre.Clear();
            dgProductosEncontrados.Rows[posicionProductoSeleccionado].DefaultCellStyle.BackColor = Color.White;
        }
        #endregion

        private void dgProductosEncontrados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int x = 0; x < dgProductosEncontrados.Rows.Count; x++)
            {
                dgProductosEncontrados.Rows[x].DefaultCellStyle.BackColor = Color.Empty;
            }
            posicionProductoSeleccionado = e.RowIndex;
            //ProductoSeleccionado =         0        1         2           3              4            5 
            //ProductoSeleccionado = CodigodeBarras;Becker;PrecioSola;AplicaPromocion;ValorPromocion;Cantidad
            ProductoSeleccionado = dgProductosEncontrados.Rows[posicionProductoSeleccionado].Cells[0].Value + ";" + dgProductosEncontrados.Rows[posicionProductoSeleccionado].Cells[1].Value + ";" + dgProductosEncontrados.Rows[posicionProductoSeleccionado].Cells[2].Value
            + ";" + dgProductosEncontrados.Rows[posicionProductoSeleccionado].Cells[3].Value + ";" + dgProductosEncontrados.Rows[posicionProductoSeleccionado].Cells[4].Value;

            dgProductosEncontrados.Rows[posicionProductoSeleccionado].DefaultCellStyle.BackColor = Color.Blue;
            txbCantidad.Text = "1";
            txbPrecio.Text = ProductoSeleccionado.Split(';')[2];
            if (ProductoSeleccionado != string.Empty)
                IconBtn_AgregarProducto.Enabled = true;
        }
    }
}
