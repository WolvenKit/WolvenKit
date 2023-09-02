using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberdeckTooltip : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("rarityBars")] 
		public inkWidgetReference RarityBars
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("categoriesWrapper")] 
		public inkCompoundWidgetReference CategoriesWrapper
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("topContainer")] 
		public inkCompoundWidgetReference TopContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("headerContainer")] 
		public inkCompoundWidgetReference HeaderContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("descriptionContainer")] 
		public inkCompoundWidgetReference DescriptionContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("bottomContainer")] 
		public inkCompoundWidgetReference BottomContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("statsList")] 
		public inkCompoundWidgetReference StatsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("priceContainer")] 
		public inkCompoundWidgetReference PriceContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("equipedWrapper")] 
		public inkWidgetReference EquipedWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("itemWeightWrapper")] 
		public inkWidgetReference ItemWeightWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("itemWeightText")] 
		public inkTextWidgetReference ItemWeightText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("cybderdeckBaseMemoryValue")] 
		public inkTextWidgetReference CybderdeckBaseMemoryValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("cybderdeckBufferValue")] 
		public inkTextWidgetReference CybderdeckBufferValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("cybderdeckSlotsValue")] 
		public inkTextWidgetReference CybderdeckSlotsValue
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("deviceHacksGrid")] 
		public inkCompoundWidgetReference DeviceHacksGrid
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("itemIconImage")] 
		public inkImageWidgetReference ItemIconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("itemAttributeRequirements")] 
		public inkWidgetReference ItemAttributeRequirements
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("itemAttributeRequirementsText")] 
		public inkTextWidgetReference ItemAttributeRequirementsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("iconicLines")] 
		public inkImageWidgetReference IconicLines
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("rarityBarsController")] 
		public CWeakHandle<LevelBarsController> RarityBarsController
		{
			get => GetPropertyValue<CWeakHandle<LevelBarsController>>();
			set => SetPropertyValue<CWeakHandle<LevelBarsController>>(value);
		}

		[Ordinal(28)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get => GetPropertyValue<CHandle<InventoryTooltipData>>();
			set => SetPropertyValue<CHandle<InventoryTooltipData>>(value);
		}

		[Ordinal(29)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public CyberdeckTooltip()
		{
			ItemNameText = new inkTextWidgetReference();
			ItemRarityText = new inkTextWidgetReference();
			RarityBars = new inkWidgetReference();
			CategoriesWrapper = new inkCompoundWidgetReference();
			TopContainer = new inkCompoundWidgetReference();
			HeaderContainer = new inkCompoundWidgetReference();
			StatsContainer = new inkCompoundWidgetReference();
			DescriptionContainer = new inkCompoundWidgetReference();
			BottomContainer = new inkCompoundWidgetReference();
			StatsList = new inkCompoundWidgetReference();
			PriceContainer = new inkCompoundWidgetReference();
			DescriptionText = new inkTextWidgetReference();
			PriceText = new inkTextWidgetReference();
			EquipedWrapper = new inkWidgetReference();
			ItemTypeText = new inkTextWidgetReference();
			ItemWeightWrapper = new inkWidgetReference();
			ItemWeightText = new inkTextWidgetReference();
			CybderdeckBaseMemoryValue = new inkTextWidgetReference();
			CybderdeckBufferValue = new inkTextWidgetReference();
			CybderdeckSlotsValue = new inkTextWidgetReference();
			DeviceHacksGrid = new inkCompoundWidgetReference();
			ItemIconImage = new inkImageWidgetReference();
			ItemAttributeRequirements = new inkWidgetReference();
			ItemAttributeRequirementsText = new inkTextWidgetReference();
			IconicLines = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
