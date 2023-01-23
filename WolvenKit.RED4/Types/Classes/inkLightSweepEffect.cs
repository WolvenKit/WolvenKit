using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLightSweepEffect : inkIEffect
	{
		[Ordinal(2)] 
		[RED("positionX")] 
		public CFloat PositionX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("positionY")] 
		public CFloat PositionY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkLightSweepEffect()
		{
			PositionX = 0.500000F;
			PositionY = 0.500000F;
			Width = 0.300000F;
			Intensity = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
