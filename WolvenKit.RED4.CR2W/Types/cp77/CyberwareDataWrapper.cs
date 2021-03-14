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
			get
			{
				if (_inventoryItem == null)
				{
					_inventoryItem = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "InventoryItem", cr2w, this);
				}
				return _inventoryItem;
			}
			set
			{
				if (_inventoryItem == value)
				{
					return;
				}
				_inventoryItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("IsVendor")] 
		public CBool IsVendor
		{
			get
			{
				if (_isVendor == null)
				{
					_isVendor = (CBool) CR2WTypeManager.Create("Bool", "IsVendor", cr2w, this);
				}
				return _isVendor;
			}
			set
			{
				if (_isVendor == value)
				{
					return;
				}
				_isVendor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("PlayerMoney")] 
		public CInt32 PlayerMoney
		{
			get
			{
				if (_playerMoney == null)
				{
					_playerMoney = (CInt32) CR2WTypeManager.Create("Int32", "PlayerMoney", cr2w, this);
				}
				return _playerMoney;
			}
			set
			{
				if (_playerMoney == value)
				{
					return;
				}
				_playerMoney = value;
				PropertySet(this);
			}
		}

		public CyberwareDataWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
