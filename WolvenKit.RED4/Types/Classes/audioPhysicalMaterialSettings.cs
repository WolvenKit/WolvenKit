using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioPhysicalMaterialSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("softImpact")] 
		public CName SoftImpact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("solidImpact")] 
		public CName SolidImpact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("hardImpact")] 
		public CName HardImpact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("useFoliageSystem")] 
		public CBool UseFoliageSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("enableRollingOrScraping")] 
		public CBool EnableRollingOrScraping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("scrape")] 
		public CName Scrape
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("roll")] 
		public CName Roll
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("materialHardnessOverride")] 
		public CEnum<audioMaterialHardnessOverride> MaterialHardnessOverride
		{
			get => GetPropertyValue<CEnum<audioMaterialHardnessOverride>>();
			set => SetPropertyValue<CEnum<audioMaterialHardnessOverride>>(value);
		}

		[Ordinal(9)] 
		[RED("collideOnlyOnce")] 
		public CBool CollideOnlyOnce
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("bulletImpact")] 
		public CName BulletImpact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("bulletImpactSniper")] 
		public CName BulletImpactSniper
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("bulletImpactShotgun")] 
		public CName BulletImpactShotgun
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("bulletImpactRail")] 
		public CName BulletImpactRail
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("bulletImpactNpc")] 
		public CName BulletImpactNpc
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("bulletImpactNpcSniper")] 
		public CName BulletImpactNpcSniper
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("bulletImpactNpcAuto")] 
		public CName BulletImpactNpcAuto
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("bulletImpactNpcShotgun")] 
		public CName BulletImpactNpcShotgun
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("bulletImpactNpcRail")] 
		public CName BulletImpactNpcRail
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioPhysicalMaterialSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
