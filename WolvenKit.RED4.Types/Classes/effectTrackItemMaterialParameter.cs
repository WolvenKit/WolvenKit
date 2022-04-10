using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectTrackItemMaterialParameter : effectTrackItem
	{
		[Ordinal(3)] 
		[RED("scale0")] 
		public CFloat Scale0
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("customParameter0")] 
		public effectEffectParameterEvaluator CustomParameter0
		{
			get => GetPropertyValue<effectEffectParameterEvaluator>();
			set => SetPropertyValue<effectEffectParameterEvaluator>(value);
		}

		[Ordinal(5)] 
		[RED("scale1")] 
		public CFloat Scale1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("customParameter1")] 
		public effectEffectParameterEvaluator CustomParameter1
		{
			get => GetPropertyValue<effectEffectParameterEvaluator>();
			set => SetPropertyValue<effectEffectParameterEvaluator>(value);
		}

		[Ordinal(7)] 
		[RED("scale2")] 
		public CFloat Scale2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("customParameter2")] 
		public effectEffectParameterEvaluator CustomParameter2
		{
			get => GetPropertyValue<effectEffectParameterEvaluator>();
			set => SetPropertyValue<effectEffectParameterEvaluator>(value);
		}

		[Ordinal(9)] 
		[RED("scale3")] 
		public CFloat Scale3
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("customParameter3")] 
		public effectEffectParameterEvaluator CustomParameter3
		{
			get => GetPropertyValue<effectEffectParameterEvaluator>();
			set => SetPropertyValue<effectEffectParameterEvaluator>(value);
		}

		public effectTrackItemMaterialParameter()
		{
			TimeDuration = 1.000000F;
			Scale0 = 1.000000F;
			CustomParameter0 = new();
			Scale1 = 1.000000F;
			CustomParameter1 = new();
			Scale2 = 1.000000F;
			CustomParameter2 = new();
			Scale3 = 1.000000F;
			CustomParameter3 = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
