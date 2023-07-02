using Newtonsoft.Json;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BantuLite.Utilities
{
    public class Utilities
    {
        public static string EncryptText(string strInputText)
        {
            byte[] data = Array.ConvertAll<char, byte>(strInputText.ToCharArray(), delegate (char ch) { return (byte)ch; });
            SHA256 shaM = new SHA256Managed();
            byte[] result = shaM.ComputeHash(data);
            return Convert.ToBase64String(result);
        }
    }

    public class ByteConvertHelper
    {
        public static byte[] Object2Bytes(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            byte[] serializedResult = Encoding.UTF8.GetBytes(json);
            return serializedResult;
        }


        public static object Bytes2Object(byte[] buff)
        {
            string json = Encoding.UTF8.GetString(buff);
            return JsonConvert.DeserializeObject<object>(json);
        }


        public static T Bytes2Object<T>(byte[] buff)
        {
            string json = Encoding.UTF8.GetString(buff);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }

  
}
