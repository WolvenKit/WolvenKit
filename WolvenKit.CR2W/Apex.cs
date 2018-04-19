using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
                    return Doc = new XDocument(
                        new XElement("NvParameters", new XAttribute("numObjects", "3"), new XAttribute("version", "1.0"),
                            new XElement("value", new XAttribute("name", ""), new XAttribute("type", "Ref"), new XAttribute("className", "HairWorksInfo"), new XAttribute("version", 1.1), new XAttribute("checksum", "0xFFFFFFFF"),
                                new XElement("struct", new XAttribute("name", ""),
                                    new XElement("value", new XAttribute("name", "fileVersion"), new XAttribute("type", "String"), "1.1"),
                                    new XElement("value", new XAttribute("name", "toolVersion"), new XAttribute("type", "String"), "WolvenKit"),
                                    new XElement("value", new XAttribute("name", "sourcePath"), new XAttribute("type", "String"), "https://github.com/Traderain/Wolven-kit"),
                                    new XElement("value", new XAttribute("name", "authorName"), new XAttribute("type", "String"), Environment.UserName),
                                    new XElement("value", new XAttribute("name", "fileVersion"), new XAttribute("type", "String"), DateTime.Now.ToString("R")))),
                            new XElement("value", new XAttribute("name", ""), new XAttribute("type", "Ref"), new XAttribute("className", "HairSceneDescriptor"), new XAttribute("version", 1.1), new XAttribute("checksum", "0xFFFFFFFF"),
                                new XElement("struct", new XAttribute("name", ""),
                                    new XElement("value", new XAttribute("name", "densityTexture"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "rootColorTexture"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "tipColorTexture"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "widthTexture"), new XAttribute("null", "1"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "rootWidthTexture"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "tipWidthTexture"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "stiffnessTexture"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "rootStiffnessTexture"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "clumpScaleTexture"), new XAttribute("null", "1"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "clumpRoundnessTexture"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "clumpNoiseTexture"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "waveScaletexture"), new XAttribute("null", "1"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "waveFreqTexture"), new XAttribute("null", "1"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "strandTexture"), new XAttribute("null", "1"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "lengthTexture"), new XAttribute("type", "String"), ""),
                                    new XElement("value", new XAttribute("name", "specularTexture"), new XAttribute("null", "1"), new XAttribute("type", "String"), ""))),
                            new XElement("value", new XAttribute("name", ""), new XAttribute("type", "Ref"), new XAttribute("className", "HairAssetDescriptor"), new XAttribute("version", 1.1), new XAttribute("checksum", "0xFFFFFFFF"),
                                new XElement("struct", new XAttribute("name", ""),
                                    new XElement("value", new XAttribute("name", "numGuideHairs"), new XAttribute("type", "U32"), ((CArray)chunk.GetVariableByName("boneIndices")).array.Count),
                                    new XElement("value", new XAttribute("name", "numVertices"), new XAttribute("type", "U32"), ((CArray)chunk.GetVariableByName("positions")).array.Count),
                                    new XElement("array", new XAttribute("name", "vertices"), new XAttribute("size", ((CArray)chunk.GetVariableByName("positions")).array.Count), new XAttribute("type", "Vec3"), FormatCoordinateArray(((CArray)chunk.GetVariableByName("positions")))),
                                    new XElement("array", new XAttribute("name", "endIndices"), new XAttribute("size", ((CArray)(chunk.GetVariableByName("endIndices"))).array.Count), new XAttribute("type", "U32"), ((CArray)(chunk.GetVariableByName("endIndices"))).array.Aggregate("", (c, n) => c += " " + n)),
                                    new XElement("value", new XAttribute("name", "numFaces"), new XAttribute("type", "U32"), ""),
                                    new XElement("array", new XAttribute("name", "faceIndices"), new XAttribute("size", ""), new XAttribute("type", "U32"), ""),
                                    new XElement("array", new XAttribute("name", "faceUVs"), new XAttribute("size", ""), new XAttribute("type", "Vec2"), ""),
                                    new XElement("value", new XAttribute("name", "numBones"), new XAttribute("type", "U32"), ""),
                                    new XElement("array", new XAttribute("name", "boneIndices"), new XAttribute("size", ""), new XAttribute("type", "Vec4"), ""),
                                    new XElement("array", new XAttribute("name", "boneWeights"), new XAttribute("size", ""), new XAttribute("type", "Vec4"), ""),
                                    new XElement("array", new XAttribute("name", "boneNames"), new XAttribute("size", ""), new XAttribute("type", "U8"), ""),
                                    new XElement("array", new XAttribute("name", "array"), new XAttribute("size", ""), new XAttribute("type", "String"), ""),
                                    new XElement("array", new XAttribute("name", "bindPoses"), new XAttribute("size", ""), new XAttribute("type", "Mat44"), ""),
                                    new XElement("array", new XAttribute("name", "boneParents"), new XAttribute("size", ""), new XAttribute("type", "I32"), ""),
                                    new XElement("value", new XAttribute("name", "numBoneSpheres"), new XAttribute("type", "U32"), ""),
                                    new XElement("array", new XAttribute("name", "boneSpheres"), new XAttribute("size", ""), new XAttribute("type", "Struct"), ""),
                                    new XElement("value", new XAttribute("name", "numBoneCapsules"), new XAttribute("type", "U32"), ""),
                                    new XElement("array", new XAttribute("name", "boneCapsuleIndices"), new XAttribute("size", ""), new XAttribute("type", "U32"), ""),
                                    new XElement("value", new XAttribute("name", "numPinConstraints"), new XAttribute("type", "U32"), ""),
                                    new XElement("array", new XAttribute("name", "pinConstraints"), new XAttribute("size", ""), new XAttribute("type", "Struct"), ""),
                                    new XElement("value", new XAttribute("name", "sceneUnit"), new XAttribute("type", "F32"), ""),
                                    new XElement("value", new XAttribute("name", "upAxis"), new XAttribute("type", "U32"), ""),
                                    new XElement("value", new XAttribute("name", "handedness"), new XAttribute("type", "U32"), ""))),
                            new XElement("value", new XAttribute("name", ""), new XAttribute("type", "Ref"), new XAttribute("className", "HairInstanceDescriptor"), new XAttribute("version", 1.1), new XAttribute("checksum", "0xFFFFFFFF"))));
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
