using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeEvent : redEvent
	{
		[Ordinal(0)] [RED("activated")] public CBool Activated { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<gameVisionModeType> Type { get; set; }

		public gameVisionModeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
