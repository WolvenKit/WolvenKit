using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorCompositeConditionDefinition : AIbehaviorConditionDefinition
	{
		private CArray<CHandle<AIbehaviorConditionDefinition>> _conditions;

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<AIbehaviorConditionDefinition>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}
	}
}
