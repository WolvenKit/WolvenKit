using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CPhysicsDestructionResource : CMesh
	{
		[Ordinal(1)] [RED("boneIndicesMapping", 2,0)] 		public CArray<SBoneIndiceMapping> BoneIndicesMapping { get; set;}

		[Ordinal(2)] [RED("finalIndices", 2,0)] 		public CArray<CUInt16> FinalIndices { get; set;}

		[Ordinal(3)] [RED("chunkNumber")] 		public CUInt32 ChunkNumber { get; set;}

		public CPhysicsDestructionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPhysicsDestructionResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}