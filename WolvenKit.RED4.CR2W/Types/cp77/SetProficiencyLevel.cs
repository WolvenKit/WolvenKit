using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetProficiencyLevel : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("newLevel")] public CInt32 NewLevel { get; set; }
		[Ordinal(2)] [RED("proficiencyType")] public CEnum<gamedataProficiencyType> ProficiencyType { get; set; }
		[Ordinal(3)] [RED("telemetryLevelGainReason")] public CEnum<telemetryLevelGainReason> TelemetryLevelGainReason { get; set; }

		public SetProficiencyLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
