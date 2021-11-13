using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Registro
    {
        private CD_Registro objetoCDRegistro = new CD_Registro();
        private int verificaMatricula;

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
        public DataTable MostrarRegistro()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCDRegistro.MostrarRegistro();
            return tabla;

        }


        public void InsertarRegistroEntrada()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCDRegistro.BuscarMatricula(Matricula);
            verificaMatricula = tabla.Rows.Count;


            objetoCDRegistro._Matricula = Matricula;
            objetoCDRegistro._ID_Tipo = ID_Tipo;
            objetoCDRegistro._FechaEntrada= FechaEntrada;
            objetoCDRegistro._FechaSalida = DateTime.Today;

            //CPtoCD();

            if (verificaMatricula == 1)
            {
                objetoCDRegistro._ID_Vehiculo = Convert.ToInt32(tabla.Rows[0]["Id_vehiculo"]);
                objetoCDRegistro.InsertarRegistroEntrada();
            }
            else if (verificaMatricula == 0)
            {
                objetoCDRegistro.InsertarMatricula();
                InsertarRegistroEntrada();

            }

        }
        public void InsertarRegistroSalida()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCDRegistro.RegistroCompleto();


            String condicion = "idRegistro=" + ID_Registro; //CORREGIR ESTO. INDEX?
            DataRow[] PrecioVar = tabla.Select(condicion);
            Precio = Convert.ToDouble( PrecioVar[0]["Precio"]);


            //Precio = Convert.ToDouble(tabla.Rows[ID_Registro]["Precio"]);
            FechaEntrada = Convert.ToDateTime(tabla.Rows[ID_Registro]["entrada"]);


            TimeSpan TiempoCalculado = FechaSalida - FechaEntrada;
            Duracion = Convert.ToInt32( TiempoCalculado.TotalMinutes);
            Coste = Duracion * Precio;

            objetoCDRegistro._ID_Registro = ID_Registro;
            objetoCDRegistro._FechaSalida = FechaSalida;
            objetoCDRegistro._Duracion = Duracion;
            objetoCDRegistro._Coste= Coste;

            objetoCDRegistro.InsertarRegistroSalida();
        }
        

        public void EliminarRegistro()
        {
            objetoCDRegistro._ID_Registro = ID_Registro;
            objetoCDRegistro.EliminarRegistro();
        }

        private void CPtoCD()
        {
            objetoCDRegistro._ID_Registro = ID_Registro;
            objetoCDRegistro._FechaEntrada = FechaEntrada;
            objetoCDRegistro._FechaSalida = FechaSalida;
            objetoCDRegistro._Duracion = Duracion;

            objetoCDRegistro._ID_Vehiculo = ID_Vehiculo;
            objetoCDRegistro._Matricula = Matricula;

            objetoCDRegistro._ID_Tipo = ID_Tipo;
            objetoCDRegistro._Tipo = Tipo;
            objetoCDRegistro._Coste = Coste;

        }



    



        //TABLA TIPO
        public DataTable ListarTipos()
        {
            //CD_Tipo objetoTipo = new CD_Tipo();
            DataTable tabla = new DataTable();
            tabla = objetoCDRegistro.ListarTipos();
            return tabla;
        }

        



    }
}
