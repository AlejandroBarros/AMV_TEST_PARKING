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
            tabla.PrimaryKey = new DataColumn[] { tabla.Columns["idregistro"] };


            DataRow FilaSelecionada = tabla.Rows.Find(ID_Registro);

            Precio = Convert.ToDouble(FilaSelecionada["Precio"]);
            FechaEntrada = Convert.ToDateTime(FilaSelecionada["entrada"]);


            //Precio = Convert.ToDouble(tabla.Rows[ID_Registro]["Precio"]);
            //FechaEntrada = Convert.ToDateTime(tabla.Rows[ID_Registro]["entrada"]);


            TimeSpan TiempoCalculado = FechaSalida - FechaEntrada;
            Duracion = Convert.ToInt32( TiempoCalculado.TotalMinutes);
            Coste = Duracion * Precio;

            objetoCDRegistro._ID_Registro = ID_Registro;
            objetoCDRegistro._FechaSalida = FechaSalida;
            objetoCDRegistro._Duracion = Duracion;
            objetoCDRegistro._Coste= Coste;
            if(Duracion >= 0) { objetoCDRegistro.InsertarRegistroSalida(); }
            
            
        }

        public void FuncionesEspeciales()
        {

            DataTable Tabla = new DataTable();
            Tabla = objetoCDRegistro.DiasRegistrados();
            //DataColumn tablaDias = new DataColumn[] { Tabla.Columns["idregistro"]

            for (int i = 0; i < Tabla.Rows.Count; i++)
            {
                if (Convert.ToString(Tabla.Rows[i]["diaSalidas"]) != "")
                {
                    objetoCDRegistro._diaSeleccionado = Convert.ToDateTime(Tabla.Rows[i]["diaSalidas"]);

                    DataTable TablaDatos = new DataTable();
                    TablaDatos = objetoCDRegistro.RegistroxDia();
                    if (GananciasTotales < Convert.ToDouble(TablaDatos.Rows[0]["GananciasTotales"]))
                    {
                        GananciasTotales = Convert.ToDouble(TablaDatos.Rows[0]["GananciasTotales"]);
                        DiaGT = objetoCDRegistro._diaSeleccionado.Date;
                    }
                    if (DuracionTotal < Convert.ToInt32(TablaDatos.Rows[0]["DuracionTotal"]))
                    {
                        DuracionTotal = Convert.ToInt32(TablaDatos.Rows[0]["DuracionTotal"]);
                        DiaDT = objetoCDRegistro._diaSeleccionado.Date;
                    }
                    if (RegistrosTotales < Convert.ToInt32(TablaDatos.Rows[0]["RegistrosTotales"]))
                    {
                        RegistrosTotales = Convert.ToInt32(TablaDatos.Rows[0]["RegistrosTotales"]);
                        DiaRT = objetoCDRegistro._diaSeleccionado.Date;
                    }
                }
                
            }
        }


        public void EditarRegistro()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCDRegistro.RegistroCompleto();
            tabla.PrimaryKey = new DataColumn[] { tabla.Columns["idregistro"] };


            DataRow FilaSelecionada = tabla.Rows.Find(ID_Registro);

            Precio = Convert.ToDouble(FilaSelecionada["Precio"]);
            FechaEntrada = Convert.ToDateTime(FilaSelecionada["entrada"]);


            //Precio = Convert.ToDouble(tabla.Rows[ID_Registro]["Precio"]);
            //FechaEntrada = Convert.ToDateTime(tabla.Rows[ID_Registro]["entrada"]);


            TimeSpan TiempoCalculado = FechaSalida - FechaEntrada;
            Duracion = Convert.ToInt32(TiempoCalculado.TotalMinutes);
            Coste = Duracion * Precio;

            objetoCDRegistro._ID_Registro = ID_Registro;
            objetoCDRegistro._Matricula = Matricula;
            objetoCDRegistro._FechaSalida = FechaSalida;
            objetoCDRegistro._Duracion = Duracion;
            objetoCDRegistro._Coste = Coste;

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
