using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model.utils
{
  public static  class SecurityUtil
    {

        private static string MD5Encoding(string rawPass)
        {
            
            MD5 md5 = MD5.Create();
            byte[] bs = Encoding.UTF8.GetBytes(rawPass);
            byte[] hs = md5.ComputeHash(bs);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hs)
            {
                 
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

       
        public static string MD5Encoding(string rawPass, object salt)
        {
            if (salt == null) return rawPass;
            return MD5Encoding(rawPass + "{" + salt.ToString() + "}");
        }
    }

}

