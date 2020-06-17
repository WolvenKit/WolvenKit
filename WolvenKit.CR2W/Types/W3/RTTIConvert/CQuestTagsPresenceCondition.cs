using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestTagsPresenceCondition : IQuestCondition
	{
		[RED("tags")] 		public TagList Tags { get; set;}

		[RED("all")] 		public CBool All { get; set;}

		[RED("howMany")] 		public CUInt32 HowMany { get; set;}

		[RED("includeStubs")] 		public CBool IncludeStubs { get; set;}

		public CQuestTagsPresenceCondition(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestTagsPresenceCondition(cr2w);

	}
}