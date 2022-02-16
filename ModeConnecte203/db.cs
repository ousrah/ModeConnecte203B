using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
namespace ModeConnecte203
{
    public static class db
    {
        static public byte[] cle = System.Convert.FromBase64String("12UCgcnHy8LHoN/VodosrUVgv+r+kQ5e");
        static public byte[] iv = System.Convert.FromBase64String("AsJNO9N/4dM=");
        public static string decrypterChaineConnection(string cs)
        {
            string newCs="";

            string[] t = cs.Split(';');
            string pass = t[3];
            pass = pass.Replace(" ", "");
            pass = pass.Substring(9);

            pass = DecryptSym(System.Convert.FromBase64String(pass), cle, iv);

            newCs = t[0] + ";" + t[1] + ";" + t[2] + ";" + "Password=" + pass;

            return newCs;


        }

        static public string DecryptSym(byte[] cryptedTextAsByte, byte[] key, byte[] iv)
        {
            TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();

            // Cet objet est utilisé pour déchiffrer les données.
            // Il reçoit les données chiffrées sous la forme d'un tableau de bytes.
            // Les données déchiffrées sont également retournées sous la forme d'un tableau de bytes
            var decryptor = TDES.CreateDecryptor(key, iv);

            byte[] decryptedTextAsByte = decryptor.TransformFinalBlock(cryptedTextAsByte, 0, cryptedTextAsByte.Length);

            return Encoding.Default.GetString(decryptedTextAsByte);
        }

    }
}
