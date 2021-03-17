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
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(3)] 
		[RED("itemCategory")] 
		public inkTextWidgetReference ItemCategory
		{
			get => GetProperty(ref _itemCategory);
			set => SetProperty(ref _itemCategory, value);
		}

		[Ordinal(4)] 
		[RED("itemPrice")] 
		public inkTextWidgetReference ItemPrice
		{
			get => GetProperty(ref _itemPrice);
			set => SetProperty(ref _itemPrice, value);
		}

		[Ordinal(5)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(6)] 
		[RED("lockedText")] 
		public inkTextWidgetReference LockedText
		{
			get => GetProperty(ref _lockedText);
			set => SetProperty(ref _lockedText, value);
		}

		[Ordinal(7)] 
		[RED("requiredLevelText")] 
		public inkTextWidgetReference RequiredLevelText
		{
			get => GetProperty(ref _requiredLevelText);
			set => SetProperty(ref _requiredLevelText, value);
		}

		[Ordinal(8)] 
		[RED("additionalStatsTextRef")] 
		public inkTextWidgetReference AdditionalStatsTextRef
		{
			get => GetProperty(ref _additionalStatsTextRef);
			set => SetProperty(ref _additionalStatsTextRef, value);
		}

		[Ordinal(9)] 
		[RED("equippedHeader")] 
		public inkWidgetReference EquippedHeader
		{
			get => GetProperty(ref _equippedHeader);
			set => SetProperty(ref _equippedHeader, value);
		}

		[Ordinal(10)] 
		[RED("primaryStatsList")] 
		public inkWidgetReference PrimaryStatsList
		{
			get => GetProperty(ref _primaryStatsList);
			set => SetProperty(ref _primaryStatsList, value);
		}

		[Ordinal(11)] 
		[RED("comparedStatsList")] 
		public inkWidgetReference ComparedStatsList
		{
			get => GetProperty(ref _comparedStatsList);
			set => SetProperty(ref _comparedStatsList, value);
		}

		[Ordinal(12)] 
		[RED("additionalStatsList")] 
		public inkWidgetReference AdditionalStatsList
		{
			get => GetProperty(ref _additionalStatsList);
			set => SetProperty(ref _additionalStatsList, value);
		}

		[Ordinal(13)] 
		[RED("itemPriceGroup")] 
		public inkWidgetReference ItemPriceGroup
		{
			get => GetProperty(ref _itemPriceGroup);
			set => SetProperty(ref _itemPriceGroup, value);
		}

		[Ordinal(14)] 
		[RED("damageIndicator")] 
		public inkWidgetReference DamageIndicator
		{
			get => GetProperty(ref _damageIndicator);
			set => SetProperty(ref _damageIndicator, value);
		}

		[Ordinal(15)] 
		[RED("requiredLevelGroup")] 
		public inkWidgetReference RequiredLevelGroup
		{
			get => GetProperty(ref _requiredLevelGroup);
			set => SetProperty(ref _requiredLevelGroup, value);
		}

		[Ordinal(16)] 
		[RED("damageIndicatorRef")] 
		public inkWidgetReference DamageIndicatorRef
		{
			get => GetProperty(ref _damageIndicatorRef);
			set => SetProperty(ref _damageIndicatorRef, value);
		}

		[Ordinal(17)] 
		[RED("attachmentsListVertRef")] 
		public inkWidgetReference AttachmentsListVertRef
		{
			get => GetProperty(ref _attachmentsListVertRef);
			set => SetProperty(ref _attachmentsListVertRef, value);
		}

		[Ordinal(18)] 
		[RED("attachmentsCtrlHorRef")] 
		public inkWidgetReference AttachmentsCtrlHorRef
		{
			get => GetProperty(ref _attachmentsCtrlHorRef);
			set => SetProperty(ref _attachmentsCtrlHorRef, value);
		}

		[Ordinal(19)] 
		[RED("specialAbilitiesListRef")] 
		public inkWidgetReference SpecialAbilitiesListRef
		{
			get => GetProperty(ref _specialAbilitiesListRef);
			set => SetProperty(ref _specialAbilitiesListRef, value);
		}

		[Ordinal(20)] 
		[RED("rarityBarRef")] 
		public inkWidgetReference RarityBarRef
		{
			get => GetProperty(ref _rarityBarRef);
			set => SetProperty(ref _rarityBarRef, value);
		}

		[Ordinal(21)] 
		[RED("elementsToSetRarityState")] 
		public CArray<inkWidgetReference> ElementsToSetRarityState
		{
			get => GetProperty(ref _elementsToSetRarityState);
			set => SetProperty(ref _elementsToSetRarityState, value);
		}

		[Ordinal(22)] 
		[RED("rarityElementsRefs")] 
		public CArray<inkImageWidgetReference> RarityElementsRefs
		{
			get => GetProperty(ref _rarityElementsRefs);
			set => SetProperty(ref _rarityElementsRefs, value);
		}

		[Ordinal(23)] 
		[RED("tooltipCycleIndicatorsContainer")] 
		public inkCompoundWidgetReference TooltipCycleIndicatorsContainer
		{
			get => GetProperty(ref _tooltipCycleIndicatorsContainer);
			set => SetProperty(ref _tooltipCycleIndicatorsContainer, value);
		}

		[Ordinal(24)] 
		[RED("tooltipCycleHintContainer")] 
		public inkCompoundWidgetReference TooltipCycleHintContainer
		{
			get => GetProperty(ref _tooltipCycleHintContainer);
			set => SetProperty(ref _tooltipCycleHintContainer, value);
		}

		[Ordinal(25)] 
		[RED("primaryStatsCtrl")] 
		public wCHandle<InventoryItemStatList> PrimaryStatsCtrl
		{
			get => GetProperty(ref _primaryStatsCtrl);
			set => SetProperty(ref _primaryStatsCtrl, value);
		}

		[Ordinal(26)] 
		[RED("comparedStatsCtrl")] 
		public wCHandle<InventoryItemStatList> ComparedStatsCtrl
		{
			get => GetProperty(ref _comparedStatsCtrl);
			set => SetProperty(ref _comparedStatsCtrl, value);
		}

		[Ordinal(27)] 
		[RED("additionalStatsCtrl")] 
		public wCHandle<InventoryItemStatList> AdditionalStatsCtrl
		{
			get => GetProperty(ref _additionalStatsCtrl);
			set => SetProperty(ref _additionalStatsCtrl, value);
		}

		[Ordinal(28)] 
		[RED("attachmentsCtrlVert")] 
		public wCHandle<InventoryItemAttachmentsList> AttachmentsCtrlVert
		{
			get => GetProperty(ref _attachmentsCtrlVert);
			set => SetProperty(ref _attachmentsCtrlVert, value);
		}

		[Ordinal(29)] 
		[RED("attachmentsCtrlHor")] 
		public wCHandle<InventoryItemAttachmentsList> AttachmentsCtrlHor
		{
			get => GetProperty(ref _attachmentsCtrlHor);
			set => SetProperty(ref _attachmentsCtrlHor, value);
		}

		[Ordinal(30)] 
		[RED("damageTypeIndicator")] 
		public wCHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get => GetProperty(ref _damageTypeIndicator);
			set => SetProperty(ref _damageTypeIndicator, value);
		}

		[Ordinal(31)] 
		[RED("specialAbilitiesList")] 
		public wCHandle<TooltipSpecialAbilityList> SpecialAbilitiesList
		{
			get => GetProperty(ref _specialAbilitiesList);
			set => SetProperty(ref _specialAbilitiesList, value);
		}

		[Ordinal(32)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(33)] 
		[RED("tooltipCycleHint")] 
		public CHandle<ButtonHintListItem> TooltipCycleHint
		{
			get => GetProperty(ref _tooltipCycleHint);
			set => SetProperty(ref _tooltipCycleHint, value);
		}

		[Ordinal(34)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetProperty(ref _anim);
			set => SetProperty(ref _anim, value);
		}

		public InventorySlotTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
