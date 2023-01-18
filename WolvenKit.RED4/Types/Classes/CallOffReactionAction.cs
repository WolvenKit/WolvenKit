using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CallOffReactionAction : SquadTask
	{
		[Ordinal(0)] 
		[RED("squadActionName")] 
		public CEnum<EAISquadAction> SquadActionName
		{
			get => GetPropertyValue<CEnum<EAISquadAction>>();
			set => SetPropertyValue<CEnum<EAISquadAction>>(value);
		}

		public CallOffReactionAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
