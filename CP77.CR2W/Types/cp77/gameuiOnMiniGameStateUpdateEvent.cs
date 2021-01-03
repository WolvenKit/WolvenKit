using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiOnMiniGameStateUpdateEvent : redEvent
	{
		[Ordinal(0)]  [RED("gameName")] public CName GameName { get; set; }
		[Ordinal(1)]  [RED("gameState")] public CHandle<gameuiMinigameState> GameState { get; set; }

		public gameuiOnMiniGameStateUpdateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
