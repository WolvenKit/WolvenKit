using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeHideEvent : redEvent
	{
		[Ordinal(0)] [RED("hide")] public CBool Hide { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<gameVisionModeType> Type { get; set; }

		public gameVisionModeHideEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
