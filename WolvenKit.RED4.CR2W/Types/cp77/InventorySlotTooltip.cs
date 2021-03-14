using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventorySlotTooltip : AGenericTooltipController
	{
		private inkTextWidgetReference _itemName;
		private inkTextWidgetReference _itemCategory;
		private inkTextWidgetReference _itemPrice;
		private inkTextWidgetReference _descriptionText;
		private inkTextWidgetReference _lockedText;
		private inkTextWidgetReference _requiredLevelText;
		private inkTextWidgetReference _additionalStatsTextRef;
		private inkWidgetReference _equippedHeader;
		private inkWidgetReference _primaryStatsList;
		private inkWidgetReference _comparedStatsList;
		private inkWidgetReference _additionalStatsList;
		private inkWidgetReference _itemPriceGroup;
		private inkWidgetReference _damageIndicator;
		private inkWidgetReference _requiredLevelGroup;
		private inkWidgetReference _damageIndicatorRef;
		private inkWidgetReference _attachmentsListVertRef;
		private inkWidgetReference _attachmentsCtrlHorRef;
		private inkWidgetReference _specialAbilitiesListRef;
		private inkWidgetReference _rarityBarRef;
		private CArray<inkWidgetReference> _elementsToSetRarityState;
		private CArray<inkImageWidgetReference> _rarityElementsRefs;
		private inkCompoundWidgetReference _tooltipCycleIndicatorsContainer;
		private inkCompoundWidgetReference _tooltipCycleHintContainer;
		private wCHandle<InventoryItemStatList> _primaryStatsCtrl;
		private wCHandle<InventoryItemStatList> _comparedStatsCtrl;
		private wCHandle<InventoryItemStatList> _additionalStatsCtrl;
		private wCHandle<InventoryItemAttachmentsList> _attachmentsCtrlVert;
		private wCHandle<InventoryItemAttachmentsList> _attachmentsCtrlHor;
		private wCHandle<DamageTypeIndicator> _damageTypeIndicator;
		private wCHandle<TooltipSpecialAbilityList> _specialAbilitiesList;
		private CHandle<InventoryTooltipData> _data;
		private CHandle<ButtonHintListItem> _tooltipCycleHint;
		private CHandle<inkanimProxy> _anim;

		[Ordinal(2)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get
			{
				if (_itemName == null)
				{
					_itemName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemName", cr2w, this);
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

		[Ordinal(3)] 
		[RED("itemCategory")] 
		public inkTextWidgetReference ItemCategory
		{
			get
			{
				if (_itemCategory == null)
				{
					_itemCategory = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemCategory", cr2w, this);
				}
				return _itemCategory;
			}
			set
			{
				if (_itemCategory == value)
				{
					return;
				}
				_itemCategory = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("itemPrice")] 
		public inkTextWidgetReference ItemPrice
		{
			get
			{
				if (_itemPrice == null)
				{
					_itemPrice = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemPrice", cr2w, this);
				}
				return _itemPrice;
			}
			set
			{
				if (_itemPrice == value)
				{
					return;
				}
				_itemPrice = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("lockedText")] 
		public inkTextWidgetReference LockedText
		{
			get
			{
				if (_lockedText == null)
				{
					_lockedText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "lockedText", cr2w, this);
				}
				return _lockedText;
			}
			set
			{
				if (_lockedText == value)
				{
					return;
				}
				_lockedText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("requiredLevelText")] 
		public inkTextWidgetReference RequiredLevelText
		{
			get
			{
				if (_requiredLevelText == null)
				{
					_requiredLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "requiredLevelText", cr2w, this);
				}
				return _requiredLevelText;
			}
			set
			{
				if (_requiredLevelText == value)
				{
					return;
				}
				_requiredLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("additionalStatsTextRef")] 
		public inkTextWidgetReference AdditionalStatsTextRef
		{
			get
			{
				if (_additionalStatsTextRef == null)
				{
					_additionalStatsTextRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "additionalStatsTextRef", cr2w, this);
				}
				return _additionalStatsTextRef;
			}
			set
			{
				if (_additionalStatsTextRef == value)
				{
					return;
				}
				_additionalStatsTextRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("equippedHeader")] 
		public inkWidgetReference EquippedHeader
		{
			get
			{
				if (_equippedHeader == null)
				{
					_equippedHeader = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "equippedHeader", cr2w, this);
				}
				return _equippedHeader;
			}
			set
			{
				if (_equippedHeader == value)
				{
					return;
				}
				_equippedHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("primaryStatsList")] 
		public inkWidgetReference PrimaryStatsList
		{
			get
			{
				if (_primaryStatsList == null)
				{
					_primaryStatsList = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "primaryStatsList", cr2w, this);
				}
				return _primaryStatsList;
			}
			set
			{
				if (_primaryStatsList == value)
				{
					return;
				}
				_primaryStatsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("comparedStatsList")] 
		public inkWidgetReference ComparedStatsList
		{
			get
			{
				if (_comparedStatsList == null)
				{
					_comparedStatsList = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "comparedStatsList", cr2w, this);
				}
				return _comparedStatsList;
			}
			set
			{
				if (_comparedStatsList == value)
				{
					return;
				}
				_comparedStatsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("additionalStatsList")] 
		public inkWidgetReference AdditionalStatsList
		{
			get
			{
				if (_additionalStatsList == null)
				{
					_additionalStatsList = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "additionalStatsList", cr2w, this);
				}
				return _additionalStatsList;
			}
			set
			{
				if (_additionalStatsList == value)
				{
					return;
				}
				_additionalStatsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("itemPriceGroup")] 
		public inkWidgetReference ItemPriceGroup
		{
			get
			{
				if (_itemPriceGroup == null)
				{
					_itemPriceGroup = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "itemPriceGroup", cr2w, this);
				}
				return _itemPriceGroup;
			}
			set
			{
				if (_itemPriceGroup == value)
				{
					return;
				}
				_itemPriceGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("damageIndicator")] 
		public inkWidgetReference DamageIndicator
		{
			get
			{
				if (_damageIndicator == null)
				{
					_damageIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damageIndicator", cr2w, this);
				}
				return _damageIndicator;
			}
			set
			{
				if (_damageIndicator == value)
				{
					return;
				}
				_damageIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("requiredLevelGroup")] 
		public inkWidgetReference RequiredLevelGroup
		{
			get
			{
				if (_requiredLevelGroup == null)
				{
					_requiredLevelGroup = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "requiredLevelGroup", cr2w, this);
				}
				return _requiredLevelGroup;
			}
			set
			{
				if (_requiredLevelGroup == value)
				{
					return;
				}
				_requiredLevelGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("damageIndicatorRef")] 
		public inkWidgetReference DamageIndicatorRef
		{
			get
			{
				if (_damageIndicatorRef == null)
				{
					_damageIndicatorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damageIndicatorRef", cr2w, this);
				}
				return _damageIndicatorRef;
			}
			set
			{
				if (_damageIndicatorRef == value)
				{
					return;
				}
				_damageIndicatorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("attachmentsListVertRef")] 
		public inkWidgetReference AttachmentsListVertRef
		{
			get
			{
				if (_attachmentsListVertRef == null)
				{
					_attachmentsListVertRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attachmentsListVertRef", cr2w, this);
				}
				return _attachmentsListVertRef;
			}
			set
			{
				if (_attachmentsListVertRef == value)
				{
					return;
				}
				_attachmentsListVertRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("attachmentsCtrlHorRef")] 
		public inkWidgetReference AttachmentsCtrlHorRef
		{
			get
			{
				if (_attachmentsCtrlHorRef == null)
				{
					_attachmentsCtrlHorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attachmentsCtrlHorRef", cr2w, this);
				}
				return _attachmentsCtrlHorRef;
			}
			set
			{
				if (_attachmentsCtrlHorRef == value)
				{
					return;
				}
				_attachmentsCtrlHorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("specialAbilitiesListRef")] 
		public inkWidgetReference SpecialAbilitiesListRef
		{
			get
			{
				if (_specialAbilitiesListRef == null)
				{
					_specialAbilitiesListRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "specialAbilitiesListRef", cr2w, this);
				}
				return _specialAbilitiesListRef;
			}
			set
			{
				if (_specialAbilitiesListRef == value)
				{
					return;
				}
				_specialAbilitiesListRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("rarityBarRef")] 
		public inkWidgetReference RarityBarRef
		{
			get
			{
				if (_rarityBarRef == null)
				{
					_rarityBarRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rarityBarRef", cr2w, this);
				}
				return _rarityBarRef;
			}
			set
			{
				if (_rarityBarRef == value)
				{
					return;
				}
				_rarityBarRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("elementsToSetRarityState")] 
		public CArray<inkWidgetReference> ElementsToSetRarityState
		{
			get
			{
				if (_elementsToSetRarityState == null)
				{
					_elementsToSetRarityState = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "elementsToSetRarityState", cr2w, this);
				}
				return _elementsToSetRarityState;
			}
			set
			{
				if (_elementsToSetRarityState == value)
				{
					return;
				}
				_elementsToSetRarityState = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("rarityElementsRefs")] 
		public CArray<inkImageWidgetReference> RarityElementsRefs
		{
			get
			{
				if (_rarityElementsRefs == null)
				{
					_rarityElementsRefs = (CArray<inkImageWidgetReference>) CR2WTypeManager.Create("array:inkImageWidgetReference", "rarityElementsRefs", cr2w, this);
				}
				return _rarityElementsRefs;
			}
			set
			{
				if (_rarityElementsRefs == value)
				{
					return;
				}
				_rarityElementsRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("tooltipCycleIndicatorsContainer")] 
		public inkCompoundWidgetReference TooltipCycleIndicatorsContainer
		{
			get
			{
				if (_tooltipCycleIndicatorsContainer == null)
				{
					_tooltipCycleIndicatorsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "tooltipCycleIndicatorsContainer", cr2w, this);
				}
				return _tooltipCycleIndicatorsContainer;
			}
			set
			{
				if (_tooltipCycleIndicatorsContainer == value)
				{
					return;
				}
				_tooltipCycleIndicatorsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("tooltipCycleHintContainer")] 
		public inkCompoundWidgetReference TooltipCycleHintContainer
		{
			get
			{
				if (_tooltipCycleHintContainer == null)
				{
					_tooltipCycleHintContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "tooltipCycleHintContainer", cr2w, this);
				}
				return _tooltipCycleHintContainer;
			}
			set
			{
				if (_tooltipCycleHintContainer == value)
				{
					return;
				}
				_tooltipCycleHintContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("primaryStatsCtrl")] 
		public wCHandle<InventoryItemStatList> PrimaryStatsCtrl
		{
			get
			{
				if (_primaryStatsCtrl == null)
				{
					_primaryStatsCtrl = (wCHandle<InventoryItemStatList>) CR2WTypeManager.Create("whandle:InventoryItemStatList", "primaryStatsCtrl", cr2w, this);
				}
				return _primaryStatsCtrl;
			}
			set
			{
				if (_primaryStatsCtrl == value)
				{
					return;
				}
				_primaryStatsCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("comparedStatsCtrl")] 
		public wCHandle<InventoryItemStatList> ComparedStatsCtrl
		{
			get
			{
				if (_comparedStatsCtrl == null)
				{
					_comparedStatsCtrl = (wCHandle<InventoryItemStatList>) CR2WTypeManager.Create("whandle:InventoryItemStatList", "comparedStatsCtrl", cr2w, this);
				}
				return _comparedStatsCtrl;
			}
			set
			{
				if (_comparedStatsCtrl == value)
				{
					return;
				}
				_comparedStatsCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("additionalStatsCtrl")] 
		public wCHandle<InventoryItemStatList> AdditionalStatsCtrl
		{
			get
			{
				if (_additionalStatsCtrl == null)
				{
					_additionalStatsCtrl = (wCHandle<InventoryItemStatList>) CR2WTypeManager.Create("whandle:InventoryItemStatList", "additionalStatsCtrl", cr2w, this);
				}
				return _additionalStatsCtrl;
			}
			set
			{
				if (_additionalStatsCtrl == value)
				{
					return;
				}
				_additionalStatsCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("attachmentsCtrlVert")] 
		public wCHandle<InventoryItemAttachmentsList> AttachmentsCtrlVert
		{
			get
			{
				if (_attachmentsCtrlVert == null)
				{
					_attachmentsCtrlVert = (wCHandle<InventoryItemAttachmentsList>) CR2WTypeManager.Create("whandle:InventoryItemAttachmentsList", "attachmentsCtrlVert", cr2w, this);
				}
				return _attachmentsCtrlVert;
			}
			set
			{
				if (_attachmentsCtrlVert == value)
				{
					return;
				}
				_attachmentsCtrlVert = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("attachmentsCtrlHor")] 
		public wCHandle<InventoryItemAttachmentsList> AttachmentsCtrlHor
		{
			get
			{
				if (_attachmentsCtrlHor == null)
				{
					_attachmentsCtrlHor = (wCHandle<InventoryItemAttachmentsList>) CR2WTypeManager.Create("whandle:InventoryItemAttachmentsList", "attachmentsCtrlHor", cr2w, this);
				}
				return _attachmentsCtrlHor;
			}
			set
			{
				if (_attachmentsCtrlHor == value)
				{
					return;
				}
				_attachmentsCtrlHor = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("damageTypeIndicator")] 
		public wCHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get
			{
				if (_damageTypeIndicator == null)
				{
					_damageTypeIndicator = (wCHandle<DamageTypeIndicator>) CR2WTypeManager.Create("whandle:DamageTypeIndicator", "damageTypeIndicator", cr2w, this);
				}
				return _damageTypeIndicator;
			}
			set
			{
				if (_damageTypeIndicator == value)
				{
					return;
				}
				_damageTypeIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("specialAbilitiesList")] 
		public wCHandle<TooltipSpecialAbilityList> SpecialAbilitiesList
		{
			get
			{
				if (_specialAbilitiesList == null)
				{
					_specialAbilitiesList = (wCHandle<TooltipSpecialAbilityList>) CR2WTypeManager.Create("whandle:TooltipSpecialAbilityList", "specialAbilitiesList", cr2w, this);
				}
				return _specialAbilitiesList;
			}
			set
			{
				if (_specialAbilitiesList == value)
				{
					return;
				}
				_specialAbilitiesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
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

		[Ordinal(33)] 
		[RED("tooltipCycleHint")] 
		public CHandle<ButtonHintListItem> TooltipCycleHint
		{
			get
			{
				if (_tooltipCycleHint == null)
				{
					_tooltipCycleHint = (CHandle<ButtonHintListItem>) CR2WTypeManager.Create("handle:ButtonHintListItem", "tooltipCycleHint", cr2w, this);
				}
				return _tooltipCycleHint;
			}
			set
			{
				if (_tooltipCycleHint == value)
				{
					return;
				}
				_tooltipCycleHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get
			{
				if (_anim == null)
				{
					_anim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "anim", cr2w, this);
				}
				return _anim;
			}
			set
			{
				if (_anim == value)
				{
					return;
				}
				_anim = value;
				PropertySet(this);
			}
		}

		public InventorySlotTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
