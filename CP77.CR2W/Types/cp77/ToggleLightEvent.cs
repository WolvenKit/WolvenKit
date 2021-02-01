using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleLightEvent : redEvent
	{
		[Ordinal(0)]  [RED("loop")] public CBool Loop { get; set; }
		[Ordinal(1)]  [RED("toggle")] public CBool Toggle { get; set; }

		public ToggleLightEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
