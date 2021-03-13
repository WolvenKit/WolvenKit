using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOnMiniGameStateUpdateEventAdvanced : redEvent
	{
		[Ordinal(0)] [RED("gameState")] public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState { get; set; }
		[Ordinal(1)] [RED("propertyNames")] public CArray<CName> PropertyNames { get; set; }

		public gameuiOnMiniGameStateUpdateEventAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
