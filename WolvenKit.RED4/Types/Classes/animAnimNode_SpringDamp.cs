using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SpringDamp : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("massFactor")] 
		public CFloat MassFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("springFactor")] 
		public CFloat SpringFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("dampFactor")] 
		public CFloat DampFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("startFromDefaultValue")] 
		public CBool StartFromDefaultValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("defaultInitialValue")] 
		public CFloat DefaultInitialValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("wrapAroundRange")] 
		public CBool WrapAroundRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("timeStep")] 
		public CFloat TimeStep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_SpringDamp()
		{
			Id = uint.MaxValue;
			MassFactor = 1.000000F;
			SpringFactor = 1.000000F;
			DampFactor = 1.000000F;
			RangeMin = -180.000000F;
			RangeMax = 180.000000F;
			TimeStep = 0.005000F;
			InputNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
