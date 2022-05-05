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
			Choice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
