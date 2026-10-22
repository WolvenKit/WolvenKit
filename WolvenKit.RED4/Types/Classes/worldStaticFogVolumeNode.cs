using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticFogVolumeNode : worldNode
	{
		[Ordinal(2)] 
		[RED("priority")] 
		public CUInt8 Priority
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("absolute")] 
		public CBool Absolute
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("applyHeightFalloff")] 
		public CBool ApplyHeightFalloff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("densityFalloff")] 
		public CFloat DensityFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("blendFalloff")] 
		public CFloat BlendFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("densityFactor")] 
		public CFloat DensityFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("absorption")] 
		public CFloat Absorption
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("ambientScale")] 
		public CFloat AmbientScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("envColorGroup")] 
		public CEnum<EEnvColorGroup> EnvColorGroup
		{
			get => GetPropertyValue<CEnum<EEnvColorGroup>>();
			set => SetPropertyValue<CEnum<EEnvColorGroup>>(value);
		}

		[Ordinal(12)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(13)] 
		[RED("lightChannels")] 
		public CBitField<rendLightChannel> LightChannels
		{
			get => GetPropertyValue<CBitField<rendLightChannel>>();
			set => SetPropertyValue<CBitField<rendLightChannel>>(value);
		}

		public worldStaticFogVolumeNode()
		{
			Priority = 5;
			ApplyHeightFalloff = true;
			DensityFactor = 100.000000F;
			Absorption = -1.000000F;
			StreamingDistance = 1000.000000F;
			AmbientScale = 1.000000F;
			Color = new CColor { Red = 255, Green = 255, Blue = 255, Alpha = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
