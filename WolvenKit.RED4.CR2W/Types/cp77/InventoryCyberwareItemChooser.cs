using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryCyberwareItemChooser : InventoryGenericItemChooser
	{
		private inkCompoundWidgetReference _leftSlotsContainer;
		private inkCompoundWidgetReference _rightSlotsContainer;
		private InventoryItemData _itemData;
		private CArray<InventoryItemData> _itemDatas;

		[Ordinal(13)] 
		[RED("leftSlotsContainer")] 
		public inkCompoundWidgetReference LeftSlotsContainer
		{
			get
			{
				if (_leftSlotsContainer == null)
				{
					_leftSlotsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "leftSlotsContainer", cr2w, this);
				}
				return _leftSlotsContainer;
			}
			set
			{
				if (_leftSlotsContainer == value)
				{
					return;
				}
				_leftSlotsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("rightSlotsContainer")] 
		public inkCompoundWidgetReference RightSlotsContainer
		{
			get
			{
				if (_rightSlotsContainer == null)
				{
					_rightSlotsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "rightSlotsContainer", cr2w, this);
				}
				return _rightSlotsContainer;
			}
			set
			{
				if (_rightSlotsContainer == value)
				{
					return;
				}
				_rightSlotsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("itemDatas")] 
		public CArray<InventoryItemData> ItemDatas
		{
			get
			{
				if (_itemDatas == null)
				{
					_itemDatas = (CArray<InventoryItemData>) CR2WTypeManager.Create("array:InventoryItemData", "itemDatas", cr2w, this);
				}
				return _itemDatas;
			}
			set
			{
				if (_itemDatas == value)
				{
					return;
				}
				_itemDatas = value;
				PropertySet(this);
			}
		}

		public InventoryCyberwareItemChooser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
