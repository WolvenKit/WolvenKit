using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SearchPatternMappingLookat : AISearchingLookat
	{
		private CHandle<AIArgumentMapping> _targetObjectMapping;
		private CWeakHandle<gameObject> _lookatTargetObject;

		[Ordinal(14)] 
		[RED("targetObjectMapping")] 
		public CHandle<AIArgumentMapping> TargetObjectMapping
		{
			get => GetProperty(ref _targetObjectMapping);
			set => SetProperty(ref _targetObjectMapping, value);
		}

		[Ordinal(15)] 
		[RED("lookatTargetObject")] 
		public CWeakHandle<gameObject> LookatTargetObject
		{
			get => GetProperty(ref _lookatTargetObject);
			set => SetProperty(ref _lookatTargetObject, value);
		}
	}
}
