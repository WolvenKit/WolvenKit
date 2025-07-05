using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_FloatFeature : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("compareValue")] 
		public CFloat CompareValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("featureName")] 
		public CName FeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("featurePropertyName")] 
		public CName FeaturePropertyName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("compareFunc")] 
		public CEnum<animCompareFunc> CompareFunc
		{
			get => GetPropertyValue<CEnum<animCompareFunc>>();
			set => SetPropertyValue<CEnum<animCompareFunc>>(value);
		}

		public animAnimStateTransitionCondition_FloatFeature()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
