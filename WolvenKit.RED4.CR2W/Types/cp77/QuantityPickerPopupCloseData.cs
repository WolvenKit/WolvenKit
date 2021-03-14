using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuantityPickerPopupCloseData : inkGameNotificationData
	{
		private CInt32 _choosenQuantity;
		private InventoryItemData _itemData;
		private CEnum<QuantityPickerActionType> _actionType;
		private CBool _isBuyback;

		[Ordinal(6)] 
		[RED("choosenQuantity")] 
		public CInt32 ChoosenQuantity
		{
			get
			{
				if (_choosenQuantity == null)
				{
					_choosenQuantity = (CInt32) CR2WTypeManager.Create("Int32", "choosenQuantity", cr2w, this);
				}
				return _choosenQuantity;
			}
			set
			{
				if (_choosenQuantity == value)
				{
					return;
				}
				_choosenQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "itemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("actionType")] 
		public CEnum<QuantityPickerActionType> ActionType
		{
			get
			{
				if (_actionType == null)
				{
					_actionType = (CEnum<QuantityPickerActionType>) CR2WTypeManager.Create("QuantityPickerActionType", "actionType", cr2w, this);
				}
				return _actionType;
			}
			set
			{
				if (_actionType == value)
				{
					return;
				}
				_actionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isBuyback")] 
		public CBool IsBuyback
		{
			get
			{
				if (_isBuyback == null)
				{
					_isBuyback = (CBool) CR2WTypeManager.Create("Bool", "isBuyback", cr2w, this);
				}
				return _isBuyback;
			}
			set
			{
				if (_isBuyback == value)
				{
					return;
				}
				_isBuyback = value;
				PropertySet(this);
			}
		}

		public QuantityPickerPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
