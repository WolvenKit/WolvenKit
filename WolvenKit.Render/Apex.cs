using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WolvenKit.Render
{
    public class Apex
    {
        public static XDocument Doc = new XDocument();

        public static void Read(string filename)
        {
            FixXmlHeader(filename);
            var doc = XDocument.Load(filename);
        }

        public static void Write(string filename)
        {
            Doc.Save(filename);
            BreakXmlHeader(filename);
        }

        public static void FixXmlHeader(string path)
        {
            File.WriteAllLines(path, new string[] { "<?xml version=\"1.0\" encoding=\"utf-8\"?>" }.ToList().Concat(File.ReadAllLines(path).Skip(1).ToArray()));

        }

        public static void BreakXmlHeader(string path)
        {
            File.WriteAllLines(path, new string[] { "<!DOCTYPE NvParameters>" }.ToList().Concat(File.ReadAllLines(path).Skip(1).ToArray()));
        }
    }
}
