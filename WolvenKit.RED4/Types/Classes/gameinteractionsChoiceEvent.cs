using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsChoiceEvent : gameinteractionsInteractionBaseEvent
	{
		[Ordinal(3)] 
		[RED("choice")] 
		public gameinteractionsChoice Choice
		{
			get => GetPropertyValue<gameinteractionsChoice>();
			set => SetPropertyValue<gameinteractionsChoice>(value);
		}

		[Ordinal(4)] 
		[RED("actionType")] 
		public CEnum<gameinputActionType> ActionType
		{
			get => GetPropertyValue<CEnum<gameinputActionType>>();
			set => SetPropertyValue<CEnum<gameinputActionType>>(value);
		}

		public gameinteractionsChoiceEvent()
		{
			Choice = new gameinteractionsChoice();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
