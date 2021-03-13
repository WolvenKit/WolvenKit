using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsUserEnteredCoverEvent : redEvent
	{
		[Ordinal(0)] [RED("actionsPoints")] public CArray<WorldTransform> ActionsPoints { get; set; }

		public gameeventsUserEnteredCoverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
