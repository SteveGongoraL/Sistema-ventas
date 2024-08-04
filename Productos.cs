using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_ventas
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void linkLblCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void linkLblMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            // Validar campos
            if(txtNombreProducto.Text == string.Empty || txtPrecioProducto.Text == string.Empty)
            {
                MessageBox.Show("Es necesario llenar ambos campos");
            }
            else
            {
                // Guardar productos

                // Limpiar campos
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
        }
    }
}
