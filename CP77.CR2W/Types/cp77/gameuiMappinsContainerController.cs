using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMappinsContainerController : gameuiProjectedHUDGameController
	{
		[Ordinal(0)]  [RED("gpsPlayerTrackedPathWidget")] public inkLinePatternWidgetReference GpsPlayerTrackedPathWidget { get; set; }
		[Ordinal(1)]  [RED("gpsQuestPathWidget")] public inkLinePatternWidgetReference GpsQuestPathWidget { get; set; }
		[Ordinal(2)]  [RED("psmCombat")] public CEnum<gamePSMCombat> PsmCombat { get; set; }
		[Ordinal(3)]  [RED("psmVision")] public CEnum<gamePSMVision> PsmVision { get; set; }
		[Ordinal(4)]  [RED("psmZone")] public CEnum<gamePSMZones> PsmZone { get; set; }
		[Ordinal(5)]  [RED("spawnContainerPath")] public inkWidgetPath SpawnContainerPath { get; set; }
		[Ordinal(6)]  [RED("tier")] public CEnum<GameplayTier> Tier { get; set; }

		public gameuiMappinsContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
