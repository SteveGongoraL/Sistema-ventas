using Newtonsoft.Json;

namespace Sistema_ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Validar los campos
            if(txtUsuario.Text == string.Empty || txtContrasena.Text == string.Empty)
            {
                MessageBox.Show("Es necesario llenar ambos campos");
            }
            else
            {
                // Creando el archivo JSON
                List<Usuario> _data = new List<Usuario>();
                _data.Add(new Usuario()
                {
                    usuario = txtUsuario.Text,
                    contrasena = txtContrasena.Text,
                });
                string json = JsonConvert.SerializeObject(_data.ToArray());

                // Escribiendo el archivo Json
                System.IO.File.AppendAllText(@"..\..\assets\docs\01_RegistroSesion.json", json);

                // Mensaje de inicio de sesión
                MessageBox.Show("Inicio de sesión exitoso");

                // Cambiar a nueva ventana
                if (txtUsuario.Text == "ADMI")
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    Compras compras = new Compras();
                    compras.Show();
                    this.Hide();
                }
            }
        }
        public class Usuario
        {
            public required string usuario { get; set; }
            public required string contrasena { get; set; }
        }
    }
}
