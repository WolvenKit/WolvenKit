using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsReactionEvent : redEvent
	{
		private CName _interactionType;
		private CArray<gameEquipParam> _interactionItems;
		private CEnum<gameinteractionsReactionState> _state;

		[Ordinal(0)] 
		[RED("interactionType")] 
		public CName InteractionType
		{
			get => GetProperty(ref _interactionType);
			set => SetProperty(ref _interactionType, value);
		}

		[Ordinal(1)] 
		[RED("interactionItems")] 
		public CArray<gameEquipParam> InteractionItems
		{
			get => GetProperty(ref _interactionItems);
			set => SetProperty(ref _interactionItems, value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<gameinteractionsReactionState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
