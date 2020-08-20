using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WolvenKit;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace Wolvekit.Nvidia.HairWorks
{
    class NvHairAssetDescriptor
    {

        public string checksum = "0x299b335f 0x2cad8b54 0xcaf3c98f 0xa3094fa7";

        public XElement serialize(CR2WExportWrapper chunk)
        {
            var ret = NvidiaXML.CreateStructHeader("", "Ref", "HairSceneDescriptor", "1.0", checksum);
            ret.AddNvValue("numGuideHairs","U32",((CArray)chunk.GetVariableByName("boneIndices")).array.Count.ToString());
            ret.AddNvValue("numVertices","U32",((CArray)chunk.GetVariableByName("positions")).array.Count.ToString());
            ret.AddNvArray("vertices","Vec3","",Apex.FormatCoordinateArray((CArray)chunk.GetVariableByName("positions"))); //TODO: Check why this has wrong numbers. Its correct but the matrix needs to be changed somehow!
            var endindicies = ((CArray)chunk.GetVariableByName("endIndices")).array;
            ret.AddNvArray("endIndices","U32",endindicies.Count.ToString(),endindicies.Aggregate("",(c,n) => c += " " + n));
            ret.AddNvValue("numFaces","U32",""); //TODO
            var faceIndices = ((CArray)chunk.GetVariableByName("faceIndices")).array;
            ret.AddNvArray("faceIndices","U32",faceIndices.Count.ToString(),faceIndices.Aggregate("",(c,n) => c += " " + n));
            ret.AddNvArray("faceUVs","Vec2","",""); //TODO
            ret.AddNvValue("numBones","U32",chunk.GetVariableByName("boneCount").ToString());
            ret.AddNvArray("boneIndices","Vec4","","");  //TODO
            ret.AddNvArray("boneWeights","Vec4","","");  //TODO
            ret.AddNvArray("boneNames","U8","","");    //TODO
            ret.AddNvArray("boneNameList","String","",""); //TODO
            ret.AddNvArray("bindPoses","Mat44","","");    //TODO
            ret.AddNvArray("boneParents","I32","","");  //TODO
            ret.AddNvValue("numBoneSpheres","U32",""); //TODO
            ret.AddNvArray("boneSpheres","Struct","",""); //TODO: Fix AddnVarray(); structElements??
            ret.AddNvValue("numBoneCapsules","U32",""); //TODO
            ret.AddNvArray("boneCapsuleIndices","U32","",""); //TODO
            ret.AddNvValue("numPinConstraints","U32",""); //TODO 
            ret.AddNvArray("pinConstraints","Struct","",""); //TODO: Fix AddnVarray(); structElements??
            ret.AddNvValue("sceneUnit","F32",""); //TODO 
            ret.AddNvValue("upAxis","U32",""); //TODO 
            ret.AddNvValue("handedness","U32",""); //TODO 
            return ret;
        }
    }
}
