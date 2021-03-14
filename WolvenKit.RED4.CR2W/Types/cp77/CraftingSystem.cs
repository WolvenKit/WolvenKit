using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingSystem : gameScriptableSystem
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
			get
			{
				if (_lastActionStatus == null)
				{
					_lastActionStatus = (CBool) CR2WTypeManager.Create("Bool", "lastActionStatus", cr2w, this);
				}
				return _lastActionStatus;
			}
			set
			{
				if (_lastActionStatus == value)
				{
					return;
				}
				_lastActionStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerCraftBook")] 
		public CHandle<CraftBook> PlayerCraftBook
		{
			get
			{
				if (_playerCraftBook == null)
				{
					_playerCraftBook = (CHandle<CraftBook>) CR2WTypeManager.Create("handle:CraftBook", "playerCraftBook", cr2w, this);
				}
				return _playerCraftBook;
			}
			set
			{
				if (_playerCraftBook == value)
				{
					return;
				}
				_playerCraftBook = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("callback")] 
		public CHandle<CraftingSystemInventoryCallback> Callback
		{
			get
			{
				if (_callback == null)
				{
					_callback = (CHandle<CraftingSystemInventoryCallback>) CR2WTypeManager.Create("handle:CraftingSystemInventoryCallback", "callback", cr2w, this);
				}
				return _callback;
			}
			set
			{
				if (_callback == value)
				{
					return;
				}
				_callback = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get
			{
				if (_inventoryListener == null)
				{
					_inventoryListener = (CHandle<gameInventoryScriptListener>) CR2WTypeManager.Create("handle:gameInventoryScriptListener", "inventoryListener", cr2w, this);
				}
				return _inventoryListener;
			}
			set
			{
				if (_inventoryListener == value)
				{
					return;
				}
				_inventoryListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("itemIconGender")] 
		public CEnum<gameItemIconGender> ItemIconGender
		{
			get
			{
				if (_itemIconGender == null)
				{
					_itemIconGender = (CEnum<gameItemIconGender>) CR2WTypeManager.Create("gameItemIconGender", "itemIconGender", cr2w, this);
				}
				return _itemIconGender;
			}
			set
			{
				if (_itemIconGender == value)
				{
					return;
				}
				_itemIconGender = value;
				PropertySet(this);
			}
		}

		public CraftingSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
