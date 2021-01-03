using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RevealQuestTargetEvent : redEvent
	{
		[Ordinal(0)]  [RED("durationType")] public CEnum<ERevealDurationType> DurationType { get; set; }
		[Ordinal(1)]  [RED("reveal")] public CBool Reveal { get; set; }
		[Ordinal(2)]  [RED("sourceName")] public CName SourceName { get; set; }
		[Ordinal(3)]  [RED("timeout")] public CFloat Timeout { get; set; }

		public RevealQuestTargetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
