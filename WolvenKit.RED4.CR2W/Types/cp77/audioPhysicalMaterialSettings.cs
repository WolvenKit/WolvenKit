using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPhysicalMaterialSettings : audioAudioMetadata
	{
		private CName _softImpact;
		private CName _solidImpact;
		private CName _hardImpact;
		private CBool _useFoliageSystem;
		private CBool _enableRollingOrScraping;
		private CName _scrape;
		private CName _roll;
		private CEnum<audioMaterialHardnessOverride> _materialHardnessOverride;
		private CBool _collideOnlyOnce;
		private CName _bulletImpact;
		private CName _bulletImpactSniper;
		private CName _bulletImpactShotgun;
		private CName _bulletImpactRail;
		private CName _bulletImpactNpc;
		private CName _bulletImpactNpcSniper;
		private CName _bulletImpactNpcAuto;
		private CName _bulletImpactNpcShotgun;
		private CName _bulletImpactNpcRail;

		[Ordinal(1)] 
		[RED("softImpact")] 
		public CName SoftImpact
		{
			get => GetProperty(ref _softImpact);
			set => SetProperty(ref _softImpact, value);
		}

		[Ordinal(2)] 
		[RED("solidImpact")] 
		public CName SolidImpact
		{
			get => GetProperty(ref _solidImpact);
			set => SetProperty(ref _solidImpact, value);
		}

		[Ordinal(3)] 
		[RED("hardImpact")] 
		public CName HardImpact
		{
			get => GetProperty(ref _hardImpact);
			set => SetProperty(ref _hardImpact, value);
		}

		[Ordinal(4)] 
		[RED("useFoliageSystem")] 
		public CBool UseFoliageSystem
		{
			get => GetProperty(ref _useFoliageSystem);
			set => SetProperty(ref _useFoliageSystem, value);
		}

		[Ordinal(5)] 
		[RED("enableRollingOrScraping")] 
		public CBool EnableRollingOrScraping
		{
			get => GetProperty(ref _enableRollingOrScraping);
			set => SetProperty(ref _enableRollingOrScraping, value);
		}

		[Ordinal(6)] 
		[RED("scrape")] 
		public CName Scrape
		{
			get => GetProperty(ref _scrape);
			set => SetProperty(ref _scrape, value);
		}

		[Ordinal(7)] 
		[RED("roll")] 
		public CName Roll
		{
			get => GetProperty(ref _roll);
			set => SetProperty(ref _roll, value);
		}

		[Ordinal(8)] 
		[RED("materialHardnessOverride")] 
		public CEnum<audioMaterialHardnessOverride> MaterialHardnessOverride
		{
			get => GetProperty(ref _materialHardnessOverride);
			set => SetProperty(ref _materialHardnessOverride, value);
		}

		[Ordinal(9)] 
		[RED("collideOnlyOnce")] 
		public CBool CollideOnlyOnce
		{
			get => GetProperty(ref _collideOnlyOnce);
			set => SetProperty(ref _collideOnlyOnce, value);
		}

		[Ordinal(10)] 
		[RED("bulletImpact")] 
		public CName BulletImpact
		{
			get => GetProperty(ref _bulletImpact);
			set => SetProperty(ref _bulletImpact, value);
		}

		[Ordinal(11)] 
		[RED("bulletImpactSniper")] 
		public CName BulletImpactSniper
		{
			get => GetProperty(ref _bulletImpactSniper);
			set => SetProperty(ref _bulletImpactSniper, value);
		}

		[Ordinal(12)] 
		[RED("bulletImpactShotgun")] 
		public CName BulletImpactShotgun
		{
			get => GetProperty(ref _bulletImpactShotgun);
			set => SetProperty(ref _bulletImpactShotgun, value);
		}

		[Ordinal(13)] 
		[RED("bulletImpactRail")] 
		public CName BulletImpactRail
		{
			get => GetProperty(ref _bulletImpactRail);
			set => SetProperty(ref _bulletImpactRail, value);
		}

		[Ordinal(14)] 
		[RED("bulletImpactNpc")] 
		public CName BulletImpactNpc
		{
			get => GetProperty(ref _bulletImpactNpc);
			set => SetProperty(ref _bulletImpactNpc, value);
		}

		[Ordinal(15)] 
		[RED("bulletImpactNpcSniper")] 
		public CName BulletImpactNpcSniper
		{
			get => GetProperty(ref _bulletImpactNpcSniper);
			set => SetProperty(ref _bulletImpactNpcSniper, value);
		}

		[Ordinal(16)] 
		[RED("bulletImpactNpcAuto")] 
		public CName BulletImpactNpcAuto
		{
			get => GetProperty(ref _bulletImpactNpcAuto);
			set => SetProperty(ref _bulletImpactNpcAuto, value);
		}

		[Ordinal(17)] 
		[RED("bulletImpactNpcShotgun")] 
		public CName BulletImpactNpcShotgun
		{
			get => GetProperty(ref _bulletImpactNpcShotgun);
			set => SetProperty(ref _bulletImpactNpcShotgun, value);
		}

		[Ordinal(18)] 
		[RED("bulletImpactNpcRail")] 
		public CName BulletImpactNpcRail
		{
			get => GetProperty(ref _bulletImpactNpcRail);
			set => SetProperty(ref _bulletImpactNpcRail, value);
		}

		public audioPhysicalMaterialSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
