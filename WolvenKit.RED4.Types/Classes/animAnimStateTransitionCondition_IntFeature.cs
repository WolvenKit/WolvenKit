using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_IntFeature : animIAnimStateTransitionCondition
	{
		private CInt32 _compareValue;
		private CName _featureName;
		private CName _featurePropertyName;
		private CEnum<animCompareFunc> _compareFunc;

		[Ordinal(0)] 
		[RED("compareValue")] 
		public CInt32 CompareValue
		{
			get => GetProperty(ref _compareValue);
			set => SetProperty(ref _compareValue, value);
		}

		[Ordinal(1)] 
		[RED("featureName")] 
		public CName FeatureName
		{
			get => GetProperty(ref _featureName);
			set => SetProperty(ref _featureName, value);
		}

		[Ordinal(2)] 
		[RED("featurePropertyName")] 
		public CName FeaturePropertyName
		{
			get => GetProperty(ref _featurePropertyName);
			set => SetProperty(ref _featurePropertyName, value);
		}

		[Ordinal(3)] 
		[RED("compareFunc")] 
		public CEnum<animCompareFunc> CompareFunc
		{
			get => GetProperty(ref _compareFunc);
			set => SetProperty(ref _compareFunc, value);
		}
	}
}
