using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevealQuestTargetEvent : redEvent
	{
		[Ordinal(0)] [RED("sourceName")] public CName SourceName { get; set; }
		[Ordinal(1)] [RED("durationType")] public CEnum<ERevealDurationType> DurationType { get; set; }
		[Ordinal(2)] [RED("reveal")] public CBool Reveal { get; set; }
		[Ordinal(3)] [RED("timeout")] public CFloat Timeout { get; set; }

		public RevealQuestTargetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
