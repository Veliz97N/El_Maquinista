using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Maquinista.Formularios_Catalogo
{
    public partial class AgrearNuevoProducto : Form
    {
        public AgrearNuevoProducto()
        {
            InitializeComponent();
            rbNo.Checked = true;
            lbValorPromocion.Visible = false;
            tbValorPromocion.Visible = false;
            lbStock.Visible = false;
            tbStock.Visible = false;

        }
        private void Promocion(RadioButton AplicaPromocion)
        {
            if (AplicaPromocion.Checked == false)
            {
                lbValorPromocion.Visible = false;
                tbValorPromocion.Visible = false;
                lbStock.Visible = false;
                tbStock.Visible = false;
            }
            else if (AplicaPromocion.Checked == true)
            {
                lbValorPromocion.Visible = true;
                tbValorPromocion.Visible = true;
                lbStock.Visible =          true; 
                tbStock.Visible = true; 
            }
            
        }

        private void rbSi_CheckedChanged(object sender, EventArgs e)
        {
            Promocion(rbSi);
            
        }

    }
}
