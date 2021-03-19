using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareDataWrapper : IScriptable
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

		public CyberwareDataWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
