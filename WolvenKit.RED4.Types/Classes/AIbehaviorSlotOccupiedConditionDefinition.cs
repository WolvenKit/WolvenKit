using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorSlotOccupiedConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _slot;

		[Ordinal(1)] 
		[RED("slot")] 
		public CHandle<AIArgumentMapping> Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}
	}
}
