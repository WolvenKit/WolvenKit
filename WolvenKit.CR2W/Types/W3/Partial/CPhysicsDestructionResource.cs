using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CPhysicsDestructionResource : CMesh
	{
		[RED("boneIndicesMapping", 2,0)] 		public CArray<SBoneIndiceMapping> BoneIndicesMapping { get; set;}

		[RED("finalIndices", 2,0)] 		public CArray<CUInt16> FinalIndices { get; set;}

		[RED("chunkNumber")] 		public CUInt32 ChunkNumber { get; set;}

		public CPhysicsDestructionResource(CR2WFile cr2w) : base(cr2w){ }

		public override CVariable Create(CR2WFile cr2w) => new CPhysicsDestructionResource(cr2w);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}