using System.Security.Cryptography;
using System.Text;

namespace webtudo.Services
{
    public static class SenhaService
    {
        public static string GerarHash(string senha)
        {
            var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(senha));
            return Convert.ToHexString(bytes);
        }

        public static bool Validar(string senha, string hashArmazenado) =>
            GerarHash(senha).Equals(hashArmazenado, StringComparison.OrdinalIgnoreCase);
    }
}
