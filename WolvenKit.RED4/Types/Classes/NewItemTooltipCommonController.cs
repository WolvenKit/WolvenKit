using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipCommonController : AGenericTooltipControllerWithDebug
	{
		[Ordinal(5)] 
		[RED("backgroundContainer")] 
		public inkWidgetReference BackgroundContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("itemEquippedContainer")] 
		public inkWidgetReference ItemEquippedContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("itemRecipeContainer")] 
		public inkWidgetReference ItemRecipeContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("itemHeaderContainer")] 
		public inkWidgetReference ItemHeaderContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("itemBrokenContainer")] 
		public inkWidgetReference ItemBrokenContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("itemWeaponBarsContainer")] 
		public inkWidgetReference ItemWeaponBarsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("itemRequirementsContainer")] 
		public inkWidgetReference ItemRequirementsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("itemDetailsStatsContainer")] 
		public inkWidgetReference ItemDetailsStatsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("itemDescriptionContainer")] 
		public inkWidgetReference ItemDescriptionContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("itemDetailsContainer")] 
		public inkWidgetReference ItemDetailsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("itemBottomContainer")] 
		public inkWidgetReference ItemBottomContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("cornerContainer")] 
		public inkWidgetReference CornerContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("root")] 
		public inkWidgetReference Root_312
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("iconicBG")] 
		public inkWidgetReference IconicBG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("recipeBG")] 
		public inkWidgetReference RecipeBG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("illegalBG")] 
		public inkWidgetReference IllegalBG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("frames")] 
		public CArray<inkWidgetReference> Frames
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(26)] 
		[RED("spawnedModules")] 
		public CArray<CWeakHandle<NewItemTooltipModuleController>> SpawnedModules
		{
			get => GetPropertyValue<CArray<CWeakHandle<NewItemTooltipModuleController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<NewItemTooltipModuleController>>>(value);
		}

		[Ordinal(27)] 
		[RED("itemEquippedController")] 
		public CWeakHandle<NewItemTooltipEquippedModule> ItemEquippedController
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipEquippedModule>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipEquippedModule>>(value);
		}

		[Ordinal(28)] 
		[RED("itemRecipeController")] 
		public CWeakHandle<NewItemTooltipRepiceModule> ItemRecipeController
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipRepiceModule>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipRepiceModule>>(value);
		}

		[Ordinal(29)] 
		[RED("itemHeaderController")] 
		public CWeakHandle<NewItemTooltipHeaderController> ItemHeaderController
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipHeaderController>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipHeaderController>>(value);
		}

		[Ordinal(30)] 
		[RED("itemBrokenController")] 
		public CWeakHandle<NewItemTooltipBrokenModule> ItemBrokenController
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipBrokenModule>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipBrokenModule>>(value);
		}

		[Ordinal(31)] 
		[RED("itemWeaponBarsController")] 
		public CWeakHandle<NewItemTooltipWeaponBarsModule> ItemWeaponBarsController
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipWeaponBarsModule>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipWeaponBarsModule>>(value);
		}

		[Ordinal(32)] 
		[RED("itemRequirementsController")] 
		public CWeakHandle<NewItemTooltipRequirementsModule> ItemRequirementsController
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipRequirementsModule>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipRequirementsModule>>(value);
		}

		[Ordinal(33)] 
		[RED("itemDetailsStatsController")] 
		public CWeakHandle<NewItemTooltipDetailsStatsModule> ItemDetailsStatsController
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipDetailsStatsModule>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipDetailsStatsModule>>(value);
		}

		[Ordinal(34)] 
		[RED("itemDescriptionController")] 
		public CWeakHandle<NewItemTooltipDescriptionModule> ItemDescriptionController
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipDescriptionModule>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipDescriptionModule>>(value);
		}

		[Ordinal(35)] 
		[RED("itemDetailsController")] 
		public CWeakHandle<NewItemTooltipDetailsModule> ItemDetailsController
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipDetailsModule>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipDetailsModule>>(value);
		}

		[Ordinal(36)] 
		[RED("itemBottomController")] 
		public CWeakHandle<NewItemTooltipBottomModule> ItemBottomController
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipBottomModule>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipBottomModule>>(value);
		}

		[Ordinal(37)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("data")] 
		public CHandle<MinimalItemTooltipData> Data
		{
			get => GetPropertyValue<CHandle<MinimalItemTooltipData>>();
			set => SetPropertyValue<CHandle<MinimalItemTooltipData>>(value);
		}

		[Ordinal(39)] 
		[RED("itemData")] 
		public CHandle<UIInventoryItem> ItemData
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(40)] 
		[RED("comparisonData")] 
		public CHandle<UIInventoryItemComparisonManager> ComparisonData
		{
			get => GetPropertyValue<CHandle<UIInventoryItemComparisonManager>>();
			set => SetPropertyValue<CHandle<UIInventoryItemComparisonManager>>(value);
		}

		[Ordinal(41)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(42)] 
		[RED("requestedModules")] 
		public CArray<CName> RequestedModules
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(43)] 
		[RED("pendingModules")] 
		public CArray<CName> PendingModules
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(44)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(45)] 
		[RED("tooltipDisplayContext")] 
		public CEnum<InventoryTooltipDisplayContext> TooltipDisplayContext
		{
			get => GetPropertyValue<CEnum<InventoryTooltipDisplayContext>>();
			set => SetPropertyValue<CEnum<InventoryTooltipDisplayContext>>(value);
		}

		[Ordinal(46)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetPropertyValue<CEnum<gameItemDisplayContext>>();
			set => SetPropertyValue<CEnum<gameItemDisplayContext>>(value);
		}

		[Ordinal(47)] 
		[RED("priceOverride")] 
		public CInt32 PriceOverride
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(48)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(49)] 
		[RED("settingsListener")] 
		public CHandle<NewItemTooltipSettingsListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<NewItemTooltipSettingsListener>>();
			set => SetPropertyValue<CHandle<NewItemTooltipSettingsListener>>(value);
		}

		[Ordinal(50)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(51)] 
		[RED("minWidth")] 
		public inkWidgetReference MinWidth
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(53)] 
		[RED("inCrafting")] 
		public CBool InCrafting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NewItemTooltipCommonController()
		{
			BackgroundContainer = new inkWidgetReference();
			ItemEquippedContainer = new inkWidgetReference();
			ItemRecipeContainer = new inkWidgetReference();
			ItemHeaderContainer = new inkWidgetReference();
			ItemBrokenContainer = new inkWidgetReference();
			ItemWeaponBarsContainer = new inkWidgetReference();
			ItemRequirementsContainer = new inkWidgetReference();
			ItemDetailsStatsContainer = new inkWidgetReference();
			ItemDescriptionContainer = new inkWidgetReference();
			ItemDetailsContainer = new inkWidgetReference();
			ItemBottomContainer = new inkWidgetReference();
			CornerContainer = new inkWidgetReference();
			Root_312 = new inkWidgetReference();
			IconicBG = new inkWidgetReference();
			RecipeBG = new inkWidgetReference();
			IllegalBG = new inkWidgetReference();
			DescriptionWrapper = new inkWidgetReference();
			DescriptionText = new inkTextWidgetReference();
			DEBUG_iconErrorWrapper = new inkWidgetReference();
			DEBUG_iconErrorText = new inkTextWidgetReference();
			Frames = new();
			SpawnedModules = new();
			RequestedModules = new();
			PendingModules = new();
			GroupPath = "/accessibility/interface";
			MinWidth = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
