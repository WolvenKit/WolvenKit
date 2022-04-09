using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSmoothFloatClamp : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("marginEaseOutCurve")] 
		public CLegacySingleChannelCurve<CFloat> MarginEaseOutCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public animSmoothFloatClamp()
		{
			Min = -1.000000F;
			Max = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
