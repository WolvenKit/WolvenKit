using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CyberwareDataWrapper : IScriptable
	{
		private InventoryItemData _inventoryItem;
		private CBool _isVendor;
		private CInt32 _playerMoney;

		[Ordinal(0)] 
		[RED("InventoryItem")] 
		public InventoryItemData InventoryItem
		{
			get => GetProperty(ref _inventoryItem);
			set => SetProperty(ref _inventoryItem, value);
		}

		[Ordinal(1)] 
		[RED("IsVendor")] 
		public CBool IsVendor
		{
			get => GetProperty(ref _isVendor);
			set => SetProperty(ref _isVendor, value);
		}

		[Ordinal(2)] 
		[RED("PlayerMoney")] 
		public CInt32 PlayerMoney
		{
			get => GetProperty(ref _playerMoney);
			set => SetProperty(ref _playerMoney, value);
		}
	}
}
