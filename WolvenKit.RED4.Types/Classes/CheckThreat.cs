using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckThreat : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _targetObjectMapping;
		private CWeakHandle<gameObject> _targetThreat;

		[Ordinal(0)] 
		[RED("targetObjectMapping")] 
		public CHandle<AIArgumentMapping> TargetObjectMapping
		{
			get => GetProperty(ref _targetObjectMapping);
			set => SetProperty(ref _targetObjectMapping, value);
		}

		[Ordinal(1)] 
		[RED("targetThreat")] 
		public CWeakHandle<gameObject> TargetThreat
		{
			get => GetProperty(ref _targetThreat);
			set => SetProperty(ref _targetThreat, value);
		}
	}
}
