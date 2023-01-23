using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_IntFeature : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("compareValue")] 
		public CInt32 CompareValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
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

		public animAnimStateTransitionCondition_IntFeature()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
