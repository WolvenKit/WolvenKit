using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorIsThreatOnPathConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _threatObject;
		private CHandle<AIArgumentMapping> _threatRadius;

		[Ordinal(1)] 
		[RED("threatObject")] 
		public CHandle<AIArgumentMapping> ThreatObject
		{
			get => GetProperty(ref _threatObject);
			set => SetProperty(ref _threatObject, value);
		}

		[Ordinal(2)] 
		[RED("threatRadius")] 
		public CHandle<AIArgumentMapping> ThreatRadius
		{
			get => GetProperty(ref _threatRadius);
			set => SetProperty(ref _threatRadius, value);
		}
	}
}
