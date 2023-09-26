using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipCyberwareUpgradeController : ItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("componentsContainer")] 
		public inkCompoundWidgetReference ComponentsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("moneyContainer")] 
		public inkCompoundWidgetReference MoneyContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("moneyCostLabel")] 
		public inkTextWidgetReference MoneyCostLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("upgradeProgressBarRef")] 
		public inkWidgetReference UpgradeProgressBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("upgradeCWInputName")] 
		public CName UpgradeCWInputName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("progressEffectName")] 
		public CName ProgressEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("progressBarAnimName")] 
		public CName ProgressBarAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("ripperdocContainer")] 
		public inkCompoundWidgetReference RipperdocContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("inventoryContainer")] 
		public inkCompoundWidgetReference InventoryContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("inputHint")] 
		public inkWidgetReference InputHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("rarityLabel")] 
		public inkTextWidgetReference RarityLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("upgradeIconAnimName")] 
		public CName UpgradeIconAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("reqNotMetAnimName")] 
		public CName ReqNotMetAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("componentsController")] 
		public CWeakHandle<CrafringMaterialItemController> ComponentsController
		{
			get => GetPropertyValue<CWeakHandle<CrafringMaterialItemController>>();
			set => SetPropertyValue<CWeakHandle<CrafringMaterialItemController>>(value);
		}

		[Ordinal(20)] 
		[RED("craftingMaterial")] 
		public CHandle<CachedCraftingMaterial> CraftingMaterial
		{
			get => GetPropertyValue<CHandle<CachedCraftingMaterial>>();
			set => SetPropertyValue<CHandle<CachedCraftingMaterial>>(value);
		}

		[Ordinal(21)] 
		[RED("isUpgradable")] 
		public CBool IsUpgradable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("isUpgradeScreen")] 
		public CBool IsUpgradeScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("upgradeIconAnimProxy")] 
		public CHandle<inkanimProxy> UpgradeIconAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(24)] 
		[RED("upgradeIconAnimOptions")] 
		public inkanimPlaybackOptions UpgradeIconAnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(25)] 
		[RED("upgradeProgressBar")] 
		public CWeakHandle<inkWidget> UpgradeProgressBar
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(26)] 
		[RED("progressStarted")] 
		public CBool ProgressStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("progressBarAnimProxy")] 
		public CHandle<inkanimProxy> ProgressBarAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public ItemTooltipCyberwareUpgradeController()
		{
			ComponentsContainer = new inkCompoundWidgetReference();
			MoneyContainer = new inkCompoundWidgetReference();
			MoneyCostLabel = new inkTextWidgetReference();
			UpgradeProgressBarRef = new inkWidgetReference();
			UpgradeCWInputName = "upgrade_cyberware";
			ProgressEffectName = "progress";
			ProgressBarAnimName = "upgradeLoop";
			RipperdocContainer = new inkCompoundWidgetReference();
			InventoryContainer = new inkCompoundWidgetReference();
			InputHint = new inkWidgetReference();
			RarityLabel = new inkTextWidgetReference();
			ReqNotMetAnimName = "reqNotMet";
			UpgradeIconAnimOptions = new inkanimPlaybackOptions { CustomTimeDilation = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
