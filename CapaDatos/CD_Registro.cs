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
        
        CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();
        SqlDataReader Leerfilas;

        //ATRIBUTOS
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

        private double GananciasTotales;
        private DateTime DiaGT;
        private int DuracionTotal;
        private DateTime DiaDT;
        private int RegistrosTotales;
        private DateTime DiaRT;
        private DateTime diaSeleccionado;



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


        public double _GananciasTotales { get => GananciasTotales; set => GananciasTotales = value; }
        public DateTime _DiaGT { get => DiaGT; set => DiaGT = value; }
        public int _DuracionTotal { get => DuracionTotal; set => DuracionTotal = value; }
        public DateTime _DiaDT { get => DiaDT; set => DiaDT = value; }
        public int _RegistrosTotales { get => RegistrosTotales; set => RegistrosTotales = value; }
        public DateTime _DiaRT { get => DiaRT; set => DiaRT = value; }
        public DateTime _diaSeleccionado { get => diaSeleccionado; set => diaSeleccionado = value; }




        //METODOS/FUNCIONES

        public DataTable MostrarRegistro()
        {
            DataTable tablaMR = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarUsuario"; 
            comando.CommandType = CommandType.StoredProcedure;
            Leerfilas = comando.ExecuteReader();
            tablaMR.Load(Leerfilas);
            conexion.CerrarConexion();
            return tablaMR;
        }

        public DataTable RegistroCompleto()
        {
            DataTable tablaRC = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RegistroCompleto";
            comando.CommandType = CommandType.StoredProcedure;
            Leerfilas = comando.ExecuteReader();
            tablaRC.Load(Leerfilas);
            conexion.CerrarConexion();
            return tablaRC;
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
            conexion.CerrarConexion();
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
            conexion.CerrarConexion();
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
            conexion.CerrarConexion();
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
            conexion.CerrarConexion();
        }


        public void EliminarRegistro()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete Registro where idRegistro=" + ID_Registro;
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public DataTable ListarVehiculos()
        {
            DataTable tablaLV = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM Vehiculo";
            comando.CommandType = CommandType.Text;
            Leerfilas = comando.ExecuteReader();
            tabla.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable BuscarMatricula(string Matricula)
        {
            DataTable tablaBM = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM Vehiculo WHERE matricula='" + Matricula+"'";
            comando.CommandType = CommandType.Text;
            Leerfilas = comando.ExecuteReader();
            tablaBM.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return tablaBM;
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

        public DataTable ListarTipos()
        {
            DataTable tablaLT = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT*FROM Tipo";
            comando.CommandType = CommandType.Text;
            Leerfilas = comando.ExecuteReader();
            tablaLT.Load(Leerfilas);
            Leerfilas.Close();
            conexion.CerrarConexion();
            return tablaLT;
        }


        //FUNCIONES ESPECIALES  
        //RegistroFecha
        public DataTable FuncionesEspeciales()
        {
            DataTable tablaFE = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RegistroFecha";
            comando.CommandType = CommandType.StoredProcedure;
            Leerfilas = comando.ExecuteReader();
            tablaFE.Load(Leerfilas);
            conexion.CerrarConexion();
            return tablaFE;
        }
        //DatosxDia

        public DataTable RegistroxDia()
        {
            DataTable tablaRD = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DatosxDia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@diaSeleccionado", diaSeleccionado.Date);
            Leerfilas = comando.ExecuteReader();
            comando.Parameters.Clear();
            tablaRD.Load(Leerfilas);
            conexion.CerrarConexion();
            return tablaRD;
        }
        public DataTable DiasRegistrados()
        {
            DataTable tablaDR = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "DiasRegistrados";
            comando.CommandType = CommandType.StoredProcedure;
            Leerfilas = comando.ExecuteReader();
            tablaDR.Load(Leerfilas);
            conexion.CerrarConexion();
            return tablaDR;
        }
    }
}