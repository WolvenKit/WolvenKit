using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFlatheadSetSoloModeCommand : AIFollowerCommand
	{
		[Ordinal(0)]  [RED("combatCommand")] public CBool CombatCommand { get; set; }
		[Ordinal(1)]  [RED("soloModeState")] public CBool SoloModeState { get; set; }

		public AIFlatheadSetSoloModeCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
