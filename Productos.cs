using System;
using System.Configuration;
using System.Windows.Forms;

namespace Sistema_ventas
{
    public partial class Productos : Form
    {
        private DataAccess dataAccess;
        public Productos()
        {
            InitializeComponent();
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            dataAccess = new DataAccess(conexion);
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

        // Validar que solo acepte numeros
        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (txtNombreProducto.Text == string.Empty || txtPrecioProducto.Text == string.Empty)
            {
                MessageBox.Show("Es necesario llenar ambos campos");
            }
            else
            {
                // Guardar productos
                string nombreProducto = txtNombreProducto.Text;
                int precioProducto = Convert.ToInt32(txtPrecioProducto.Text);

                try
                {
                    dataAccess.InsertProducto(nombreProducto, precioProducto);
                    MessageBox.Show("Se ha guardado el producto");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

                // Limpiar campos
                foreach (Control txtItem in this.Controls)
                {
                    if (txtItem is TextBox)
                    {
                        txtItem.Text = "";
                    }
                }
            }
        }
    }
}
