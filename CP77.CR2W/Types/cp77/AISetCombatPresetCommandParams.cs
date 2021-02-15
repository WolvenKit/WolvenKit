using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AISetCombatPresetCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] [RED("combatPreset")] public CEnum<EAICombatPreset> CombatPreset { get; set; }

		public AISetCombatPresetCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
