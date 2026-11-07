using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Usuario : D_Conexion
    {
        public static E_Usuario login(string strUsuario, string strPassword)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand("sp_ValidarLoginHash", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Corregido: Sin la arroba, usando el guin bajo tal cual esta en MySQL
                        cmd.Parameters.AddWithValue("_dsUsuario", strUsuario);
                        cmd.Parameters.AddWithValue("_dsPassword", strPassword);

                        using (MySqlDataReader fReader = cmd.ExecuteReader())
                        {
                            E_Usuario usuario = new E_Usuario();

                            while (fReader.Read())
                            {
                                //Corregido: Leyendo la columna 'id' correctamente
                                usuario.id = fReader.GetInt32("id");
                                usuario.dsUsuario = fReader.GetString("dsUsuario");
                            }
                            return usuario;
                        }
                    } 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la informacion: " + ex.ToString()); 
            }

            //si el while/if no se ejecuta, signfica que el usuario o contraseña son incorrectos
            //return null;
        }//fin de public static E_Usuario login(string strUsuario, string strPassword)
    }
}
