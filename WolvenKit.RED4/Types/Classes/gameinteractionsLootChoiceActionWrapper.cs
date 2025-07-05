using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsLootChoiceActionWrapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("removeItem")] 
		public CBool RemoveItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CName Action
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameinteractionsLootChoiceActionWrapper()
		{
			ItemId = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
