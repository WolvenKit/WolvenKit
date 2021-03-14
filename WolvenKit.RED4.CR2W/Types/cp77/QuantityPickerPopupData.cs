using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuantityPickerPopupData : inkGameNotificationData
	{
		private CInt32 _maxValue;
		private InventoryItemData _gameItemData;
		private CEnum<QuantityPickerActionType> _actionType;
		private wCHandle<gameObject> _vendor;
		private CBool _isBuyback;

		[Ordinal(6)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get
			{
				if (_maxValue == null)
				{
					_maxValue = (CInt32) CR2WTypeManager.Create("Int32", "maxValue", cr2w, this);
				}
				return _maxValue;
			}
			set
			{
				if (_maxValue == value)
				{
					return;
				}
				_maxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("gameItemData")] 
		public InventoryItemData GameItemData
		{
			get
			{
				if (_gameItemData == null)
				{
					_gameItemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "gameItemData", cr2w, this);
				}
				return _gameItemData;
			}
			set
			{
				if (_gameItemData == value)
				{
					return;
				}
				_gameItemData = value;
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
		[RED("vendor")] 
		public wCHandle<gameObject> Vendor
		{
			get
			{
				if (_vendor == null)
				{
					_vendor = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "vendor", cr2w, this);
				}
				return _vendor;
			}
			set
			{
				if (_vendor == value)
				{
					return;
				}
				_vendor = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		public QuantityPickerPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
