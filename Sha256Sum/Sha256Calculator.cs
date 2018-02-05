using System.Security.Cryptography;
using System.Text;

namespace BTH.Sha256Sum
{
    public class Sha256Calculator
    {
        public static string Calculate(System.IO.Stream stream)
        {
            SHA256 mySHA256 = SHA256.Create();
            byte[] hash = mySHA256.ComputeHash(stream);
            return ToHex(hash);
        }

        private static string ToHex(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba) {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
    }
}
