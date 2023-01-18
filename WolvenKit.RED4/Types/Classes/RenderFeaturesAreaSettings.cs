using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RenderFeaturesAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("allowGlobalIllumination")] 
		public CBool AllowGlobalIllumination
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("allowScreenSpaceReflections")] 
		public CBool AllowScreenSpaceReflections
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("allowVolumetricFog")] 
		public CBool AllowVolumetricFog
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RenderFeaturesAreaSettings()
		{
			Enable = true;
			AllowGlobalIllumination = true;
			AllowScreenSpaceReflections = true;
			AllowVolumetricFog = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
