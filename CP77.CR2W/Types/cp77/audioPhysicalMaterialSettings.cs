using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalMaterialSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("softImpact")] public CName SoftImpact { get; set; }
		[Ordinal(2)] [RED("solidImpact")] public CName SolidImpact { get; set; }
		[Ordinal(3)] [RED("hardImpact")] public CName HardImpact { get; set; }
		[Ordinal(4)] [RED("useFoliageSystem")] public CBool UseFoliageSystem { get; set; }
		[Ordinal(5)] [RED("enableRollingOrScraping")] public CBool EnableRollingOrScraping { get; set; }
		[Ordinal(6)] [RED("scrape")] public CName Scrape { get; set; }
		[Ordinal(7)] [RED("roll")] public CName Roll { get; set; }
		[Ordinal(8)] [RED("materialHardnessOverride")] public CEnum<audioMaterialHardnessOverride> MaterialHardnessOverride { get; set; }
		[Ordinal(9)] [RED("collideOnlyOnce")] public CBool CollideOnlyOnce { get; set; }
		[Ordinal(10)] [RED("bulletImpact")] public CName BulletImpact { get; set; }
		[Ordinal(11)] [RED("bulletImpactSniper")] public CName BulletImpactSniper { get; set; }
		[Ordinal(12)] [RED("bulletImpactShotgun")] public CName BulletImpactShotgun { get; set; }
		[Ordinal(13)] [RED("bulletImpactRail")] public CName BulletImpactRail { get; set; }
		[Ordinal(14)] [RED("bulletImpactNpc")] public CName BulletImpactNpc { get; set; }
		[Ordinal(15)] [RED("bulletImpactNpcSniper")] public CName BulletImpactNpcSniper { get; set; }
		[Ordinal(16)] [RED("bulletImpactNpcAuto")] public CName BulletImpactNpcAuto { get; set; }
		[Ordinal(17)] [RED("bulletImpactNpcShotgun")] public CName BulletImpactNpcShotgun { get; set; }
		[Ordinal(18)] [RED("bulletImpactNpcRail")] public CName BulletImpactNpcRail { get; set; }

		public audioPhysicalMaterialSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
