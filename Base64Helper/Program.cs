using System;
using System.Diagnostics;
using System.IO;

namespace Base64Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            var base64str = "";
            byte[] fileArray = Convert.FromBase64String(base64str);
            string path = Directory.GetCurrentDirectory() + "\\" + Guid.NewGuid() + ".pdf";
            Console.WriteLine(path);
            File.WriteAllBytes(path, fileArray);
            new Process
            {
                StartInfo = new ProcessStartInfo(path)
                {
                    UseShellExecute = true
                }
            }.Start();
        }
    }
}
