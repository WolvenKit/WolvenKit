using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerBonus : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(1)] [RED("fallingSpeed")] public CFloat FallingSpeed { get; set; }

		public gameuiPanzerBonus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
