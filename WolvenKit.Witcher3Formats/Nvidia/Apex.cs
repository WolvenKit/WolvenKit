using System.Xml.Linq;
using WolvenKit.Common.Exceptions;
using WolvenKit.RED3.CR2W;
using WolvenKit.RED3.CR2W.Types;
using WolvenKit.Nvidia.HairWorks;

namespace WolvenKit
{
    public class Apex
    {
        #region Methods

        /// <summary>
        /// Formats a CArray of coordinates to NvParameterized format.
        /// Eg.: X Y Z, X Y Z, ......
        /// </summary>
        /// <param name="coords">Coordinates to format.</param>
        /// <returns>The string of coordinates.</returns>
        public static string FormatCoordinateArray(CArray<Vector> coords)
        {
            var ret = "";
            foreach (var coord in coords)
            {
                ret += coord.X.ToString() + " ";
                ret += coord.Y.ToString() + " ";
                ret += coord.Z.ToString() + ", ";
            }
            return ret.Trim(',', ' ');
        }

        #endregion Methods

        #region Classes

        /// <summary>
        /// Class to convert and operate with hairworks files.
        /// </summary>
        public class HairWorks
        {
            #region Fields

            public static XDocument Doc = new XDocument();

            #endregion Fields

            #region Methods

            public static XDocument ConvertToApexXml(CR2WFile ApexChunk)
            {
                if (ApexChunk.Chunks[0].REDType == "CFurMeshResource" && ApexChunk.Chunks[0].data is CFurMeshResource cFurMesh)
                {
                    var root = new XElement("root", "");
                    // NvParameters
                    var NvParameters = new XElement("NvParameters");
                    NvParameters.Add(new XAttribute("numObjects", "4"));
                    NvParameters.Add(new XAttribute("version", "1.0"));
                    root.Add(NvParameters);
                    //NvHairAssetHeaderInfo
                    var hairassetheaderinfo = new NvHairAssetHeaderInfo();
                    root.Add(hairassetheaderinfo.serialize(cFurMesh, 4));
                    //HairSceneDescriptor
                    var hairscenedesc = new HairSceneDescriptor();
                    root.Add(hairscenedesc.serialize(cFurMesh));
                    //NvHairAssetDescriptor
                    var hairassetdescriptor = new NvHairAssetDescriptor();
                    root.Add(hairassetdescriptor.serialize(cFurMesh));
                    //HairInstanceDescriptor
                    var hairinstancedescriptor = new NvHairInstanceDescriptor();
                    root.Add(hairinstancedescriptor.serialize(cFurMesh));
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

            #endregion Methods
        }

        #endregion Classes
    }
}
