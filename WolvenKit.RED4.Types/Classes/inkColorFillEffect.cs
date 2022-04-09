using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkColorFillEffect : inkIEffect
	{
		[Ordinal(2)] 
		[RED("colorR")] 
		public CFloat ColorR
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("colorG")] 
		public CFloat ColorG
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("colorB")] 
		public CFloat ColorB
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("colorA")] 
		public CFloat ColorA
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("saturation")] 
		public CFloat Saturation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkColorFillEffect()
		{
			ColorR = 255.000000F;
			ColorG = 255.000000F;
			ColorB = 255.000000F;
			ColorA = 255.000000F;
			Saturation = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
