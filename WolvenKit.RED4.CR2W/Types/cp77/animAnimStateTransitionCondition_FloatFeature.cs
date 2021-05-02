using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_FloatFeature : animIAnimStateTransitionCondition
	{
		private CFloat _compareValue;
		private CName _featureName;
		private CName _featurePropertyName;
		private CEnum<animCompareFunc> _compareFunc;

		[Ordinal(0)] 
		[RED("compareValue")] 
		public CFloat CompareValue
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

		public animAnimStateTransitionCondition_FloatFeature(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
