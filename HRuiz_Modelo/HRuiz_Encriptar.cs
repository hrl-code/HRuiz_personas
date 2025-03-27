using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRuiz_Personas.HRuiz_Modelo
{
    internal class HRuiz_Encriptar
    {
        static readonly string clavePrivada = "2024tareadam2024";
        public String HRuiz_EncriptarTexto(String textoacifrar)
        {
            Aes aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(clavePrivada);
            aes.IV = new byte[aes.BlockSize / 8];


            ICryptoTransform encriptador = aes.CreateEncryptor(aes.Key, aes.IV);

            MemoryStream flujodatosmemoria = new MemoryStream();

            CryptoStream cifradodedatos = new CryptoStream(flujodatosmemoria, encriptador, CryptoStreamMode.Write);

            byte[] bytesdeltextoPlano = UTF8Encoding.UTF8.GetBytes(textoacifrar);
            cifradodedatos.Write(bytesdeltextoPlano, 0, bytesdeltextoPlano.Length);
            cifradodedatos.FlushFinalBlock();

            byte[] bytescifrados = flujodatosmemoria.ToArray();

            flujodatosmemoria.Close();
            cifradodedatos.Close();

            return Convert.ToBase64String(bytescifrados);
        }

        public static string HRuiz_Desencriptar(string textoacifrado)
        {
            byte[] textoCifradoBytes = Convert.FromBase64String(textoacifrado);
            Aes aes = Aes.Create();

            aes.Key = Encoding.UTF8.GetBytes(clavePrivada);
            aes.IV = new byte[aes.BlockSize / 8];

            ICryptoTransform desencriptador = aes.CreateDecryptor(aes.Key, aes.IV);

            MemoryStream flujodatosmemoria = new MemoryStream(textoCifradoBytes);

            CryptoStream descifradodedatos = new CryptoStream(flujodatosmemoria, desencriptador, CryptoStreamMode.Read);

            StreamReader sr = new StreamReader(descifradodedatos);

            return sr.ReadToEnd();
        }
    }
}
