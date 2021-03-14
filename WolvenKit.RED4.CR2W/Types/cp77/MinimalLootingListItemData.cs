using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalLootingListItemData : IScriptable
	{
		private wCHandle<gameItemData> _gameItemData;
		private CString _itemName;
		private CEnum<gamedataItemType> _itemType;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataQuality> _quality;
		private CBool _isIconic;
		private CInt32 _quantity;
		private CEnum<gameLootItemType> _lootItemType;
		private CFloat _dpsDiff;

		[Ordinal(0)] 
		[RED("gameItemData")] 
		public wCHandle<gameItemData> GameItemData
		{
			get
			{
				if (_gameItemData == null)
				{
					_gameItemData = (wCHandle<gameItemData>) CR2WTypeManager.Create("whandle:gameItemData", "gameItemData", cr2w, this);
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

		[Ordinal(1)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (CString) CR2WTypeManager.Create("String", "itemName", cr2w, this);
				}
				return _itemName;
			}
			set
			{
				if (_itemName == value)
				{
					return;
				}
				_itemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get
			{
				if (_itemType == null)
				{
					_itemType = (CEnum<gamedataItemType>) CR2WTypeManager.Create("gamedataItemType", "itemType", cr2w, this);
				}
				return _itemType;
			}
			set
			{
				if (_itemType == value)
				{
					return;
				}
				_itemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get
			{
				if (_equipmentArea == null)
				{
					_equipmentArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipmentArea", cr2w, this);
				}
				return _equipmentArea;
			}
			set
			{
				if (_equipmentArea == value)
				{
					return;
				}
				_equipmentArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get
			{
				if (_quality == null)
				{
					_quality = (CEnum<gamedataQuality>) CR2WTypeManager.Create("gamedataQuality", "quality", cr2w, this);
				}
				return _quality;
			}
			set
			{
				if (_quality == value)
				{
					return;
				}
				_quality = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get
			{
				if (_isIconic == null)
				{
					_isIconic = (CBool) CR2WTypeManager.Create("Bool", "isIconic", cr2w, this);
				}
				return _isIconic;
			}
			set
			{
				if (_isIconic == value)
				{
					return;
				}
				_isIconic = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (CInt32) CR2WTypeManager.Create("Int32", "quantity", cr2w, this);
				}
				return _quantity;
			}
			set
			{
				if (_quantity == value)
				{
					return;
				}
				_quantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get
			{
				if (_lootItemType == null)
				{
					_lootItemType = (CEnum<gameLootItemType>) CR2WTypeManager.Create("gameLootItemType", "lootItemType", cr2w, this);
				}
				return _lootItemType;
			}
			set
			{
				if (_lootItemType == value)
				{
					return;
				}
				_lootItemType = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("dpsDiff")] 
		public CFloat DpsDiff
		{
			get
			{
				if (_dpsDiff == null)
				{
					_dpsDiff = (CFloat) CR2WTypeManager.Create("Float", "dpsDiff", cr2w, this);
				}
				return _dpsDiff;
			}
			set
			{
				if (_dpsDiff == value)
				{
					return;
				}
				_dpsDiff = value;
				PropertySet(this);
			}
		}

		public MinimalLootingListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
