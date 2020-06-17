
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDComplex)]
    public class SBoneIndiceMapping : CVariable
    {
        [RED] public CUInt32 StartingIndex { get; set; }
        [RED] public CUInt32 EndingIndex { get; set; }
        [RED] public CUInt32 ChunkIndex { get; set; }
        [RED] public CUInt32 BoneIndex { get; set; }

        public SBoneIndiceMapping(CR2WFile cr2w) : base(cr2w) { }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w) => new SBoneIndiceMapping(cr2w);
    }
}
