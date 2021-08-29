using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorActionUnequipItemNodeDefinition : AIbehaviorActionItemHandlingNodeDefinition
	{
		private CHandle<AIArgumentMapping> _slotId;
		private CHandle<AIArgumentMapping> _duration;

		[Ordinal(1)] 
		[RED("slotId")] 
		public CHandle<AIArgumentMapping> SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CHandle<AIArgumentMapping> Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}
	}
}
