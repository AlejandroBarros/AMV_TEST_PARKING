using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Registro
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlCommand comando = new SqlCommand();
        private DataTable tabla = new DataTable();
        private SqlDataReader Leerfilas;

        ///ATRIBUTOS
        private int ID_Registro;
        private DateTime FechaEntrada;
        private DateTime FechaSalida;
        private int Duracion;

        private int ID_Vehiculo;
        private String Matricula;
        private double Coste;

        private int ID_Tipo;
        private string Tipo;
        private double Precio;

        //METODO GET SET
        public int _ID_Registro { get => ID_Registro; set => ID_Registro = value; }
        public DateTime _FechaEntrada { get => FechaEntrada; set => FechaEntrada = value; }
        public DateTime _FechaSalida { get => FechaSalida; set => FechaSalida = value; }
        public int _Duracion { get => Duracion; set => Duracion = value; }
        public double _Coste { get => Coste; set => Coste = value; }



        public int _ID_Vehiculo { get => ID_Vehiculo; set => ID_Vehiculo = value; }
        public string _Matricula { get => Matricula; set => Matricula = value; }



        public int _ID_Tipo { get => ID_Tipo; set => ID_Tipo = value; }
        public string _Tipo { get => Tipo; set => Tipo = value; }
        public double _Precio { get => Precio; set => Precio = value; }




        //METODOS/FUNCIONES

        //TABLA REGISTRO
        public DataTable MostrarRegistro()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarUsuario"; 
            comando.CommandType = CommandType.StoredProcedure;
            Leerfilas = comando.ExecuteReader();
            tabla.Load(Leerfilas);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable RegistroCompleto()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RegistroCompleto";
            comando.CommandType = CommandType.StoredProcedure;
            Leerfilas = comando.ExecuteReader();
            tabla.Load(Leerfilas);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarRegistroEntrada()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarRegistroEntrada";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_vehiculo", ID_Vehiculo);
            comando.Parameters.AddWithValue("@fechaEntrada", FechaEntrada);
            comando.Parameters.AddWithValue("@fechaSalida", FechaSalida);
            comando.Parameters.AddWithValue("@duracion", Duracion);
            comando.Parameters.AddWithValue("@coste", Coste);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void InsertarMatricula()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarMatricula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@matricula", Matricula);
            comando.Parameters.AddWithValue("@idTipo", ID_Tipo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void InsertarRegistroSalida()
        {
            //TRANSACT SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarRegistroSalida";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_registro", ID_Registro);
            comando.Parameters.AddWithValue("@fechaSalida", FechaSalida);
            comando.Parameters.AddWithValue("@Duracion", Duracion);
            comando.Parameters.AddWithValue("@Coste", Coste);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EditarRegistro()
        {
            //TRANSACT SQL
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarMatricula";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_vehiculo", ID_Vehiculo);
            comando.Parameters.AddWithValue("@matricula", Matricula);
            comando.Parameters.AddWithValue("@ID_Tipo", ID_Tipo);
            comando.ExecuteNonQuery();

            comando.CommandText = "EditarRegistro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_registro", ID_Registro);
            comando.Parameters.AddWithValue("@fechaEntrada", FechaEntrada);
            comando.Parameters.AddWithValue("@fechaSalida", FechaSalida);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


        public void EliminarRegistro()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete Registro where idRegistro=" + ID_Registro;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }


        //TABLA VEHICULO
        public DataTable ListarVehiculos()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM Vehiculo";
            comando.CommandType = CommandType.Text;
            Leerfilas = comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable BuscarMatricula(string Matricula)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM Vehiculo WHERE matricula='" + Matricula+"'";
            comando.CommandType = CommandType.Text;
            Leerfilas = comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }

        public void InsertarVehiculo()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into vehiculo values (@matricula,@ID_Tipo)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@Id_vehiculo", ID_Vehiculo);
            comando.Parameters.AddWithValue("@matricula", Matricula);
            comando.Parameters.AddWithValue("@ID_Tipo", ID_Tipo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        //TABLA TIPO
        public DataTable ListarTipos()
        {
            DataTable Tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM Tipo";
            comando.CommandType = CommandType.Text;
            Leerfilas = comando.ExecuteReader();
            Tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return Tabla;
        }
    }
}