using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_WorkspotPlayFacialAnim : animAnimEvent
	{
		[Ordinal(3)] [RED("facialAnimName")] public CName FacialAnimName { get; set; }

		public animAnimEvent_WorkspotPlayFacialAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
