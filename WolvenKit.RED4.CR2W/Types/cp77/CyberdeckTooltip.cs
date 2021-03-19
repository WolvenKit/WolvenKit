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
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(3)] 
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get => GetProperty(ref _itemRarityText);
			set => SetProperty(ref _itemRarityText, value);
		}

		[Ordinal(4)] 
		[RED("rarityBars")] 
		public inkWidgetReference RarityBars
		{
			get => GetProperty(ref _rarityBars);
			set => SetProperty(ref _rarityBars, value);
		}

		[Ordinal(5)] 
		[RED("itemLevelText")] 
		public inkTextWidgetReference ItemLevelText
		{
			get => GetProperty(ref _itemLevelText);
			set => SetProperty(ref _itemLevelText, value);
		}

		[Ordinal(6)] 
		[RED("categoriesWrapper")] 
		public inkCompoundWidgetReference CategoriesWrapper
		{
			get => GetProperty(ref _categoriesWrapper);
			set => SetProperty(ref _categoriesWrapper, value);
		}

		[Ordinal(7)] 
		[RED("topContainer")] 
		public inkCompoundWidgetReference TopContainer
		{
			get => GetProperty(ref _topContainer);
			set => SetProperty(ref _topContainer, value);
		}

		[Ordinal(8)] 
		[RED("headerContainer")] 
		public inkCompoundWidgetReference HeaderContainer
		{
			get => GetProperty(ref _headerContainer);
			set => SetProperty(ref _headerContainer, value);
		}

		[Ordinal(9)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetProperty(ref _statsContainer);
			set => SetProperty(ref _statsContainer, value);
		}

		[Ordinal(10)] 
		[RED("descriptionContainer")] 
		public inkCompoundWidgetReference DescriptionContainer
		{
			get => GetProperty(ref _descriptionContainer);
			set => SetProperty(ref _descriptionContainer, value);
		}

		[Ordinal(11)] 
		[RED("bottomContainer")] 
		public inkCompoundWidgetReference BottomContainer
		{
			get => GetProperty(ref _bottomContainer);
			set => SetProperty(ref _bottomContainer, value);
		}

		[Ordinal(12)] 
		[RED("statsList")] 
		public inkCompoundWidgetReference StatsList
		{
			get => GetProperty(ref _statsList);
			set => SetProperty(ref _statsList, value);
		}

		[Ordinal(13)] 
		[RED("priceContainer")] 
		public inkCompoundWidgetReference PriceContainer
		{
			get => GetProperty(ref _priceContainer);
			set => SetProperty(ref _priceContainer, value);
		}

		[Ordinal(14)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(15)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(16)] 
		[RED("equipedWrapper")] 
		public inkWidgetReference EquipedWrapper
		{
			get => GetProperty(ref _equipedWrapper);
			set => SetProperty(ref _equipedWrapper, value);
		}

		[Ordinal(17)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get => GetProperty(ref _itemTypeText);
			set => SetProperty(ref _itemTypeText, value);
		}

		[Ordinal(18)] 
		[RED("itemWeightWrapper")] 
		public inkWidgetReference ItemWeightWrapper
		{
			get => GetProperty(ref _itemWeightWrapper);
			set => SetProperty(ref _itemWeightWrapper, value);
		}

		[Ordinal(19)] 
		[RED("itemWeightText")] 
		public inkTextWidgetReference ItemWeightText
		{
			get => GetProperty(ref _itemWeightText);
			set => SetProperty(ref _itemWeightText, value);
		}

		[Ordinal(20)] 
		[RED("cybderdeckBaseMemoryValue")] 
		public inkTextWidgetReference CybderdeckBaseMemoryValue
		{
			get => GetProperty(ref _cybderdeckBaseMemoryValue);
			set => SetProperty(ref _cybderdeckBaseMemoryValue, value);
		}

		[Ordinal(21)] 
		[RED("cybderdeckBufferValue")] 
		public inkTextWidgetReference CybderdeckBufferValue
		{
			get => GetProperty(ref _cybderdeckBufferValue);
			set => SetProperty(ref _cybderdeckBufferValue, value);
		}

		[Ordinal(22)] 
		[RED("cybderdeckSlotsValue")] 
		public inkTextWidgetReference CybderdeckSlotsValue
		{
			get => GetProperty(ref _cybderdeckSlotsValue);
			set => SetProperty(ref _cybderdeckSlotsValue, value);
		}

		[Ordinal(23)] 
		[RED("deviceHacksGrid")] 
		public inkCompoundWidgetReference DeviceHacksGrid
		{
			get => GetProperty(ref _deviceHacksGrid);
			set => SetProperty(ref _deviceHacksGrid, value);
		}

		[Ordinal(24)] 
		[RED("itemIconImage")] 
		public inkImageWidgetReference ItemIconImage
		{
			get => GetProperty(ref _itemIconImage);
			set => SetProperty(ref _itemIconImage, value);
		}

		[Ordinal(25)] 
		[RED("itemAttributeRequirements")] 
		public inkWidgetReference ItemAttributeRequirements
		{
			get => GetProperty(ref _itemAttributeRequirements);
			set => SetProperty(ref _itemAttributeRequirements, value);
		}

		[Ordinal(26)] 
		[RED("itemAttributeRequirementsText")] 
		public inkTextWidgetReference ItemAttributeRequirementsText
		{
			get => GetProperty(ref _itemAttributeRequirementsText);
			set => SetProperty(ref _itemAttributeRequirementsText, value);
		}

		[Ordinal(27)] 
		[RED("rarityBarsController")] 
		public CHandle<LevelBarsController> RarityBarsController
		{
			get => GetProperty(ref _rarityBarsController);
			set => SetProperty(ref _rarityBarsController, value);
		}

		[Ordinal(28)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(29)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public CyberdeckTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
