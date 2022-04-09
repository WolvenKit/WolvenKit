using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAnimationExtractedData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("animsetsExtractedTransforms")] 
		public CArray<gameAnimationTransforms> AnimsetsExtractedTransforms
		{
			get => GetPropertyValue<CArray<gameAnimationTransforms>>();
			set => SetPropertyValue<CArray<gameAnimationTransforms>>(value);
		}

		[Ordinal(2)] 
		[RED("smartObjectPointType")] 
		public CEnum<gameSmartObjectPointType> SmartObjectPointType
		{
			get => GetPropertyValue<CEnum<gameSmartObjectPointType>>();
			set => SetPropertyValue<CEnum<gameSmartObjectPointType>>(value);
		}

		public gameAnimationExtractedData()
		{
			AnimsetsExtractedTransforms = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
