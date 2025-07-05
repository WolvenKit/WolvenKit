using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReactionManagerTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("reactionData")] 
		public CHandle<AIReactionData> ReactionData
		{
			get => GetPropertyValue<CHandle<AIReactionData>>();
			set => SetPropertyValue<CHandle<AIReactionData>>(value);
		}

		public ReactionManagerTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
