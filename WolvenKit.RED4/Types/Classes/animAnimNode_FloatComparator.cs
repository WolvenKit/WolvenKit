using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatComparator : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("firstValue")] 
		public CFloat FirstValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("secondValue")] 
		public CFloat SecondValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("trueValue")] 
		public CFloat TrueValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("falseValue")] 
		public CFloat FalseValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("operation")] 
		public CEnum<animEAnimGraphCompareFunc> Operation
		{
			get => GetPropertyValue<CEnum<animEAnimGraphCompareFunc>>();
			set => SetPropertyValue<CEnum<animEAnimGraphCompareFunc>>(value);
		}

		[Ordinal(6)] 
		[RED("firstInputLink")] 
		public animFloatLink FirstInputLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(7)] 
		[RED("secondInputLink")] 
		public animFloatLink SecondInputLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(8)] 
		[RED("trueInputLink")] 
		public animFloatLink TrueInputLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(9)] 
		[RED("falseInputLink")] 
		public animFloatLink FalseInputLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatComparator()
		{
			Id = uint.MaxValue;
			FirstInputLink = new animFloatLink();
			SecondInputLink = new animFloatLink();
			TrueInputLink = new animFloatLink();
			FalseInputLink = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
