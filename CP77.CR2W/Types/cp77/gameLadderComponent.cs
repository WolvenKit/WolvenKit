using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLadderComponent : entIComponent
	{
		[Ordinal(0)]  [RED("heightOfBottomPart")] public CFloat HeightOfBottomPart { get; set; }
		[Ordinal(1)]  [RED("exitStepTop")] public CFloat ExitStepTop { get; set; }
		[Ordinal(2)]  [RED("verticalStepTop")] public CFloat VerticalStepTop { get; set; }
		[Ordinal(3)]  [RED("exitStepBottom")] public CFloat ExitStepBottom { get; set; }
		[Ordinal(4)]  [RED("verticalStepBottom")] public CFloat VerticalStepBottom { get; set; }
		[Ordinal(5)]  [RED("exitStepJump")] public CFloat ExitStepJump { get; set; }
		[Ordinal(6)]  [RED("verticalStepJump")] public CFloat VerticalStepJump { get; set; }
		[Ordinal(7)]  [RED("enterOffset")] public CFloat EnterOffset { get; set; }

		public gameLadderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
