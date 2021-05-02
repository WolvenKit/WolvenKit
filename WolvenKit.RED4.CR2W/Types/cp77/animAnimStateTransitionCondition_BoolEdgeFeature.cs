using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_BoolEdgeFeature : animIAnimStateTransitionCondition
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

		public animAnimStateTransitionCondition_BoolEdgeFeature(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
