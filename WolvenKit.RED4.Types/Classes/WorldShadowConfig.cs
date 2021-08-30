using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldShadowConfig : RedBaseClass
	{
		private ContactShadowsConfig _contactShadows;
		private CUInt32 _distantShadowsNumLevels;
		private CFloat _distantShadowsBaseLevelRadius;
		private FoliageShadowConfig _foliageShadowConfig;

		[Ordinal(0)] 
		[RED("contactShadows")] 
		public ContactShadowsConfig ContactShadows
		{
			get => GetProperty(ref _contactShadows);
			set => SetProperty(ref _contactShadows, value);
		}

		[Ordinal(1)] 
		[RED("distantShadowsNumLevels")] 
		public CUInt32 DistantShadowsNumLevels
		{
			get => GetProperty(ref _distantShadowsNumLevels);
			set => SetProperty(ref _distantShadowsNumLevels, value);
		}

		[Ordinal(2)] 
		[RED("distantShadowsBaseLevelRadius")] 
		public CFloat DistantShadowsBaseLevelRadius
		{
			get => GetProperty(ref _distantShadowsBaseLevelRadius);
			set => SetProperty(ref _distantShadowsBaseLevelRadius, value);
		}

		[Ordinal(3)] 
		[RED("foliageShadowConfig")] 
		public FoliageShadowConfig FoliageShadowConfig
		{
			get => GetProperty(ref _foliageShadowConfig);
			set => SetProperty(ref _foliageShadowConfig, value);
		}

		public WorldShadowConfig()
		{
			_distantShadowsNumLevels = 3;
			_distantShadowsBaseLevelRadius = 250.000000F;
		}
	}
}
