using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_DampFloat : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("defaultIncreaseSpeed")] 
		public CFloat DefaultIncreaseSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("defaultDecreaseSpeed")] 
		public CFloat DefaultDecreaseSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("startFromDefaultValue")] 
		public CBool StartFromDefaultValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("defaultInitialValue")] 
		public CFloat DefaultInitialValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("wrapAroundRange")] 
		public CBool WrapAroundRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(9)] 
		[RED("increaseSpeedNode")] 
		public animFloatLink IncreaseSpeedNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(10)] 
		[RED("decreaseSpeedNode")] 
		public animFloatLink DecreaseSpeedNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_DampFloat()
		{
			Id = uint.MaxValue;
			DefaultIncreaseSpeed = 1.000000F;
			DefaultDecreaseSpeed = 1.000000F;
			RangeMin = -180.000000F;
			RangeMax = 180.000000F;
			InputNode = new animFloatLink();
			IncreaseSpeedNode = new animFloatLink();
			DecreaseSpeedNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
