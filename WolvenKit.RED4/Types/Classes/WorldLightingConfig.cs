using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WorldLightingConfig : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lightAttenuationClamp")] 
		public CFloat LightAttenuationClamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public WorldLightingConfig()
		{
			LightAttenuationClamp = 96.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
