using System.Xml.Linq;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Nvidia.HairWorks
{
    class HairSceneDescriptor
    {


        public string checksum = "0x299b335f 0x2cad8b54 0xcaf3c98f 0xa3094fa7";
        public XElement serialize(CFurMeshResource apexChunk)
        {
            var ret = NvidiaXML.CreateStructHeader("","Ref","HairSceneDescriptor","1.0",checksum);
            var values = new XElement("struct", new XAttribute("name", ""));
            //TODO: Check when these should be null!
            values.AddNvValue("densityTexture","String","");
            values.AddNvValue("rootColorTexture","String","");
            values.AddNvValue("tipColorTexture","String","");
            values.AddNvValue("widthTexture","String","");
            values.AddNvValue("rootWidthTexture","String","");
            values.AddNvValue("tipWidthTexture","String","");
            values.AddNvValue("stiffnessTexture","String","");
            values.AddNvValue("rootStiffnessTexture","String","");
            values.AddNvValue("clumpScaleTexture","String","");
            values.AddNvValue("clumpRoundnessTexture","String","");
            values.AddNvValue("clumpNoiseTexture","String","");
            values.AddNvValue("waveScaletexture","String","");
            values.AddNvValue("waveFreqTexture","String","");
            values.AddNvValue("strandTexture","String","");
            values.AddNvValue("lengthTexture","String","");
            values.AddNvValue("specularTexture","String","");
            ret.Add(values);
            return ret;
        }
    }
}
