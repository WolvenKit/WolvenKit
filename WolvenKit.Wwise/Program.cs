namespace WolvenKit.Wwise
{
    //class Program
    //{
    //    [STAThread]
    //    public static void Main(string[] args)
    //    {
    //        TestBNK();
    //    }

    //    public static void TestWEM()
    //    {
    //        using (var of = new System.Windows.Forms.OpenFileDialog())
    //        {
    //            of.Filter = "Witcher 3 BNK File | *.wem";
    //            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
    //            {
    //                var wem = new WEM.RiffFile(of.FileName);
    //                wem.WriteFile(Path.GetDirectoryName(of.FileName) + "\\generated.wem");
    //            }
    //        }
    //    }

    //    public static void TestBNK()
    //    {
    //        using (var of = new System.Windows.Forms.OpenFileDialog())
    //        {
    //            of.Filter = "Witcher 3 BNK File | *.bnk";
    //            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
    //            {
    //                using (var fs = new FileStream(of.FileName, FileMode.Open))
    //                {
    //                    var bnk = new BNK.BNK();
    //                    bnk.LoadBNK(fs);
    //                    using (var ms = new MemoryStream())
    //                    {
    //                        bnk.GenerateBNK(ms);
    //                        File.WriteAllBytes(Path.GetDirectoryName(of.FileName) + "\\generated.bnk", ms.ToArray());
    //                    }
    //                }
    //            }
    //        }
    //    }
    //}
}
