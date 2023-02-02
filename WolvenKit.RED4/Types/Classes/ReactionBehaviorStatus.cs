using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReactionBehaviorStatus : redEvent
	{
		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<AIbehaviorUpdateOutcome> Status
		{
			get => GetPropertyValue<CEnum<AIbehaviorUpdateOutcome>>();
			set => SetPropertyValue<CEnum<AIbehaviorUpdateOutcome>>(value);
		}

		[Ordinal(1)] 
		[RED("reactionData")] 
		public CHandle<AIReactionData> ReactionData
		{
			get => GetPropertyValue<CHandle<AIReactionData>>();
			set => SetPropertyValue<CHandle<AIReactionData>>(value);
		}

		public ReactionBehaviorStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
