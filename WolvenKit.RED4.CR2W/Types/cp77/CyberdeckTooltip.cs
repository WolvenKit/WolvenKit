using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckTooltip : AGenericTooltipController
	{
		private inkTextWidgetReference _itemNameText;
		private inkTextWidgetReference _itemRarityText;
		private inkWidgetReference _rarityBars;
		private inkTextWidgetReference _itemLevelText;
		private inkCompoundWidgetReference _categoriesWrapper;
		private inkCompoundWidgetReference _topContainer;
		private inkCompoundWidgetReference _headerContainer;
		private inkCompoundWidgetReference _statsContainer;
		private inkCompoundWidgetReference _descriptionContainer;
		private inkCompoundWidgetReference _bottomContainer;
		private inkCompoundWidgetReference _statsList;
		private inkCompoundWidgetReference _priceContainer;
		private inkTextWidgetReference _descriptionText;
		private inkTextWidgetReference _priceText;
		private inkWidgetReference _equipedWrapper;
		private inkTextWidgetReference _itemTypeText;
		private inkWidgetReference _itemWeightWrapper;
		private inkTextWidgetReference _itemWeightText;
		private inkTextWidgetReference _cybderdeckBaseMemoryValue;
		private inkTextWidgetReference _cybderdeckBufferValue;
		private inkTextWidgetReference _cybderdeckSlotsValue;
		private inkCompoundWidgetReference _deviceHacksGrid;
		private inkImageWidgetReference _itemIconImage;
		private inkWidgetReference _itemAttributeRequirements;
		private inkTextWidgetReference _itemAttributeRequirementsText;
		private CHandle<LevelBarsController> _rarityBarsController;
		private CHandle<InventoryTooltipData> _data;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(2)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get
			{
				if (_itemNameText == null)
				{
					_itemNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemNameText", cr2w, this);
				}
				return _itemNameText;
			}
			set
			{
				if (_itemNameText == value)
				{
					return;
				}
				_itemNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get
			{
				if (_itemRarityText == null)
				{
					_itemRarityText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemRarityText", cr2w, this);
				}
				return _itemRarityText;
			}
			set
			{
				if (_itemRarityText == value)
				{
					return;
				}
				_itemRarityText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rarityBars")] 
		public inkWidgetReference RarityBars
		{
			get
			{
				if (_rarityBars == null)
				{
					_rarityBars = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rarityBars", cr2w, this);
				}
				return _rarityBars;
			}
			set
			{
				if (_rarityBars == value)
				{
					return;
				}
				_rarityBars = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemLevelText")] 
		public inkTextWidgetReference ItemLevelText
		{
			get
			{
				if (_itemLevelText == null)
				{
					_itemLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemLevelText", cr2w, this);
				}
				return _itemLevelText;
			}
			set
			{
				if (_itemLevelText == value)
				{
					return;
				}
				_itemLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("categoriesWrapper")] 
		public inkCompoundWidgetReference CategoriesWrapper
		{
			get
			{
				if (_categoriesWrapper == null)
				{
					_categoriesWrapper = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "categoriesWrapper", cr2w, this);
				}
				return _categoriesWrapper;
			}
			set
			{
				if (_categoriesWrapper == value)
				{
					return;
				}
				_categoriesWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("topContainer")] 
		public inkCompoundWidgetReference TopContainer
		{
			get
			{
				if (_topContainer == null)
				{
					_topContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "topContainer", cr2w, this);
				}
				return _topContainer;
			}
			set
			{
				if (_topContainer == value)
				{
					return;
				}
				_topContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("headerContainer")] 
		public inkCompoundWidgetReference HeaderContainer
		{
			get
			{
				if (_headerContainer == null)
				{
					_headerContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "headerContainer", cr2w, this);
				}
				return _headerContainer;
			}
			set
			{
				if (_headerContainer == value)
				{
					return;
				}
				_headerContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get
			{
				if (_statsContainer == null)
				{
					_statsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "statsContainer", cr2w, this);
				}
				return _statsContainer;
			}
			set
			{
				if (_statsContainer == value)
				{
					return;
				}
				_statsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("descriptionContainer")] 
		public inkCompoundWidgetReference DescriptionContainer
		{
			get
			{
				if (_descriptionContainer == null)
				{
					_descriptionContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "descriptionContainer", cr2w, this);
				}
				return _descriptionContainer;
			}
			set
			{
				if (_descriptionContainer == value)
				{
					return;
				}
				_descriptionContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("bottomContainer")] 
		public inkCompoundWidgetReference BottomContainer
		{
			get
			{
				if (_bottomContainer == null)
				{
					_bottomContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "bottomContainer", cr2w, this);
				}
				return _bottomContainer;
			}
			set
			{
				if (_bottomContainer == value)
				{
					return;
				}
				_bottomContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("statsList")] 
		public inkCompoundWidgetReference StatsList
		{
			get
			{
				if (_statsList == null)
				{
					_statsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "statsList", cr2w, this);
				}
				return _statsList;
			}
			set
			{
				if (_statsList == value)
				{
					return;
				}
				_statsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("priceContainer")] 
		public inkCompoundWidgetReference PriceContainer
		{
			get
			{
				if (_priceContainer == null)
				{
					_priceContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "priceContainer", cr2w, this);
				}
				return _priceContainer;
			}
			set
			{
				if (_priceContainer == value)
				{
					return;
				}
				_priceContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get
			{
				if (_descriptionText == null)
				{
					_descriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "descriptionText", cr2w, this);
				}
				return _descriptionText;
			}
			set
			{
				if (_descriptionText == value)
				{
					return;
				}
				_descriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get
			{
				if (_priceText == null)
				{
					_priceText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "priceText", cr2w, this);
				}
				return _priceText;
			}
			set
			{
				if (_priceText == value)
				{
					return;
				}
				_priceText = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("equipedWrapper")] 
		public inkWidgetReference EquipedWrapper
		{
			get
			{
				if (_equipedWrapper == null)
				{
					_equipedWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "equipedWrapper", cr2w, this);
				}
				return _equipedWrapper;
			}
			set
			{
				if (_equipedWrapper == value)
				{
					return;
				}
				_equipedWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get
			{
				if (_itemTypeText == null)
				{
					_itemTypeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemTypeText", cr2w, this);
				}
				return _itemTypeText;
			}
			set
			{
				if (_itemTypeText == value)
				{
					return;
				}
				_itemTypeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("itemWeightWrapper")] 
		public inkWidgetReference ItemWeightWrapper
		{
			get
			{
				if (_itemWeightWrapper == null)
				{
					_itemWeightWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemWeightWrapper", cr2w, this);
				}
				return _itemWeightWrapper;
			}
			set
			{
				if (_itemWeightWrapper == value)
				{
					return;
				}
				_itemWeightWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("itemWeightText")] 
		public inkTextWidgetReference ItemWeightText
		{
			get
			{
				if (_itemWeightText == null)
				{
					_itemWeightText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemWeightText", cr2w, this);
				}
				return _itemWeightText;
			}
			set
			{
				if (_itemWeightText == value)
				{
					return;
				}
				_itemWeightText = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("cybderdeckBaseMemoryValue")] 
		public inkTextWidgetReference CybderdeckBaseMemoryValue
		{
			get
			{
				if (_cybderdeckBaseMemoryValue == null)
				{
					_cybderdeckBaseMemoryValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "cybderdeckBaseMemoryValue", cr2w, this);
				}
				return _cybderdeckBaseMemoryValue;
			}
			set
			{
				if (_cybderdeckBaseMemoryValue == value)
				{
					return;
				}
				_cybderdeckBaseMemoryValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("cybderdeckBufferValue")] 
		public inkTextWidgetReference CybderdeckBufferValue
		{
			get
			{
				if (_cybderdeckBufferValue == null)
				{
					_cybderdeckBufferValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "cybderdeckBufferValue", cr2w, this);
				}
				return _cybderdeckBufferValue;
			}
			set
			{
				if (_cybderdeckBufferValue == value)
				{
					return;
				}
				_cybderdeckBufferValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("cybderdeckSlotsValue")] 
		public inkTextWidgetReference CybderdeckSlotsValue
		{
			get
			{
				if (_cybderdeckSlotsValue == null)
				{
					_cybderdeckSlotsValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "cybderdeckSlotsValue", cr2w, this);
				}
				return _cybderdeckSlotsValue;
			}
			set
			{
				if (_cybderdeckSlotsValue == value)
				{
					return;
				}
				_cybderdeckSlotsValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("deviceHacksGrid")] 
		public inkCompoundWidgetReference DeviceHacksGrid
		{
			get
			{
				if (_deviceHacksGrid == null)
				{
					_deviceHacksGrid = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "deviceHacksGrid", cr2w, this);
				}
				return _deviceHacksGrid;
			}
			set
			{
				if (_deviceHacksGrid == value)
				{
					return;
				}
				_deviceHacksGrid = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("itemIconImage")] 
		public inkImageWidgetReference ItemIconImage
		{
			get
			{
				if (_itemIconImage == null)
				{
					_itemIconImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "itemIconImage", cr2w, this);
				}
				return _itemIconImage;
			}
			set
			{
				if (_itemIconImage == value)
				{
					return;
				}
				_itemIconImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("itemAttributeRequirements")] 
		public inkWidgetReference ItemAttributeRequirements
		{
			get
			{
				if (_itemAttributeRequirements == null)
				{
					_itemAttributeRequirements = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemAttributeRequirements", cr2w, this);
				}
				return _itemAttributeRequirements;
			}
			set
			{
				if (_itemAttributeRequirements == value)
				{
					return;
				}
				_itemAttributeRequirements = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("itemAttributeRequirementsText")] 
		public inkTextWidgetReference ItemAttributeRequirementsText
		{
			get
			{
				if (_itemAttributeRequirementsText == null)
				{
					_itemAttributeRequirementsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemAttributeRequirementsText", cr2w, this);
				}
				return _itemAttributeRequirementsText;
			}
			set
			{
				if (_itemAttributeRequirementsText == value)
				{
					return;
				}
				_itemAttributeRequirementsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("rarityBarsController")] 
		public CHandle<LevelBarsController> RarityBarsController
		{
			get
			{
				if (_rarityBarsController == null)
				{
					_rarityBarsController = (CHandle<LevelBarsController>) CR2WTypeManager.Create("handle:LevelBarsController", "rarityBarsController", cr2w, this);
				}
				return _rarityBarsController;
			}
			set
			{
				if (_rarityBarsController == value)
				{
					return;
				}
				_rarityBarsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<InventoryTooltipData>) CR2WTypeManager.Create("handle:InventoryTooltipData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		public CyberdeckTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
