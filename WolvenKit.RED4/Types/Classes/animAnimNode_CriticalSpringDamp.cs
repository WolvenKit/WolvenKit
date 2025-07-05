using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_CriticalSpringDamp : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("smoothTime")] 
		public CFloat SmoothTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("useRange")] 
		public CBool UseRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("useRawTime")] 
		public CBool UseRawTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_CriticalSpringDamp()
		{
			Id = uint.MaxValue;
			SmoothTime = 1.000000F;
			RangeMin = -180.000000F;
			RangeMax = 180.000000F;
			InputNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
