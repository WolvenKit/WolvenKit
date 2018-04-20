using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Wolvekit.Nvidia.HairWorks;
using WolvenKit;
using WolvenKit.CR2W;

namespace WolvenKit
{
    class Program
    {
        //https://github.com/NVIDIAGameWorks/HairWorks/tree/7a7274bafdfdd88770668cf5b3dcbeb85e0028a2/src/Nv/HairWorks/Internal/Serialize/Params
        [STAThread]
        static void Main(string[] args)
        {
            var br = new BinaryReader(new FileStream("C:\\Users\\bence.hambalko\\Documents\\Apex\\hw.redfur",FileMode.Open));
            var redfur = new CR2WFile(br);
            Apex.HairWorks.ConvertToApexXml(redfur).Save("C:\\Users\\bence.hambalko\\Documents\\Apex\\out.apx");
            NvidiaXML.BreakXmlHeader("C:\\Users\\bence.hambalko\\Documents\\Apex\\out.apx");
        }
    }
}
