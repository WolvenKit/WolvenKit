using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WorldShadowConfig : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("contactShadows")] 
		public ContactShadowsConfig ContactShadows
		{
			get => GetPropertyValue<ContactShadowsConfig>();
			set => SetPropertyValue<ContactShadowsConfig>(value);
		}

		[Ordinal(1)] 
		[RED("distantShadowsNumLevels")] 
		public CUInt32 DistantShadowsNumLevels
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("distantShadowsBaseLevelRadius")] 
		public CFloat DistantShadowsBaseLevelRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("foliageShadowConfig")] 
		public FoliageShadowConfig FoliageShadowConfig
		{
			get => GetPropertyValue<FoliageShadowConfig>();
			set => SetPropertyValue<FoliageShadowConfig>(value);
		}

		public WorldShadowConfig()
		{
			ContactShadows = new ContactShadowsConfig();
			DistantShadowsNumLevels = 3;
			DistantShadowsBaseLevelRadius = 250.000000F;
			FoliageShadowConfig = new FoliageShadowConfig();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
