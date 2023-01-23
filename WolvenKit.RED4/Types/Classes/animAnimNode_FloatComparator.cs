using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatComparator : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("firstValue")] 
		public CFloat FirstValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("secondValue")] 
		public CFloat SecondValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("trueValue")] 
		public CFloat TrueValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("falseValue")] 
		public CFloat FalseValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("operation")] 
		public CEnum<animEAnimGraphCompareFunc> Operation
		{
			get => GetPropertyValue<CEnum<animEAnimGraphCompareFunc>>();
			set => SetPropertyValue<CEnum<animEAnimGraphCompareFunc>>(value);
		}

		[Ordinal(16)] 
		[RED("firstInputLink")] 
		public animFloatLink FirstInputLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(17)] 
		[RED("secondInputLink")] 
		public animFloatLink SecondInputLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(18)] 
		[RED("trueInputLink")] 
		public animFloatLink TrueInputLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(19)] 
		[RED("falseInputLink")] 
		public animFloatLink FalseInputLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatComparator()
		{
			Id = 4294967295;
			FirstInputLink = new();
			SecondInputLink = new();
			TrueInputLink = new();
			FalseInputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
