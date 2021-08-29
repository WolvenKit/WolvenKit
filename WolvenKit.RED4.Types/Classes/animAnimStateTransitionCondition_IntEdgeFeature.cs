using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_IntEdgeFeature : animIAnimStateTransitionCondition
	{
		private CName _featureName;
		private CName _featurePropertyName;

		[Ordinal(0)] 
		[RED("featureName")] 
		public CName FeatureName
		{
			get => GetProperty(ref _featureName);
			set => SetProperty(ref _featureName, value);
		}

		[Ordinal(1)] 
		[RED("featurePropertyName")] 
		public CName FeaturePropertyName
		{
			get => GetProperty(ref _featurePropertyName);
			set => SetProperty(ref _featurePropertyName, value);
		}
	}
}
