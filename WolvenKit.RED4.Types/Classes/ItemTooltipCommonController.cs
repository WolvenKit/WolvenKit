using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipCommonController : AGenericTooltipController
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
		private CWeakHandle<ItemTooltipEquippedModule> _itemEquippedController;
		private CWeakHandle<ItemTooltipHeaderController> _itemHeaderController;
		private CWeakHandle<ItemTooltipIconModule> _itemIconController;
		private CWeakHandle<ItemTooltipWeaponInfoModule> _itemWeaponInfoController;
		private CWeakHandle<ItemTooltipClothingInfoModule> _itemClothingInfoController;
		private CWeakHandle<ItemTooltipGrenadeInfoModule> _itemGrenadeInfoController;
		private CWeakHandle<ItemTooltipRequirementsModule> _itemRequirementsController;
		private CWeakHandle<ItemTooltipDetailsModule> _itemDetailsController;
		private CWeakHandle<ItemTooltipRecipeDataModule> _itemRecipeDataController;
		private CWeakHandle<ItemTooltipEvolutionModule> _itemEvolutionController;
		private CWeakHandle<ItemTooltipCraftedModule> _itemCraftedController;
		private CWeakHandle<ItemTooltipBottomModule> _itemBottomController;
		private CBool _dEBUG_showAdditionalInfo;
		private CHandle<MinimalItemTooltipData> _data;
		private CArray<CName> _requestedModules;

		[Ordinal(2)] 
		[RED("backgroundContainer")] 
		public inkWidgetReference BackgroundContainer
		{
			get => GetProperty(ref _backgroundContainer);
			set => SetProperty(ref _backgroundContainer, value);
		}

		[Ordinal(3)] 
		[RED("itemEquippedContainer")] 
		public inkWidgetReference ItemEquippedContainer
		{
			get => GetProperty(ref _itemEquippedContainer);
			set => SetProperty(ref _itemEquippedContainer, value);
		}

		[Ordinal(4)] 
		[RED("itemHeaderContainer")] 
		public inkWidgetReference ItemHeaderContainer
		{
			get => GetProperty(ref _itemHeaderContainer);
			set => SetProperty(ref _itemHeaderContainer, value);
		}

		[Ordinal(5)] 
		[RED("itemIconContainer")] 
		public inkWidgetReference ItemIconContainer
		{
			get => GetProperty(ref _itemIconContainer);
			set => SetProperty(ref _itemIconContainer, value);
		}

		[Ordinal(6)] 
		[RED("itemWeaponInfoContainer")] 
		public inkWidgetReference ItemWeaponInfoContainer
		{
			get => GetProperty(ref _itemWeaponInfoContainer);
			set => SetProperty(ref _itemWeaponInfoContainer, value);
		}

		[Ordinal(7)] 
		[RED("itemClothingInfoContainer")] 
		public inkWidgetReference ItemClothingInfoContainer
		{
			get => GetProperty(ref _itemClothingInfoContainer);
			set => SetProperty(ref _itemClothingInfoContainer, value);
		}

		[Ordinal(8)] 
		[RED("itemGrenadeInfoContainer")] 
		public inkWidgetReference ItemGrenadeInfoContainer
		{
			get => GetProperty(ref _itemGrenadeInfoContainer);
			set => SetProperty(ref _itemGrenadeInfoContainer, value);
		}

		[Ordinal(9)] 
		[RED("itemRequirementsContainer")] 
		public inkWidgetReference ItemRequirementsContainer
		{
			get => GetProperty(ref _itemRequirementsContainer);
			set => SetProperty(ref _itemRequirementsContainer, value);
		}

		[Ordinal(10)] 
		[RED("itemDetailsContainer")] 
		public inkWidgetReference ItemDetailsContainer
		{
			get => GetProperty(ref _itemDetailsContainer);
			set => SetProperty(ref _itemDetailsContainer, value);
		}

		[Ordinal(11)] 
		[RED("itemRecipeDataContainer")] 
		public inkWidgetReference ItemRecipeDataContainer
		{
			get => GetProperty(ref _itemRecipeDataContainer);
			set => SetProperty(ref _itemRecipeDataContainer, value);
		}

		[Ordinal(12)] 
		[RED("itemEvolutionContainer")] 
		public inkWidgetReference ItemEvolutionContainer
		{
			get => GetProperty(ref _itemEvolutionContainer);
			set => SetProperty(ref _itemEvolutionContainer, value);
		}

		[Ordinal(13)] 
		[RED("itemCraftedContainer")] 
		public inkWidgetReference ItemCraftedContainer
		{
			get => GetProperty(ref _itemCraftedContainer);
			set => SetProperty(ref _itemCraftedContainer, value);
		}

		[Ordinal(14)] 
		[RED("itemBottomContainer")] 
		public inkWidgetReference ItemBottomContainer
		{
			get => GetProperty(ref _itemBottomContainer);
			set => SetProperty(ref _itemBottomContainer, value);
		}

		[Ordinal(15)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetProperty(ref _descriptionWrapper);
			set => SetProperty(ref _descriptionWrapper, value);
		}

		[Ordinal(16)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(17)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetProperty(ref _dEBUG_iconErrorWrapper);
			set => SetProperty(ref _dEBUG_iconErrorWrapper, value);
		}

		[Ordinal(18)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetProperty(ref _dEBUG_iconErrorText);
			set => SetProperty(ref _dEBUG_iconErrorText, value);
		}

		[Ordinal(19)] 
		[RED("itemEquippedController")] 
		public CWeakHandle<ItemTooltipEquippedModule> ItemEquippedController
		{
			get => GetProperty(ref _itemEquippedController);
			set => SetProperty(ref _itemEquippedController, value);
		}

		[Ordinal(20)] 
		[RED("itemHeaderController")] 
		public CWeakHandle<ItemTooltipHeaderController> ItemHeaderController
		{
			get => GetProperty(ref _itemHeaderController);
			set => SetProperty(ref _itemHeaderController, value);
		}

		[Ordinal(21)] 
		[RED("itemIconController")] 
		public CWeakHandle<ItemTooltipIconModule> ItemIconController
		{
			get => GetProperty(ref _itemIconController);
			set => SetProperty(ref _itemIconController, value);
		}

		[Ordinal(22)] 
		[RED("itemWeaponInfoController")] 
		public CWeakHandle<ItemTooltipWeaponInfoModule> ItemWeaponInfoController
		{
			get => GetProperty(ref _itemWeaponInfoController);
			set => SetProperty(ref _itemWeaponInfoController, value);
		}

		[Ordinal(23)] 
		[RED("itemClothingInfoController")] 
		public CWeakHandle<ItemTooltipClothingInfoModule> ItemClothingInfoController
		{
			get => GetProperty(ref _itemClothingInfoController);
			set => SetProperty(ref _itemClothingInfoController, value);
		}

		[Ordinal(24)] 
		[RED("itemGrenadeInfoController")] 
		public CWeakHandle<ItemTooltipGrenadeInfoModule> ItemGrenadeInfoController
		{
			get => GetProperty(ref _itemGrenadeInfoController);
			set => SetProperty(ref _itemGrenadeInfoController, value);
		}

		[Ordinal(25)] 
		[RED("itemRequirementsController")] 
		public CWeakHandle<ItemTooltipRequirementsModule> ItemRequirementsController
		{
			get => GetProperty(ref _itemRequirementsController);
			set => SetProperty(ref _itemRequirementsController, value);
		}

		[Ordinal(26)] 
		[RED("itemDetailsController")] 
		public CWeakHandle<ItemTooltipDetailsModule> ItemDetailsController
		{
			get => GetProperty(ref _itemDetailsController);
			set => SetProperty(ref _itemDetailsController, value);
		}

		[Ordinal(27)] 
		[RED("itemRecipeDataController")] 
		public CWeakHandle<ItemTooltipRecipeDataModule> ItemRecipeDataController
		{
			get => GetProperty(ref _itemRecipeDataController);
			set => SetProperty(ref _itemRecipeDataController, value);
		}

		[Ordinal(28)] 
		[RED("itemEvolutionController")] 
		public CWeakHandle<ItemTooltipEvolutionModule> ItemEvolutionController
		{
			get => GetProperty(ref _itemEvolutionController);
			set => SetProperty(ref _itemEvolutionController, value);
		}

		[Ordinal(29)] 
		[RED("itemCraftedController")] 
		public CWeakHandle<ItemTooltipCraftedModule> ItemCraftedController
		{
			get => GetProperty(ref _itemCraftedController);
			set => SetProperty(ref _itemCraftedController, value);
		}

		[Ordinal(30)] 
		[RED("itemBottomController")] 
		public CWeakHandle<ItemTooltipBottomModule> ItemBottomController
		{
			get => GetProperty(ref _itemBottomController);
			set => SetProperty(ref _itemBottomController, value);
		}

		[Ordinal(31)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get => GetProperty(ref _dEBUG_showAdditionalInfo);
			set => SetProperty(ref _dEBUG_showAdditionalInfo, value);
		}

		[Ordinal(32)] 
		[RED("data")] 
		public CHandle<MinimalItemTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(33)] 
		[RED("requestedModules")] 
		public CArray<CName> RequestedModules
		{
			get => GetProperty(ref _requestedModules);
			set => SetProperty(ref _requestedModules, value);
		}
	}
}
