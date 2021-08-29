using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CraftingSystem : gameScriptableSystem
	{
		private CBool _lastActionStatus;
		private CHandle<CraftBook> _playerCraftBook;
		private CHandle<CraftingSystemInventoryCallback> _callback;
		private CHandle<gameInventoryScriptListener> _inventoryListener;
		private CEnum<gameItemIconGender> _itemIconGender;

		[Ordinal(0)] 
		[RED("lastActionStatus")] 
		public CBool LastActionStatus
		{
			get => GetProperty(ref _lastActionStatus);
			set => SetProperty(ref _lastActionStatus, value);
		}

		[Ordinal(1)] 
		[RED("playerCraftBook")] 
		public CHandle<CraftBook> PlayerCraftBook
		{
			get => GetProperty(ref _playerCraftBook);
			set => SetProperty(ref _playerCraftBook, value);
		}

		[Ordinal(2)] 
		[RED("callback")] 
		public CHandle<CraftingSystemInventoryCallback> Callback
		{
			get => GetProperty(ref _callback);
			set => SetProperty(ref _callback, value);
		}

		[Ordinal(3)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		[Ordinal(4)] 
		[RED("itemIconGender")] 
		public CEnum<gameItemIconGender> ItemIconGender
		{
			get => GetProperty(ref _itemIconGender);
			set => SetProperty(ref _itemIconGender, value);
		}
	}
}
