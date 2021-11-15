using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaSoporte.Cache;


namespace CapaDatos
{
    public class UserDao: ConnectionToSql
    {
        public bool Login (string user, string pass)
        {
            using(var connection = GetConnection())
            { 
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT*FROM Users WHERE LoginName=@user and PasswordUser=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUsuario.IdUsuario = reader.GetInt32(0);
                            CacheUsuario.Usuario = reader.GetString(1);
                            CacheUsuario.Contraseña = reader.GetString(2);
                            CacheUsuario.Nombre = reader.GetString(3);
                            CacheUsuario.Apellido = reader.GetString(4);
                            CacheUsuario.Posicion = reader.GetString(5);
                            CacheUsuario.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
