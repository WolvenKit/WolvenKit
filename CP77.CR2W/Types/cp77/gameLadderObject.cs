using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLadderObject : gameObject
	{
		[Ordinal(31)]  [RED("heightOfBottomPart")] public CFloat HeightOfBottomPart { get; set; }
		[Ordinal(32)]  [RED("exitStepTop")] public CFloat ExitStepTop { get; set; }
		[Ordinal(33)]  [RED("verticalStepTop")] public CFloat VerticalStepTop { get; set; }
		[Ordinal(34)]  [RED("exitStepBottom")] public CFloat ExitStepBottom { get; set; }
		[Ordinal(35)]  [RED("verticalStepBottom")] public CFloat VerticalStepBottom { get; set; }
		[Ordinal(36)]  [RED("exitStepJump")] public CFloat ExitStepJump { get; set; }
		[Ordinal(37)]  [RED("verticalStepJump")] public CFloat VerticalStepJump { get; set; }
		[Ordinal(38)]  [RED("enterOffset")] public CFloat EnterOffset { get; set; }

		public gameLadderObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
