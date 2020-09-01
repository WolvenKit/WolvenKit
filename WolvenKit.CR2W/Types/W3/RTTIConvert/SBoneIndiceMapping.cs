using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBoneIndiceMapping : CVariable
	{
		[Ordinal(1)] [RED("("startingIndex")] 		public CUInt32 StartingIndex { get; set;}

		[Ordinal(2)] [RED("("endingIndex")] 		public CUInt32 EndingIndex { get; set;}

		[Ordinal(3)] [RED("("chunkIndex")] 		public CUInt32 ChunkIndex { get; set;}

		[Ordinal(4)] [RED("("boneIndex")] 		public CUInt32 BoneIndex { get; set;}

		public SBoneIndiceMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBoneIndiceMapping(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}