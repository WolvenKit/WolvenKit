using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WolvenKit.CR2W;

namespace WolvenKit
{
    public class Apex
    {
        public static XDocument Doc = new XDocument();

        public Apex(CR2WFile ApexChunk)
        {
            if (ApexChunk.chunks[0].Type == "CApexClothResource")
            {
                
                Doc = new XDocument(
                    new XElement("NvParameters",new XAttribute("numObjects","4"),new XAttribute("version","1.0"),
                        new XElement("value", new XAttribute("name", ""), new XAttribute("type", "Ref"), new XAttribute("className", "HairWorksInfo"), new XAttribute("version", 1.1), new XAttribute("checksum", "0xFFFFFFFF"),
                            new XElement("struct",new XAttribute("name", ""),
                                new XElement("value", new XAttribute("name", "fileVersion"), new XAttribute("type", "String"), "1.1"),
                                new XElement("value", new XAttribute("name", "toolVersion"), new XAttribute("type", "String"), "None since it's made by me"),
                                new XElement("value", new XAttribute("name", "sourcePath"), new XAttribute("type", "String"), "https://github.com/Traderain/Wolven-kit"),
                                new XElement("value", new XAttribute("name", "authorName"), new XAttribute("type", "String"), Environment.UserName),
                                new XElement("value", new XAttribute("name", "fileVersion"), new XAttribute("type", "String"), DateTime.Now.ToString("R")))),
                        new XElement("value", new XAttribute("name", ""), new XAttribute("type", "Ref"), new XAttribute("className", "HairSceneDescriptor"), new XAttribute("version", 1.1), new XAttribute("checksum", "0xFFFFFFFF")),
                        new XElement("value", new XAttribute("name", ""), new XAttribute("type", "Ref"), new XAttribute("className", "HairAssetDescriptor"), new XAttribute("version", 1.1), new XAttribute("checksum", "0xFFFFFFFF")),
                        new XElement("value", new XAttribute("name", ""), new XAttribute("type", "Ref"), new XAttribute("className", "HairInstanceDescriptor"), new XAttribute("version", 1.1), new XAttribute("checksum", "0xFFFFFFFF"))));
            }
            else
            {
                throw new InvalidChunkTypeException("Not a valid apex file chunk!");
            }
        }

        public void Read(string filename)
        {
            FixXmlHeader(filename);
            var doc = XDocument.Load(filename);
        }

        public void Write(string filename)
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
