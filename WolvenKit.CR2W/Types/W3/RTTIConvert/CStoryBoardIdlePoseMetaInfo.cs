using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStoryBoardIdlePoseMetaInfo : CObject
	{
		[Ordinal(1)] [RED("("idlePoseList", 2,0)] 		public CArray<SStoryBoardIdlePoseInfo> IdlePoseList { get; set;}

		[Ordinal(2)] [RED("("defaultPoseList", 2,0)] 		public CArray<SStoryBoardDefaultPoseInfo> DefaultPoseList { get; set;}

		public CStoryBoardIdlePoseMetaInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStoryBoardIdlePoseMetaInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}