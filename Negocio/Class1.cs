using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Usuario
    {
        private static HashService hash = new HashService();

        public static E_Usuario login(string strUsuario, string strPassword)
        {
            // Enviar el usuario y el hash a la capa de Datos
            return D_Usuario.login(strUsuario, strPassword);
        }

        public static string GenerarHash(string password)
        {
            return hash.GenerarHash(password);
        }
        public static bool VerificarHash(string password, string hashAlmacenado)
        {
            return hash.Verificar(password, hashAlmacenado);
        }
    }
}
