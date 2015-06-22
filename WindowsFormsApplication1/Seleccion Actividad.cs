using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Seleccion_Actividad : Form
    {
        public Seleccion_Actividad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas vis = new Ventas();
            vis.ShowDialog();
        }

       

        private void btnseleccionarbalances_Click(object sender, EventArgs e)
        {
            Balances vis = new Balances();
            vis.ShowDialog();
        }

        private void btnseleccionarstock_Click(object sender, EventArgs e)
        {
            Stock vis = new Stock();
            vis.ShowDialog();
        }

        private void btnseleccionarproductosalaventa_Click(object sender, EventArgs e)
        {
            Producto_a_la_venta vis = new Producto_a_la_venta();
            vis.ShowDialog();
        }
        }
    }

