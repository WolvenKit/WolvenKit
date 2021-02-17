using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TagObjectEvent : redEvent
	{
		[Ordinal(0)] [RED("isTagged")] public CBool IsTagged { get; set; }

		public TagObjectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
