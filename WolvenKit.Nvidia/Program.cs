using System;
using System.IO;
using WolvenKit.CR2W;
using WolvenKit.Nvidia.HairWorks;

namespace WolvenKit.Nvidia
{
    internal class Program
    {
        #region Methods

        //https://github.com/NVIDIAGameWorks/HairWorks/tree/7a7274bafdfdd88770668cf5b3dcbeb85e0028a2/src/Nv/HairWorks/Internal/Serialize/Params
        [STAThread]
        private static void Main(string[] args)
        {
            var br = new BinaryReader(new FileStream("C:\\Users\\bence.hambalko\\Documents\\Apex\\hw.redfur", FileMode.Open));
            var redfur = new CR2WFile();
            redfur.ReadAsync(br).GetAwaiter().GetResult();
            Apex.HairWorks.ConvertToApexXml(redfur).Save("C:\\Users\\bence.hambalko\\Documents\\Apex\\out.apx");
            NvidiaXML.BreakXmlHeader("C:\\Users\\bence.hambalko\\Documents\\Apex\\out.apx");
        }

        #endregion Methods
    }
}
