using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Wolvekit.Nvidia.HairWorks;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit
{
    public class Apex
    {
        /// <summary>
        /// Class to convert and operate with hairworks files.
        /// </summary>
        public class HairWorks
        {
            public static XDocument Doc = new XDocument();

            public static XDocument ConvertToApexXml(CR2WFile ApexChunk)
            {
                if (ApexChunk.chunks[0].Type == "CFurMeshResource")
                {
                    var chunk = ApexChunk.chunks[0];                    
                    //Root node
                    var NvParameters = new XElement("NvParameters");
                    NvParameters.Add(new XAttribute("numObjects", "4"));
                    NvParameters.Add(new XAttribute("version", "1.0"));
                    //NvHairAssetHeaderInfo
                    var hairassetheaderinfo = new NvHairAssetHeaderInfo();
                    NvParameters.Add(hairassetheaderinfo.serialize(chunk,4));
                    //HairSceneDescriptor
                    //TODO: Others

                    return new XDocument(NvParameters);
                }
                else
                {
                    throw new InvalidChunkTypeException("Not a valid apex file chunk!");
                }
            }

            public static CR2WFile ConvertToCr2W(XDocument ApexFile)
            {
                var crw = new CR2WFile();
                return crw;
            }
        }

        /// <summary>
        /// Class to convert and operate with apex apb cloth files.
        /// </summary>
        public class Cloth
        {
            public static byte[] ConvertToApexXml(CR2WFile apexChunk)
            {
                return null;
            }

            public static CR2WFile ConvertToCr2W(byte[] cloth)
            {
                return null;
            }
        }

        /// <summary>
        /// Fixes PhysX xml files so .net can read them.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static void FixXmlHeader(string path)
        {
            File.WriteAllLines(path, new string[] { "<?xml version=\"1.0\" encoding=\"utf-8\"?>" }.ToList().Concat(File.ReadAllLines(path).Skip(1).ToArray()));

        }

        /// <summary>
        /// Replaces the header of an xml with the weird PhysX style header.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static void BreakXmlHeader(string path)
        {
            File.WriteAllLines(path, new string[] { "<!DOCTYPE NvParameters>" }.ToList().Concat(File.ReadAllLines(path).Skip(1).ToArray()));
        }

        /// <summary>
        /// Calculates the PhysX checksum for given object.
        /// </summary>
        /// <param name="obj">The object to calculate the checksum for.</param>
        /// <returns>The checksum as an xelement.</returns>
        public static XElement CalculateCheckSum(object obj)
        {
            var hexnums = "";
            return new XElement("checksum",hexnums);
        }

        /// <summary>
        /// Formats a CArray of coordinates to NvParameterized format.
        /// Eg.: X Y Z, X Y Z, ......
        /// </summary>
        /// <param name="coords">Coordinates to format.</param>
        /// <returns>The string of coordinates.</returns>
        public static string FormatCoordinateArray(CArray coords)
        {
            var ret = "";
            foreach (var coord in coords.array)
            {
                if (((CVector) (coord)).variables.Count > 3)
                {
                    ret += ((CVector)(coord)).variables[0] + " ";
                    ret += ((CVector)(coord)).variables[1] + " ";
                    ret += ((CVector)(coord)).variables[2] + ", ";
                }
            }
            return ret.Trim(',',' ');
        }
    }
}
