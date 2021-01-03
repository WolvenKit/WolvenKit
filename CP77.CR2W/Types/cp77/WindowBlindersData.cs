using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WindowBlindersData : CVariable
	{
		[Ordinal(0)]  [RED("hasOpenInteraction")] public CBool HasOpenInteraction { get; set; }
		[Ordinal(1)]  [RED("hasQuickHack")] public CBool HasQuickHack { get; set; }
		[Ordinal(2)]  [RED("hasTiltInteraction")] public CBool HasTiltInteraction { get; set; }
		[Ordinal(3)]  [RED("windowBlindersState")] public CEnum<EWindowBlindersStates> WindowBlindersState { get; set; }

		public WindowBlindersData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
