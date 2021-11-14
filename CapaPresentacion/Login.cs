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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "") {
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
    }
}
