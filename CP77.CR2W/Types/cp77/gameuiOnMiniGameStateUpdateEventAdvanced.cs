using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiOnMiniGameStateUpdateEventAdvanced : redEvent
	{
		[Ordinal(0)]  [RED("gameState")] public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState { get; set; }
		[Ordinal(1)]  [RED("propertyNames")] public CArray<CName> PropertyNames { get; set; }

		public gameuiOnMiniGameStateUpdateEventAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
