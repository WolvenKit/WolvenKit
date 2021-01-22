using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetProficiencyLevel : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("newLevel")] public CInt32 NewLevel { get; set; }
		[Ordinal(1)]  [RED("proficiencyType")] public CEnum<gamedataProficiencyType> ProficiencyType { get; set; }
		[Ordinal(2)]  [RED("telemetryLevelGainReason")] public CEnum<telemetryLevelGainReason> TelemetryLevelGainReason { get; set; }

		public SetProficiencyLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
