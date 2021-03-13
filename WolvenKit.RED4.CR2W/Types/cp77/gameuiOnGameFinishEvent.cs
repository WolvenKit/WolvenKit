using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOnGameFinishEvent : redEvent
	{
		[Ordinal(0)] [RED("gameState")] public CHandle<gameuiMinigameState> GameState { get; set; }
		[Ordinal(1)] [RED("gameName")] public CName GameName { get; set; }

		public gameuiOnGameFinishEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
