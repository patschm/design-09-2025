using System.IO.Compression;
using System.Security.Cryptography;

namespace ReadersEnzo;

internal class Program
{
    static void Main(string[] args)
    {
        Aes aes = Aes.Create();
        FileStream fs = File.Create("file.zip");
        CryptoStream crypt = new CryptoStream(fs, aes.CreateEncryptor(), CryptoStreamMode.Write);
        GZipStream zip = new GZipStream(crypt, CompressionMode.Compress );
        StreamWriter writer = new StreamWriter(zip);
        for (int i = 0; i < 1000; i++)
        {

            writer.WriteLine($"Hello World {i}");
        }
        writer.Dispose();   
    }
}
