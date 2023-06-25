using System.Security.Cryptography;
using System.Text;

namespace WFA_Hashing {
    static internal class Utilty {
        public static string GetHash(HashAlgorithm hashAlgorithm, string plainText) {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++) {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
