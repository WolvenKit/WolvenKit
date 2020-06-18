using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CFoliageResource : CResource
    {
        [RED("bbox")] public Box Bbox { get; set; }

        [RED("gridbbox")] public Box Gridbbox { get; set; }

        [RED("version")] public CUInt32 Version { get; set; }

        [REDBuffer] public CBufferVLQInt32<SFoliageResourceData> Trees { get; set; }

        [REDBuffer] public CBufferVLQInt32<SFoliageResourceData> Grasses { get; set; }

        public CFoliageResource(CR2WFile cr2w) : base(cr2w)
        {

        }


        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CFoliageResource(cr2w);
        }

        


    }


    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SFoliageResourceData : CVariable
    {

        [RED] public CHandle<CSRTBaseTree> Treetype { get; set; }
        [RED] public CBufferVLQInt32<SFoliageInstanceData> TreeCollection { get; set; }

        public SFoliageResourceData(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override CVariable Create(CR2WFile cr2w) => new SFoliageResourceData(cr2w);
    }

    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SFoliageInstanceData : CVariable
    {
        [RED] public CFloat PositionX { get; set; }
        [RED] public CFloat PositionY { get; set; }
        [RED] public CFloat PositionZ { get; set; }
        [RED] public CFloat Yaw { get; set; }
        [RED] public CFloat Pitch { get; set; }
        [RED] public CFloat Roll { get; set; }

        public SFoliageInstanceData(CR2WFile cr2w) : base(cr2w)
        {

        }

        public override CVariable Create(CR2WFile cr2w) => new SFoliageInstanceData(cr2w);
    }
}