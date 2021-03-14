using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMappinsContainerController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] [RED("psmVision")] public CEnum<gamePSMVision> PsmVision { get; set; }
		[Ordinal(10)] [RED("psmCombat")] public CEnum<gamePSMCombat> PsmCombat { get; set; }
		[Ordinal(11)] [RED("psmZone")] public CEnum<gamePSMZones> PsmZone { get; set; }
		[Ordinal(12)] [RED("tier")] public CEnum<GameplayTier> Tier { get; set; }
		[Ordinal(13)] [RED("spawnContainerPath")] public inkWidgetPath SpawnContainerPath { get; set; }
		[Ordinal(14)] [RED("gpsQuestPathWidget")] public inkLinePatternWidgetReference GpsQuestPathWidget { get; set; }
		[Ordinal(15)] [RED("gpsPlayerTrackedPathWidget")] public inkLinePatternWidgetReference GpsPlayerTrackedPathWidget { get; set; }

		public gameuiMappinsContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
