using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsReactionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("interactionType")] 
		public CName InteractionType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("interactionItems")] 
		public CArray<gameEquipParam> InteractionItems
		{
			get => GetPropertyValue<CArray<gameEquipParam>>();
			set => SetPropertyValue<CArray<gameEquipParam>>(value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<gameinteractionsReactionState> State
		{
			get => GetPropertyValue<CEnum<gameinteractionsReactionState>>();
			set => SetPropertyValue<CEnum<gameinteractionsReactionState>>(value);
		}

		public gameinteractionsReactionEvent()
		{
			InteractionItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
