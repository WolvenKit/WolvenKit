using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
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
                    var root = new XElement("root",""); 
                    var chunk = ApexChunk.chunks[0];                    
                    // NvParameters
                    var NvParameters = new XElement("NvParameters");
                    NvParameters.Add(new XAttribute("numObjects", "4"));
                    NvParameters.Add(new XAttribute("version", "1.0"));
                    root.Add(NvParameters);
                    //NvHairAssetHeaderInfo
                    var hairassetheaderinfo = new NvHairAssetHeaderInfo();
                    root.Add(hairassetheaderinfo.serialize(chunk,4));
                    //HairSceneDescriptor
                    var hairscenedesc = new HairSceneDescriptor();
                    root.Add(hairscenedesc.serialize(chunk));
                    //NvHairAssetDescriptor    
                    var hairassetdescriptor = new NvHairAssetDescriptor();
                    root.Add(hairassetdescriptor.serialize(chunk));
                    //HairInstanceDescriptor
                    var hairinstancedescriptor = new NvHairInstanceDescriptor();
                    root.Add(hairinstancedescriptor.serialize(chunk));
                    return new XDocument(root);
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
