using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsLootChoiceActionWrapper : RedBaseClass
	{
		private CBool _removeItem;
		private gameItemID _itemId;
		private CName _action;

		[Ordinal(0)] 
		[RED("removeItem")] 
		public CBool RemoveItem
		{
			get => GetProperty(ref _removeItem);
			set => SetProperty(ref _removeItem, value);
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CName Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}
