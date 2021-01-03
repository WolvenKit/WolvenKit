using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerPuppetPS : ScriptedPuppetPS
	{
		[Ordinal(0)]  [RED("availablePrograms")] public CArray<gameuiMinigameProgramData> AvailablePrograms { get; set; }
		[Ordinal(1)]  [RED("hasAutoReveal")] public CBool HasAutoReveal { get; set; }
		[Ordinal(2)]  [RED("keybindigs")] public KeyBindings Keybindigs { get; set; }
		[Ordinal(3)]  [RED("minigameBB")] public CHandle<gameIBlackboard> MinigameBB { get; set; }

		public PlayerPuppetPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
