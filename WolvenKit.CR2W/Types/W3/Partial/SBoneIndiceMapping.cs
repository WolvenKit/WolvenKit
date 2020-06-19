using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta(EREDMetaInfo.REDStruct)]
	public class SBoneIndiceMapping : CVariable
	{
		[RED("startingIndex")] 		public CUInt32 StartingIndex { get; set;}

		[RED("endingIndex")] 		public CUInt32 EndingIndex { get; set;}

		[RED("chunkIndex")] 		public CUInt32 ChunkIndex { get; set;}

		[RED("boneIndex")] 		public CUInt32 BoneIndex { get; set;}

		public SBoneIndiceMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBoneIndiceMapping(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}