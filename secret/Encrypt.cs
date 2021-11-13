using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


namespace FB.secret
{
    class Encrypt
    {
       
        public Encrypt()
        {
            
        }
        
        
        public string encrypt(string cadena, string key)
        {
            byte[] keyArray;
            byte[] encriptar = Encoding.UTF8.GetBytes(cadena);

            keyArray = Encoding.UTF8.GetBytes(key);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cryptoTransform = tdes.CreateEncryptor();
            byte[] resultado = cryptoTransform.TransformFinalBlock(encriptar,0,encriptar.Length);
            tdes.Clear();

            return Convert.ToBase64String(resultado, 0, resultado.Length);

        }

        public string decrypt(string cadena, string key)
        {
            byte[] keyArray;
            try
            {
                byte[] desencriptar = Convert.FromBase64String(cadena);

                keyArray = Encoding.UTF8.GetBytes(key);

                var tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cryptoTransform = tdes.CreateDecryptor();
                byte[] resultado = cryptoTransform.TransformFinalBlock(desencriptar, 0, desencriptar.Length);
                tdes.Clear();

                return Encoding.UTF8.GetString(resultado, 0, resultado.Length);
            }
            catch
            {
                return cadena;
            }
            

        }
    }
}
