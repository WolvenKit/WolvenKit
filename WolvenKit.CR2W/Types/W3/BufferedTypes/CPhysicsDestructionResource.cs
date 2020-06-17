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
    public class CPhysicsDestructionResource : CMesh
    {
        [RED("boneIndicesMapping", 2, 0)] public CArray<SBoneIndiceMapping> BoneIndicesMapping { get; set; }

        [RED("finalIndices", 2, 0)] public CArray<CUInt16> FinalIndices { get; set; }

        [RED("chunkNumber")] public CUInt32 ChunkNumber { get; set; }

        public CArray<SMeshBlock5> block5;

        public CPhysicsDestructionResource(CR2WFile cr2w) :
            base(cr2w)
        {

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            block5.Read(file, 46);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            block5.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CPhysicsDestructionResource(cr2w);
        }
    }
}