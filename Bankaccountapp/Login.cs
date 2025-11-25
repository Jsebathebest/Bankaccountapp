

using System;
using System.Windows.Forms;

namespace Bankaccountapp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtener el usuario y contraseña de los TextBox
            string username = User.Text;
            string passwordd = password.Text;

            // Validación de prueba (usuario y contraseña hardcodeados)
            if (username == "admin" && passwordd == "1234")
            {
                MessageBox.Show("Bienvenido!", "Login exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el siguiente formulario (MainForm) y ocultar Login
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Clear(); // Limpiar el password
                User.Focus(); // Volver a enfocar el usuario
            }
        }
    }
}
