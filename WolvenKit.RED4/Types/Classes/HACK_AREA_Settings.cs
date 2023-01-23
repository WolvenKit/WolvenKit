using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HACK_AREA_Settings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("surfelScale")] 
		public CFloat SurfelScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("missingEnergyScale")] 
		public CFloat MissingEnergyScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("overrideOnPureView")] 
		public CBool OverrideOnPureView
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("surfAlbedoOverrideRatio")] 
		public CFloat SurfAlbedoOverrideRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("surfAlbedoOverride")] 
		public HDRColor SurfAlbedoOverride
		{
			get => GetPropertyValue<HDRColor>();
			set => SetPropertyValue<HDRColor>(value);
		}

		[Ordinal(7)] 
		[RED("skyScale")] 
		public CFloat SkyScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("bottomHemisphereTint")] 
		public CLegacySingleChannelCurve<HDRColor> BottomHemisphereTint
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(9)] 
		[RED("bottomHemisphereStrength")] 
		public CFloat BottomHemisphereStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("emissiveScale")] 
		public CFloat EmissiveScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("albedoMetalness")] 
		public CFloat AlbedoMetalness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public HACK_AREA_Settings()
		{
			Enable = true;
			SurfelScale = 1.000000F;
			MissingEnergyScale = 1.000000F;
			OverrideOnPureView = true;
			SurfAlbedoOverride = new() { Red = 1.000000F, Green = 1.000000F, Blue = 1.000000F, Alpha = 1.000000F };
			SkyScale = 1.000000F;
			EmissiveScale = 1.000000F;
			AlbedoMetalness = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
