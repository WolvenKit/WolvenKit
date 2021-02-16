using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WindowBlindersData : CVariable
	{
		[Ordinal(0)] [RED("windowBlindersState")] public CEnum<EWindowBlindersStates> WindowBlindersState { get; set; }
		[Ordinal(1)] [RED("hasOpenInteraction")] public CBool HasOpenInteraction { get; set; }
		[Ordinal(2)] [RED("hasTiltInteraction")] public CBool HasTiltInteraction { get; set; }
		[Ordinal(3)] [RED("hasQuickHack")] public CBool HasQuickHack { get; set; }

		public WindowBlindersData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
