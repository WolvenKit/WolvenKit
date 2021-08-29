using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReactionBehaviorStatus : redEvent
	{
		private CEnum<AIbehaviorUpdateOutcome> _status;
		private CHandle<AIReactionData> _reactionData;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<AIbehaviorUpdateOutcome> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(1)] 
		[RED("reactionData")] 
		public CHandle<AIReactionData> ReactionData
		{
			get => GetProperty(ref _reactionData);
			set => SetProperty(ref _reactionData, value);
		}
	}
}
