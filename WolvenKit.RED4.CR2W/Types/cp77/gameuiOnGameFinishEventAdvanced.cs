using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOnGameFinishEventAdvanced : redEvent
	{
		[Ordinal(0)] [RED("gameState")] public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState { get; set; }

		public gameuiOnGameFinishEventAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
