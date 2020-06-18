using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CUmbraScene : CResource
    {
        [RED("distanceMultiplier")] public CFloat DistanceMultiplier { get; set; }

        [RED("localUmbraOccThresholdMul")] public CHandle<CResourceSimplexTree> LocalUmbraOccThresholdMul { get; set; }

        [REDBuffer] public CUInt32 Unk1 { get; set; }
        [REDBuffer] public CFloat Unk2 { get; set; }

        [REDBuffer] public CBufferUInt32<SUmbraSceneData> tiles { get; set; }
            
        public CUmbraScene(CR2WFile cr2w) :
            base(cr2w)
        {
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUmbraScene(cr2w);
        }
    }
}