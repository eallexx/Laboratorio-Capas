using System;
using System.Text;
using System.Security.Cryptography;

namespace Negocio
{
    public class HashService : IHashService, IVerificarHashService
    {
        public string GenerarHash(string textoPlano)
        {
            using (var sha512 = SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textoPlano);
                byte[] hashBytes = sha512.ComputeHash(bytes);

                return BitConverter.ToString(hashBytes)
                    .Replace("-", "").ToLowerInvariant();
            }
        }

        public bool Verificar(string textoPlano, string hashAlmacenado)
        {
            string hashGenerado = GenerarHash(textoPlano);

            return hashGenerado == hashAlmacenado;
        }
    }
}