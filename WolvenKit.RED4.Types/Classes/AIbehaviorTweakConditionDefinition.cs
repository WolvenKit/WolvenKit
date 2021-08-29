using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorTweakConditionDefinition : AIbehaviorConditionDefinition
	{
		private TweakDBID _recordId;

		[Ordinal(1)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get => GetProperty(ref _recordId);
			set => SetProperty(ref _recordId, value);
		}
	}
}
