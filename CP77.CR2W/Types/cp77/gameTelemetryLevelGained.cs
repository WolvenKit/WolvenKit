using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryLevelGained : CVariable
	{
		[Ordinal(0)] [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(1)] [RED("proficiencyType")] public CEnum<gamedataProficiencyType> ProficiencyType { get; set; }
		[Ordinal(2)] [RED("proficiencyValue")] public CInt32 ProficiencyValue { get; set; }
		[Ordinal(3)] [RED("perkPointsAwarded")] public CInt32 PerkPointsAwarded { get; set; }
		[Ordinal(4)] [RED("attributePointsAwarded")] public CInt32 AttributePointsAwarded { get; set; }
		[Ordinal(5)] [RED("isDebugEvt")] public CBool IsDebugEvt { get; set; }

		public gameTelemetryLevelGained(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
