using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace pruebaencriclass
{
    public class clsEncriptacion
    {
        string mensaje = "";
        public string stEncriptar(string stcadena)
        {
            byte[] BtclearBytes;
            BtclearBytes = new UnicodeEncoding().GetBytes(stcadena);
            byte[] BthashedBytes = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(BtclearBytes);
            string sthashedtext = BitConverter.ToString(BthashedBytes);
                return sthashedtext;
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        /*Un StringBuilder representa una serie de caracteres que, a diferencia de una cadena normal, son mutables. ...
         * Copiando todos los caracteres de myString en el comienzo de nuestra nueva matriz y
         * copiando la nueva cadena en el final de la matriz. Cree un nuevo objeto de cadena en la memoria y myString a myString a myString*/
    

        public string encri3des(string stcadena,string tkey)
        {
            try
            {
                TripleDESCryptoServiceProvider des;
                MD5CryptoServiceProvider hashmd5;
                byte[] keyhash, buff;
                string stEncripted;
                hashmd5 = new MD5CryptoServiceProvider();
                keyhash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(tkey));
                hashmd5 = null;
                des = new TripleDESCryptoServiceProvider();
                des.Key = keyhash;
                des.Mode = CipherMode.ECB;

                buff = ASCIIEncoding.ASCII.GetBytes(stcadena);
                stEncripted = Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buff, 0, buff.Length));
                return stEncripted;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }



        public string des3des(string stcadena, string tkey)
        {
            try
            {
                TripleDESCryptoServiceProvider des;
                MD5CryptoServiceProvider hashmd5;
                byte[] keyhash, buff;
                string stDecripted;
                hashmd5 = new MD5CryptoServiceProvider();
                keyhash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(tkey));
                hashmd5 = null;
                des = new TripleDESCryptoServiceProvider();
                des.Key = keyhash;
                des.Mode = CipherMode.ECB;

                buff = Convert.FromBase64String(stcadena);
                stDecripted = ASCIIEncoding.ASCII.GetString(des.CreateDecryptor().TransformFinalBlock(buff, 0, buff.Length));
                return stDecripted;
              
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    
    }
}
