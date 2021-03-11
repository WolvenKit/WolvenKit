using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace WolvenKit.Nvidia.HairWorks
{
    internal static class NvidiaXML
    {
        #region Methods

        public static void AddNvArray(this XElement elem, string name, string type, string count, string arrayvalue)
        {
            elem.Add(new XElement("value",
                new XAttribute("name", name),
                new XAttribute("size", count),
                new XAttribute("type", type),
                arrayvalue));
        }

        public static void AddNvArray(this XElement elem, string name, string type, string count, List<XElement> elems)
        {
            elem.Add(new XElement("value",
                new XAttribute("name", name),
                new XAttribute("size", count),
                new XAttribute("type", type),
                elems));
        }

        public static void AddNvValue(this XElement elem, string name, string type, string value,
                            bool isnull = false, params XElement[] extraElements)
        {
            var typenode = isnull ? new List<XAttribute>() { new XAttribute("null", 1), new XAttribute("type", type) } :
                new List<XAttribute>() { new XAttribute("type", type) };
            if (extraElements != null && extraElements.Length > 0)
            {
                elem.Add(new XElement("value",
                    new XAttribute("name", name),
                    typenode,
                    extraElements,
                    value));
            }
            else
            {
                elem.Add(new XElement("value",
                    new XAttribute("name", name),
                    typenode,
                    value));
            }
        }

        /// <summary>
        /// Replaces the header of an xml with the weird PhysX style header.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static void BreakXmlHeader(string path)
        {
            File.WriteAllLines(path, new string[] { "<!DOCTYPE NvParameters>" }.Concat(XDocument.Load(path).Root.Elements().Select(x => x.ToString())));
        }

        public static XElement CreateStructHeader(string name, string type, string classname, string version, string checksum)
        {
            XElement ret = new XElement("value");
            ret.Add(new XAttribute("name", name));
            ret.Add(new XAttribute("type", type));
            ret.Add(new XAttribute("className", classname));
            ret.Add(new XAttribute("version", version));
            ret.Add(new XAttribute("checksum", checksum));
            return ret;
        }

        /// <summary>
        /// Fixes PhysX xml files so .net can read them.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static void FixXmlHeader(string path)
        {
            File.WriteAllLines(path, new string[] { "<?xml version=\"1.0\" encoding=\"utf-8\"?>" }.ToList().Concat(File.ReadAllLines(path).Skip(1).ToArray()));
        }

        #endregion Methods
    }
}
