using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventorySlotTooltip : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("itemCategory")] 
		public inkTextWidgetReference ItemCategory
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("itemPrice")] 
		public inkTextWidgetReference ItemPrice
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("lockedText")] 
		public inkTextWidgetReference LockedText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("requiredLevelText")] 
		public inkTextWidgetReference RequiredLevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("additionalStatsTextRef")] 
		public inkTextWidgetReference AdditionalStatsTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("equippedHeader")] 
		public inkWidgetReference EquippedHeader
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("primaryStatsList")] 
		public inkWidgetReference PrimaryStatsList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("comparedStatsList")] 
		public inkWidgetReference ComparedStatsList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("additionalStatsList")] 
		public inkWidgetReference AdditionalStatsList
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("itemPriceGroup")] 
		public inkWidgetReference ItemPriceGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("damageIndicator")] 
		public inkWidgetReference DamageIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("requiredLevelGroup")] 
		public inkWidgetReference RequiredLevelGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("damageIndicatorRef")] 
		public inkWidgetReference DamageIndicatorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("attachmentsListVertRef")] 
		public inkWidgetReference AttachmentsListVertRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("attachmentsCtrlHorRef")] 
		public inkWidgetReference AttachmentsCtrlHorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("specialAbilitiesListRef")] 
		public inkWidgetReference SpecialAbilitiesListRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("rarityBarRef")] 
		public inkWidgetReference RarityBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("elementsToSetRarityState")] 
		public CArray<inkWidgetReference> ElementsToSetRarityState
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(22)] 
		[RED("rarityElementsRefs")] 
		public CArray<inkImageWidgetReference> RarityElementsRefs
		{
			get => GetPropertyValue<CArray<inkImageWidgetReference>>();
			set => SetPropertyValue<CArray<inkImageWidgetReference>>(value);
		}

		[Ordinal(23)] 
		[RED("tooltipCycleIndicatorsContainer")] 
		public inkCompoundWidgetReference TooltipCycleIndicatorsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("tooltipCycleHintContainer")] 
		public inkCompoundWidgetReference TooltipCycleHintContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("primaryStatsCtrl")] 
		public CWeakHandle<InventoryItemStatList> PrimaryStatsCtrl
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemStatList>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemStatList>>(value);
		}

		[Ordinal(26)] 
		[RED("comparedStatsCtrl")] 
		public CWeakHandle<InventoryItemStatList> ComparedStatsCtrl
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemStatList>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemStatList>>(value);
		}

		[Ordinal(27)] 
		[RED("additionalStatsCtrl")] 
		public CWeakHandle<InventoryItemStatList> AdditionalStatsCtrl
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemStatList>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemStatList>>(value);
		}

		[Ordinal(28)] 
		[RED("attachmentsCtrlVert")] 
		public CWeakHandle<InventoryItemAttachmentsList> AttachmentsCtrlVert
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemAttachmentsList>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemAttachmentsList>>(value);
		}

		[Ordinal(29)] 
		[RED("attachmentsCtrlHor")] 
		public CWeakHandle<InventoryItemAttachmentsList> AttachmentsCtrlHor
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemAttachmentsList>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemAttachmentsList>>(value);
		}

		[Ordinal(30)] 
		[RED("damageTypeIndicator")] 
		public CWeakHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get => GetPropertyValue<CWeakHandle<DamageTypeIndicator>>();
			set => SetPropertyValue<CWeakHandle<DamageTypeIndicator>>(value);
		}

		[Ordinal(31)] 
		[RED("specialAbilitiesList")] 
		public CWeakHandle<TooltipSpecialAbilityList> SpecialAbilitiesList
		{
			get => GetPropertyValue<CWeakHandle<TooltipSpecialAbilityList>>();
			set => SetPropertyValue<CWeakHandle<TooltipSpecialAbilityList>>(value);
		}

		[Ordinal(32)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get => GetPropertyValue<CHandle<InventoryTooltipData>>();
			set => SetPropertyValue<CHandle<InventoryTooltipData>>(value);
		}

		[Ordinal(33)] 
		[RED("tooltipCycleHint")] 
		public CWeakHandle<ButtonHintListItem> TooltipCycleHint
		{
			get => GetPropertyValue<CWeakHandle<ButtonHintListItem>>();
			set => SetPropertyValue<CWeakHandle<ButtonHintListItem>>(value);
		}

		[Ordinal(34)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public InventorySlotTooltip()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
