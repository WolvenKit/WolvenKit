using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalMaterialSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("bulletImpact")] public CName BulletImpact { get; set; }
		[Ordinal(1)]  [RED("bulletImpactNpc")] public CName BulletImpactNpc { get; set; }
		[Ordinal(2)]  [RED("bulletImpactNpcAuto")] public CName BulletImpactNpcAuto { get; set; }
		[Ordinal(3)]  [RED("bulletImpactNpcRail")] public CName BulletImpactNpcRail { get; set; }
		[Ordinal(4)]  [RED("bulletImpactNpcShotgun")] public CName BulletImpactNpcShotgun { get; set; }
		[Ordinal(5)]  [RED("bulletImpactNpcSniper")] public CName BulletImpactNpcSniper { get; set; }
		[Ordinal(6)]  [RED("bulletImpactRail")] public CName BulletImpactRail { get; set; }
		[Ordinal(7)]  [RED("bulletImpactShotgun")] public CName BulletImpactShotgun { get; set; }
		[Ordinal(8)]  [RED("bulletImpactSniper")] public CName BulletImpactSniper { get; set; }
		[Ordinal(9)]  [RED("collideOnlyOnce")] public CBool CollideOnlyOnce { get; set; }
		[Ordinal(10)]  [RED("enableRollingOrScraping")] public CBool EnableRollingOrScraping { get; set; }
		[Ordinal(11)]  [RED("hardImpact")] public CName HardImpact { get; set; }
		[Ordinal(12)]  [RED("materialHardnessOverride")] public CEnum<audioMaterialHardnessOverride> MaterialHardnessOverride { get; set; }
		[Ordinal(13)]  [RED("roll")] public CName Roll { get; set; }
		[Ordinal(14)]  [RED("scrape")] public CName Scrape { get; set; }
		[Ordinal(15)]  [RED("softImpact")] public CName SoftImpact { get; set; }
		[Ordinal(16)]  [RED("solidImpact")] public CName SolidImpact { get; set; }
		[Ordinal(17)]  [RED("useFoliageSystem")] public CBool UseFoliageSystem { get; set; }

		public audioPhysicalMaterialSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
