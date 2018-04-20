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
                    var hairscenedesc = new HairSceneDescriptor();
                    NvParameters.Add(hairscenedesc.serialize(chunk));
                    //NvHairAssetDescriptor
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
