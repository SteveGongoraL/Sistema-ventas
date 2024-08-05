using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_ventas
{
    public partial class Compras : Form
    {
        private DataAccess dataAccessConsultas;
        int suma = 0;

        public Compras(string usuario)
        {
            InitializeComponent();
            string conexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            dataAccessConsultas = new DataAccess(conexion);
            CargarDatosComboBox();
            ValidarUsuario(usuario);
        }

        // LLenar la lista de productos disponibles
        private void CargarDatosComboBox()
        {
            try
            {
                DataTable dataTable = dataAccessConsultas.GetData();
                cbxProducto.DataSource = dataTable;
                cbxProducto.DisplayMember = "nombre_producto";
                cbxProducto.ValueMember = "id_producto";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Validar si el usuario que inicio sesion es ADMI o no
        private void ValidarUsuario(string usuarioValidar)
        {
            if(usuarioValidar != "ADMI")
            {
                // Si el usuario no es ADMI no puede agregar productos
                linkLabel2.Visible = false;
            }
        }

        // Validar que solo admita numeros en el cuadro de "Cantidad"
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Limpiar el precio y la cantidad al cambiar de producto
        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotalProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        // Navegación
        // Regresar al login despues de cerrar sesión
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        // Regresar al menu
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        // Funcionalidad de botones
        // Ver el precio
        private void btnVerPrecio_Click(object sender, EventArgs e)
        {
            // Declarar variables
            int precioProducto, cantidadProducto, totalProducto;

            if (cbxProducto.SelectedItem is DataRowView rowView)
            {
                // Precio
                precioProducto = (int)rowView["precio_producto"];

                // Cantidad
                if (txtCantidad.Text == string.Empty)
                {
                    cantidadProducto = 1;
                }
                else
                {
                    cantidadProducto = Convert.ToInt32(txtCantidad.Text);
                }

                // Total
                totalProducto = precioProducto * cantidadProducto;

                // Poner el precio
                lblTotalProducto.Text = Convert.ToString(totalProducto);
            }
        }
        // Agregar el producto
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Declarar variables
            string productoSeleccionado, precioProductoStr, cantidadProducto, totalProductoStr;
            int precioProducto, totalProducto;

            if (cbxProducto.SelectedItem is DataRowView rowView)
            {
                // Producto
                productoSeleccionado = (string)rowView["nombre_producto"];

                // Precio
                precioProducto = (int)rowView["precio_producto"];
                precioProductoStr = Convert.ToString(precioProducto);

                // Cantidad
                if (txtCantidad.Text == string.Empty)
                {
                    cantidadProducto = "1";
                }
                else
                {
                    cantidadProducto = Convert.ToString(txtCantidad.Text);
                }

                // Total
                totalProducto = precioProducto * Convert.ToInt32(cantidadProducto);
                totalProductoStr = Convert.ToString(totalProducto);

                // Llenar la tabla
                dgProductos.Rows.Add(productoSeleccionado, precioProductoStr, cantidadProducto, totalProductoStr);

                // Limpiar
                txtCantidad.Text = string.Empty;
                lblTotalProducto.Text = string.Empty;
            }
        }
        // Pagar el producto
        private void btnPagar_Click(object sender, EventArgs e)
        {
            // Sacar el total de la compra
            for(int i = 0; i < dgProductos.RowCount - 1; i++)
            {
                suma += int.Parse(dgProductos.Rows[i].Cells[3].Value.ToString());
            }
            if(suma != 0)
            {
                MessageBox.Show($"El total de su compra es: ${suma}");

                // Guardar el total de la compra en un JSON
                List<Subtotal> _data = new List<Subtotal>();
                _data.Add(new Subtotal()
                {
                    subtotal = Convert.ToString(suma),
                });
                string json = JsonConvert.SerializeObject(_data.ToArray());

                //Escribiendo el archivo Json
                System.IO.File.AppendAllText(@"..\..\..\assets\docs\RegistroCompras.json", json);

                // Limpiando la pagina
                txtCantidad.Text = string.Empty;
                lblTotalProducto.Text = string.Empty;
                dgProductos.Rows.Clear();
                suma = 0;
            }
            else
            {
                MessageBox.Show("Debes agregar productos para poder pagar");
            }
        }

        public class Subtotal
        {
            public required string subtotal { get; set; }
        }
    }
}
