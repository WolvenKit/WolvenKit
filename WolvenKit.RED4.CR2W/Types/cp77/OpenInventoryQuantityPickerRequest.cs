using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenInventoryQuantityPickerRequest : redEvent
	{
		private InventoryItemData _itemData;
		private CEnum<QuantityPickerActionType> _actionType;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		public OpenInventoryQuantityPickerRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
