using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatTimeDependentSinus : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("frequencyFactor")] 
		public CFloat FrequencyFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("phaseFactor")] 
		public CFloat PhaseFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimNode_FloatTimeDependentSinus()
		{
			Id = uint.MaxValue;
			Min = -1.000000F;
			Max = 1.000000F;
			FrequencyFactor = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
