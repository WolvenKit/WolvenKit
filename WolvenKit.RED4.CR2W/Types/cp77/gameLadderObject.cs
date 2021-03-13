using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLadderObject : gameObject
	{
		[Ordinal(40)] [RED("heightOfBottomPart")] public CFloat HeightOfBottomPart { get; set; }
		[Ordinal(41)] [RED("exitStepTop")] public CFloat ExitStepTop { get; set; }
		[Ordinal(42)] [RED("verticalStepTop")] public CFloat VerticalStepTop { get; set; }
		[Ordinal(43)] [RED("exitStepBottom")] public CFloat ExitStepBottom { get; set; }
		[Ordinal(44)] [RED("verticalStepBottom")] public CFloat VerticalStepBottom { get; set; }
		[Ordinal(45)] [RED("exitStepJump")] public CFloat ExitStepJump { get; set; }
		[Ordinal(46)] [RED("verticalStepJump")] public CFloat VerticalStepJump { get; set; }
		[Ordinal(47)] [RED("enterOffset")] public CFloat EnterOffset { get; set; }

		public gameLadderObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
