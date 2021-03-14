using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipCommonController : AGenericTooltipController
	{
		private inkWidgetReference _backgroundContainer;
		private inkWidgetReference _itemEquippedContainer;
		private inkWidgetReference _itemHeaderContainer;
		private inkWidgetReference _itemIconContainer;
		private inkWidgetReference _itemWeaponInfoContainer;
		private inkWidgetReference _itemClothingInfoContainer;
		private inkWidgetReference _itemGrenadeInfoContainer;
		private inkWidgetReference _itemRequirementsContainer;
		private inkWidgetReference _itemDetailsContainer;
		private inkWidgetReference _itemRecipeDataContainer;
		private inkWidgetReference _itemEvolutionContainer;
		private inkWidgetReference _itemCraftedContainer;
		private inkWidgetReference _itemBottomContainer;
		private inkWidgetReference _descriptionWrapper;
		private inkTextWidgetReference _descriptionText;
		private inkWidgetReference _dEBUG_iconErrorWrapper;
		private inkTextWidgetReference _dEBUG_iconErrorText;
		private CHandle<ItemTooltipEquippedModule> _itemEquippedController;
		private CHandle<ItemTooltipHeaderController> _itemHeaderController;
		private CHandle<ItemTooltipIconModule> _itemIconController;
		private CHandle<ItemTooltipWeaponInfoModule> _itemWeaponInfoController;
		private CHandle<ItemTooltipClothingInfoModule> _itemClothingInfoController;
		private CHandle<ItemTooltipGrenadeInfoModule> _itemGrenadeInfoController;
		private CHandle<ItemTooltipRequirementsModule> _itemRequirementsController;
		private CHandle<ItemTooltipDetailsModule> _itemDetailsController;
		private CHandle<ItemTooltipRecipeDataModule> _itemRecipeDataController;
		private CHandle<ItemTooltipEvolutionModule> _itemEvolutionController;
		private CHandle<ItemTooltipCraftedModule> _itemCraftedController;
		private CHandle<ItemTooltipBottomModule> _itemBottomController;
		private CBool _dEBUG_showAdditionalInfo;
		private CHandle<MinimalItemTooltipData> _data;
		private CArray<CName> _requestedModules;

		[Ordinal(2)] 
		[RED("backgroundContainer")] 
		public inkWidgetReference BackgroundContainer
		{
			get
			{
				if (_backgroundContainer == null)
				{
					_backgroundContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "backgroundContainer", cr2w, this);
				}
				return _backgroundContainer;
			}
			set
			{
				if (_backgroundContainer == value)
				{
					return;
				}
				_backgroundContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemEquippedContainer")] 
		public inkWidgetReference ItemEquippedContainer
		{
			get
			{
				if (_itemEquippedContainer == null)
				{
					_itemEquippedContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemEquippedContainer", cr2w, this);
				}
				return _itemEquippedContainer;
			}
			set
			{
				if (_itemEquippedContainer == value)
				{
					return;
				}
				_itemEquippedContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("itemHeaderContainer")] 
		public inkWidgetReference ItemHeaderContainer
		{
			get
			{
				if (_itemHeaderContainer == null)
				{
					_itemHeaderContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemHeaderContainer", cr2w, this);
				}
				return _itemHeaderContainer;
			}
			set
			{
				if (_itemHeaderContainer == value)
				{
					return;
				}
				_itemHeaderContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemIconContainer")] 
		public inkWidgetReference ItemIconContainer
		{
			get
			{
				if (_itemIconContainer == null)
				{
					_itemIconContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemIconContainer", cr2w, this);
				}
				return _itemIconContainer;
			}
			set
			{
				if (_itemIconContainer == value)
				{
					return;
				}
				_itemIconContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("itemWeaponInfoContainer")] 
		public inkWidgetReference ItemWeaponInfoContainer
		{
			get
			{
				if (_itemWeaponInfoContainer == null)
				{
					_itemWeaponInfoContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemWeaponInfoContainer", cr2w, this);
				}
				return _itemWeaponInfoContainer;
			}
			set
			{
				if (_itemWeaponInfoContainer == value)
				{
					return;
				}
				_itemWeaponInfoContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("itemClothingInfoContainer")] 
		public inkWidgetReference ItemClothingInfoContainer
		{
			get
			{
				if (_itemClothingInfoContainer == null)
				{
					_itemClothingInfoContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemClothingInfoContainer", cr2w, this);
				}
				return _itemClothingInfoContainer;
			}
			set
			{
				if (_itemClothingInfoContainer == value)
				{
					return;
				}
				_itemClothingInfoContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("itemGrenadeInfoContainer")] 
		public inkWidgetReference ItemGrenadeInfoContainer
		{
			get
			{
				if (_itemGrenadeInfoContainer == null)
				{
					_itemGrenadeInfoContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemGrenadeInfoContainer", cr2w, this);
				}
				return _itemGrenadeInfoContainer;
			}
			set
			{
				if (_itemGrenadeInfoContainer == value)
				{
					return;
				}
				_itemGrenadeInfoContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("itemRequirementsContainer")] 
		public inkWidgetReference ItemRequirementsContainer
		{
			get
			{
				if (_itemRequirementsContainer == null)
				{
					_itemRequirementsContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemRequirementsContainer", cr2w, this);
				}
				return _itemRequirementsContainer;
			}
			set
			{
				if (_itemRequirementsContainer == value)
				{
					return;
				}
				_itemRequirementsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("itemDetailsContainer")] 
		public inkWidgetReference ItemDetailsContainer
		{
			get
			{
				if (_itemDetailsContainer == null)
				{
					_itemDetailsContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemDetailsContainer", cr2w, this);
				}
				return _itemDetailsContainer;
			}
			set
			{
				if (_itemDetailsContainer == value)
				{
					return;
				}
				_itemDetailsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("itemRecipeDataContainer")] 
		public inkWidgetReference ItemRecipeDataContainer
		{
			get
			{
				if (_itemRecipeDataContainer == null)
				{
					_itemRecipeDataContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemRecipeDataContainer", cr2w, this);
				}
				return _itemRecipeDataContainer;
			}
			set
			{
				if (_itemRecipeDataContainer == value)
				{
					return;
				}
				_itemRecipeDataContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("itemEvolutionContainer")] 
		public inkWidgetReference ItemEvolutionContainer
		{
			get
			{
				if (_itemEvolutionContainer == null)
				{
					_itemEvolutionContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemEvolutionContainer", cr2w, this);
				}
				return _itemEvolutionContainer;
			}
			set
			{
				if (_itemEvolutionContainer == value)
				{
					return;
				}
				_itemEvolutionContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("itemCraftedContainer")] 
		public inkWidgetReference ItemCraftedContainer
		{
			get
			{
				if (_itemCraftedContainer == null)
				{
					_itemCraftedContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemCraftedContainer", cr2w, this);
				}
				return _itemCraftedContainer;
			}
			set
			{
				if (_itemCraftedContainer == value)
				{
					return;
				}
				_itemCraftedContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("itemBottomContainer")] 
		public inkWidgetReference ItemBottomContainer
		{
			get
			{
				if (_itemBottomContainer == null)
				{
					_itemBottomContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemBottomContainer", cr2w, this);
				}
				return _itemBottomContainer;
			}
			set
			{
				if (_itemBottomContainer == value)
				{
					return;
				}
				_itemBottomContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get
			{
				if (_descriptionWrapper == null)
				{
					_descriptionWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "descriptionWrapper", cr2w, this);
				}
				return _descriptionWrapper;
			}
			set
			{
				if (_descriptionWrapper == value)
				{
					return;
				}
				_descriptionWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get
			{
				if (_dEBUG_iconErrorWrapper == null)
				{
					_dEBUG_iconErrorWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "DEBUG_iconErrorWrapper", cr2w, this);
				}
				return _dEBUG_iconErrorWrapper;
			}
			set
			{
				if (_dEBUG_iconErrorWrapper == value)
				{
					return;
				}
				_dEBUG_iconErrorWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get
			{
				if (_dEBUG_iconErrorText == null)
				{
					_dEBUG_iconErrorText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "DEBUG_iconErrorText", cr2w, this);
				}
				return _dEBUG_iconErrorText;
			}
			set
			{
				if (_dEBUG_iconErrorText == value)
				{
					return;
				}
				_dEBUG_iconErrorText = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("itemEquippedController")] 
		public CHandle<ItemTooltipEquippedModule> ItemEquippedController
		{
			get
			{
				if (_itemEquippedController == null)
				{
					_itemEquippedController = (CHandle<ItemTooltipEquippedModule>) CR2WTypeManager.Create("handle:ItemTooltipEquippedModule", "itemEquippedController", cr2w, this);
				}
				return _itemEquippedController;
			}
			set
			{
				if (_itemEquippedController == value)
				{
					return;
				}
				_itemEquippedController = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("itemHeaderController")] 
		public CHandle<ItemTooltipHeaderController> ItemHeaderController
		{
			get
			{
				if (_itemHeaderController == null)
				{
					_itemHeaderController = (CHandle<ItemTooltipHeaderController>) CR2WTypeManager.Create("handle:ItemTooltipHeaderController", "itemHeaderController", cr2w, this);
				}
				return _itemHeaderController;
			}
			set
			{
				if (_itemHeaderController == value)
				{
					return;
				}
				_itemHeaderController = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("itemIconController")] 
		public CHandle<ItemTooltipIconModule> ItemIconController
		{
			get
			{
				if (_itemIconController == null)
				{
					_itemIconController = (CHandle<ItemTooltipIconModule>) CR2WTypeManager.Create("handle:ItemTooltipIconModule", "itemIconController", cr2w, this);
				}
				return _itemIconController;
			}
			set
			{
				if (_itemIconController == value)
				{
					return;
				}
				_itemIconController = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("itemWeaponInfoController")] 
		public CHandle<ItemTooltipWeaponInfoModule> ItemWeaponInfoController
		{
			get
			{
				if (_itemWeaponInfoController == null)
				{
					_itemWeaponInfoController = (CHandle<ItemTooltipWeaponInfoModule>) CR2WTypeManager.Create("handle:ItemTooltipWeaponInfoModule", "itemWeaponInfoController", cr2w, this);
				}
				return _itemWeaponInfoController;
			}
			set
			{
				if (_itemWeaponInfoController == value)
				{
					return;
				}
				_itemWeaponInfoController = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("itemClothingInfoController")] 
		public CHandle<ItemTooltipClothingInfoModule> ItemClothingInfoController
		{
			get
			{
				if (_itemClothingInfoController == null)
				{
					_itemClothingInfoController = (CHandle<ItemTooltipClothingInfoModule>) CR2WTypeManager.Create("handle:ItemTooltipClothingInfoModule", "itemClothingInfoController", cr2w, this);
				}
				return _itemClothingInfoController;
			}
			set
			{
				if (_itemClothingInfoController == value)
				{
					return;
				}
				_itemClothingInfoController = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("itemGrenadeInfoController")] 
		public CHandle<ItemTooltipGrenadeInfoModule> ItemGrenadeInfoController
		{
			get
			{
				if (_itemGrenadeInfoController == null)
				{
					_itemGrenadeInfoController = (CHandle<ItemTooltipGrenadeInfoModule>) CR2WTypeManager.Create("handle:ItemTooltipGrenadeInfoModule", "itemGrenadeInfoController", cr2w, this);
				}
				return _itemGrenadeInfoController;
			}
			set
			{
				if (_itemGrenadeInfoController == value)
				{
					return;
				}
				_itemGrenadeInfoController = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("itemRequirementsController")] 
		public CHandle<ItemTooltipRequirementsModule> ItemRequirementsController
		{
			get
			{
				if (_itemRequirementsController == null)
				{
					_itemRequirementsController = (CHandle<ItemTooltipRequirementsModule>) CR2WTypeManager.Create("handle:ItemTooltipRequirementsModule", "itemRequirementsController", cr2w, this);
				}
				return _itemRequirementsController;
			}
			set
			{
				if (_itemRequirementsController == value)
				{
					return;
				}
				_itemRequirementsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("itemDetailsController")] 
		public CHandle<ItemTooltipDetailsModule> ItemDetailsController
		{
			get
			{
				if (_itemDetailsController == null)
				{
					_itemDetailsController = (CHandle<ItemTooltipDetailsModule>) CR2WTypeManager.Create("handle:ItemTooltipDetailsModule", "itemDetailsController", cr2w, this);
				}
				return _itemDetailsController;
			}
			set
			{
				if (_itemDetailsController == value)
				{
					return;
				}
				_itemDetailsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("itemRecipeDataController")] 
		public CHandle<ItemTooltipRecipeDataModule> ItemRecipeDataController
		{
			get
			{
				if (_itemRecipeDataController == null)
				{
					_itemRecipeDataController = (CHandle<ItemTooltipRecipeDataModule>) CR2WTypeManager.Create("handle:ItemTooltipRecipeDataModule", "itemRecipeDataController", cr2w, this);
				}
				return _itemRecipeDataController;
			}
			set
			{
				if (_itemRecipeDataController == value)
				{
					return;
				}
				_itemRecipeDataController = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("itemEvolutionController")] 
		public CHandle<ItemTooltipEvolutionModule> ItemEvolutionController
		{
			get
			{
				if (_itemEvolutionController == null)
				{
					_itemEvolutionController = (CHandle<ItemTooltipEvolutionModule>) CR2WTypeManager.Create("handle:ItemTooltipEvolutionModule", "itemEvolutionController", cr2w, this);
				}
				return _itemEvolutionController;
			}
			set
			{
				if (_itemEvolutionController == value)
				{
					return;
				}
				_itemEvolutionController = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("itemCraftedController")] 
		public CHandle<ItemTooltipCraftedModule> ItemCraftedController
		{
			get
			{
				if (_itemCraftedController == null)
				{
					_itemCraftedController = (CHandle<ItemTooltipCraftedModule>) CR2WTypeManager.Create("handle:ItemTooltipCraftedModule", "itemCraftedController", cr2w, this);
				}
				return _itemCraftedController;
			}
			set
			{
				if (_itemCraftedController == value)
				{
					return;
				}
				_itemCraftedController = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("itemBottomController")] 
		public CHandle<ItemTooltipBottomModule> ItemBottomController
		{
			get
			{
				if (_itemBottomController == null)
				{
					_itemBottomController = (CHandle<ItemTooltipBottomModule>) CR2WTypeManager.Create("handle:ItemTooltipBottomModule", "itemBottomController", cr2w, this);
				}
				return _itemBottomController;
			}
			set
			{
				if (_itemBottomController == value)
				{
					return;
				}
				_itemBottomController = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get
			{
				if (_dEBUG_showAdditionalInfo == null)
				{
					_dEBUG_showAdditionalInfo = (CBool) CR2WTypeManager.Create("Bool", "DEBUG_showAdditionalInfo", cr2w, this);
				}
				return _dEBUG_showAdditionalInfo;
			}
			set
			{
				if (_dEBUG_showAdditionalInfo == value)
				{
					return;
				}
				_dEBUG_showAdditionalInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("data")] 
		public CHandle<MinimalItemTooltipData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<MinimalItemTooltipData>) CR2WTypeManager.Create("handle:MinimalItemTooltipData", "data", cr2w, this);
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

		[Ordinal(33)] 
		[RED("requestedModules")] 
		public CArray<CName> RequestedModules
		{
			get
			{
				if (_requestedModules == null)
				{
					_requestedModules = (CArray<CName>) CR2WTypeManager.Create("array:CName", "requestedModules", cr2w, this);
				}
				return _requestedModules;
			}
			set
			{
				if (_requestedModules == value)
				{
					return;
				}
				_requestedModules = value;
				PropertySet(this);
			}
		}

		public ItemTooltipCommonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
