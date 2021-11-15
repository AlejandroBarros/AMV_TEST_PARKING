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
using CapaSoporte.Cache;

namespace CapaPresentacion
{
    public partial class CP_Registro : Form
    {
        CN_Registro objetoCNRegistro = new CN_Registro();
        public CP_Registro()
        {
            InitializeComponent();
        }

        private void CP_Registro_Load(object sender, EventArgs e)
        {
            LoadUserData();
            MostrarRegistros();
            Listartipos();
        }
        private void MostrarRegistros()
        {
            CN_Registro objetoCNRegistro = new CN_Registro();
            dataGridView1.DataSource = objetoCNRegistro.MostrarRegistro();

        }

        private void Listartipos()
        {
            cmbTipos.DataSource = objetoCNRegistro.ListarTipos();
            cmbTipos.DisplayMember = "Tipo_vehiculo";
            cmbTipos.ValueMember = "Id_Tipo";
        }

        private void btEntrada_Click(object sender, EventArgs e)
        {
            objetoCNRegistro._Matricula = txtMatricula.Text;
            objetoCNRegistro._ID_Tipo = Convert.ToInt32(cmbTipos.SelectedValue);


            DateTime timein = dtHoraEntrada.Value;
            DateTime timeout = dtHoraSalida.Value;
            //DateTime timein = DateTime.Parse(dtHoraEntrada.Value);
            //DateTime timeout = DateTime.Parse(dtHoraSalida.Text);
            objetoCNRegistro._FechaEntrada = timein;

            objetoCNRegistro.InsertarRegistroEntrada();
            MostrarRegistros();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Operacion = "Editar";
                //CmbCategoria.Text = dataGridView1.CurrentRow.Cells["CATEGORIA"].Value.ToString();
                //CmbMarca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //txtDescripcion.Text = dataGridView1.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                //txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //idprod = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
                MessageBox.Show("debe seleccionar una fila");
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objetoCNRegistro._ID_Registro = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                objetoCNRegistro.EliminarRegistro();
                MessageBox.Show("Se elimino satisfactoriamente");
                MostrarRegistros();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btSalida_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)

            {
                if (dataGridView1[4,dataGridView1.CurrentCell.RowIndex ].Value.ToString() == "")
                {
                    objetoCNRegistro._ID_Registro = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);


                    DateTime timeout = dtHoraSalida.Value;
                    objetoCNRegistro._FechaSalida = timeout;

                    objetoCNRegistro.InsertarRegistroSalida();
                    MessageBox.Show("Se actualizado satisfactoriamente");
                    MostrarRegistros();
                }
                else
                    MessageBox.Show("Seleccione una fila valida");

            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        
        private void LoadUserData()
        {
            lblUsername.Text = CacheUsuario.Usuario;
            lblPosition.Text = CacheUsuario.Posicion;
            lblEmail.Text = CacheUsuario.Email;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de cerrar sesion?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Login MenuLogin = new Login();
                MenuLogin.Show();
                this.Close();
            }

               
         
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            lblCountRegistros.Visible = true;
            lblOcupMinutos.Visible = true;
            lblIngresos.Visible = true;

            objetoCNRegistro.FuncionesEspeciales();
            lblCountRegistros.Text ="Maximos Registros: \n"+ objetoCNRegistro._RegistrosTotales.ToString()+ "\n [" + objetoCNRegistro._DiaRT.Date + "]";
            lblOcupMinutos.Text = "Maxima Duracion. \n" + objetoCNRegistro._DuracionTotal.ToString() + "\n [" + objetoCNRegistro._DiaDT.Date + "]";
            lblIngresos.Text = "Maximas Ganancias:\n" + objetoCNRegistro._GananciasTotales.ToString() + "\n [" + objetoCNRegistro._DiaGT.Date + "]";
        }
    }
}
