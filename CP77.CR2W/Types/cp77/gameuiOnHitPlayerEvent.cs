using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiOnHitPlayerEvent : redEvent
	{
		[Ordinal(0)]  [RED("gameState")] public CHandle<gameuiMinigameState> GameState { get; set; }

		public gameuiOnHitPlayerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
