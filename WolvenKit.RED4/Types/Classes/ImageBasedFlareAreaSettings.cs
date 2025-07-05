using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ImageBasedFlareAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("treshold")] 
		public CFloat Treshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("dispersal")] 
		public CFloat Dispersal
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("haloWidth")] 
		public CFloat HaloWidth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("distortion")] 
		public CFloat Distortion
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("curve")] 
		public CFloat Curve
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("tint", 8)] 
		public CArrayFixedSize<CColor> Tint
		{
			get => GetPropertyValue<CArrayFixedSize<CColor>>();
			set => SetPropertyValue<CArrayFixedSize<CColor>>(value);
		}

		[Ordinal(8)] 
		[RED("scale")] 
		public CLegacySingleChannelCurve<CFloat> Scale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("saturation")] 
		public CLegacySingleChannelCurve<CFloat> Saturation
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public ImageBasedFlareAreaSettings()
		{
			Enable = true;
			Treshold = 2.000000F;
			Dispersal = 0.300000F;
			HaloWidth = 0.550000F;
			Distortion = 1.000000F;
			Curve = 1.000000F;
			Tint = new(8);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
