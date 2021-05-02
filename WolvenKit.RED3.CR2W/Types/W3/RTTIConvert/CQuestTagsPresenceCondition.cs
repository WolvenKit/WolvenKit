using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestTagsPresenceCondition : IQuestCondition
	{
		[Ordinal(1)] [RED("tags")] 		public TagList Tags { get; set;}

		[Ordinal(2)] [RED("all")] 		public CBool All { get; set;}

		[Ordinal(3)] [RED("howMany")] 		public CUInt32 HowMany { get; set;}

		[Ordinal(4)] [RED("includeStubs")] 		public CBool IncludeStubs { get; set;}

		public CQuestTagsPresenceCondition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CQuestTagsPresenceCondition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}