using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speedprueba
{
    public static class Ascii
    {

        public static string ConvertHex(string base64data)
        {

            var base64EncodedBytes = System.Convert.FromBase64String(base64data);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);

            //try
            //{
            //    string ascii = string.Empty;
            //    string print = string.Empty;

            //    for (int i = 0; i < hexString.Length; i += 2)
            //    {
            //        String hs = string.Empty;

            //        hs = hexString.Substring(i, 2);
            //        uint decval = System.Convert.ToUInt32(hs, 16);
            //        char character = System.Convert.ToChar(decval);
            //        ascii += character;
            //        print += ascii;


            //    }

            //    return print;
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }

            //return string.Empty;

        }
}
}
