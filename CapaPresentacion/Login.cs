using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtContraseña.GotFocus += new EventHandler(this.txtContraseña_Enter);
            txtContraseña.LostFocus += new EventHandler(this.txtContraseña_Leave);
            txtUsuario.GotFocus += new EventHandler(this.txtUsuario_Enter);
            txtUsuario.LostFocus += new EventHandler(this.txtUsuario_Leave);

        }
        private void InicioSesion()
        {
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    UserModel usuario = new UserModel();
                    var validLogin = usuario.LoginUser(txtUsuario.Text, txtContraseña.Text);

                    if (validLogin == true)
                    {
                        CP_Registro mainMenu = new CP_Registro();
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrecto");
                        txtContraseña.Clear();
                        txtContraseña.Focus();
                    }
                }
                else msgError("Por favor, introduzca contrasela");
            }
            else msgError("Por favor, introduzca usuario");

        }
        

        private void msgError(string msg)
        {
            lbError.Text = msg;
            lbError.Visible = true;
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.PasswordChar = '*';
            }

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.PasswordChar = '\0'; ;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                InicioSesion();
            }
 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesion();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
