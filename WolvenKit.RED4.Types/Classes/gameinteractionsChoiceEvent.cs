using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsChoiceEvent : gameinteractionsInteractionBaseEvent
	{
		private gameinteractionsChoice _choice;
		private CEnum<gameinputActionType> _actionType;

		[Ordinal(3)] 
		[RED("choice")] 
		public gameinteractionsChoice Choice
		{
			get => GetProperty(ref _choice);
			set => SetProperty(ref _choice, value);
		}

		[Ordinal(4)] 
		[RED("actionType")] 
		public CEnum<gameinputActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}
	}
}
