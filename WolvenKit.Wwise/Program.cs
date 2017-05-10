using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SoundBankParser
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            using (var of = new OpenFileDialog())
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    var filepath = of.FileName; //music
                    Console.Title = of.FileName;
                    BNK soundbank;

                    using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                    {
                        Console.WriteLine("Reading file...");
                        var ms = new MemoryStream();
                        fs.CopyTo(ms);
                        soundbank = new BNK();
                        soundbank.LoadBNK(ms);
                        ms.Close();
                        Console.WriteLine("Done reading...");
                    }

                    //generate the same bnk
                    using (var fs = new FileStream(filepath + "_gen", FileMode.Create, FileAccess.Write))
                    {
                        Console.WriteLine("Writing file...");
                        var ms = new MemoryStream();
                        soundbank.GenerateBNK(ms);
                        ms.WriteTo(fs);
                        ms.Close();
                        Console.WriteLine("Done writing...");
                    }
                    string Oldfilehash;
                    string Newfilehash;

                    using (var md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(filepath + "_gen"))
                        {
                            Newfilehash = BitConverter.ToString(md5.ComputeHash(stream));
                        }
                    }
                    using (var md5 = MD5.Create())
                    {
                        using (var stream = File.OpenRead(filepath))
                        {
                            Oldfilehash = BitConverter.ToString(md5.ComputeHash(stream));
                        }
                    }
                    if (Oldfilehash == Newfilehash)
                    {
                        MessageBox.Show(
                            $"The created file is identical to the old one!\nOld file MD5: {Oldfilehash}\nNew file MD5: {Newfilehash}");
                    }
                    else
                    {
                        MessageBox.Show(
                            $"The created file is not identical to the old one!\nOld file MD5: {Oldfilehash}\nNew file MD5: {Newfilehash}");
                    }
                }
            }
        }
    }
}