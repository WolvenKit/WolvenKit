using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkPointCloudEffect : inkIEffect
	{
		[Ordinal(2)] 
		[RED("repeat")] 
		public CFloat Repeat
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("offsetX")] 
		public CFloat OffsetX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("offsetY")] 
		public CFloat OffsetY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("fovScale")] 
		public CFloat FovScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("parallaxDepth")] 
		public CFloat ParallaxDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("depthToOpacity")] 
		public CFloat DepthToOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("depthToBrightness")] 
		public CFloat DepthToBrightness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkPointCloudEffect()
		{
			Repeat = 1.000000F;
			FovScale = 3.000000F;
			ParallaxDepth = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
