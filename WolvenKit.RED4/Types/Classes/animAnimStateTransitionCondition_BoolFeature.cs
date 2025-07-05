using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_BoolFeature : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("compareValue")] 
		public CBool CompareValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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

		public animAnimStateTransitionCondition_BoolFeature()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
