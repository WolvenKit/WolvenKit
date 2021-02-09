using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerPuppetPS : ScriptedPuppetPS
	{
		[Ordinal(22)]  [RED("keybindigs")] public KeyBindings Keybindigs { get; set; }
		[Ordinal(23)]  [RED("availablePrograms")] public CArray<gameuiMinigameProgramData> AvailablePrograms { get; set; }
		[Ordinal(24)]  [RED("hasAutoReveal")] public CBool HasAutoReveal { get; set; }
		[Ordinal(25)]  [RED("minigameBB")] public CHandle<gameIBlackboard> MinigameBB { get; set; }

		public PlayerPuppetPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
