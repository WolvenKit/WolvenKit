using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnregisterReactionAction : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("reactionName")] 
		public CName ReactionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("onDeactivation")] 
		public CBool OnDeactivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UnregisterReactionAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
