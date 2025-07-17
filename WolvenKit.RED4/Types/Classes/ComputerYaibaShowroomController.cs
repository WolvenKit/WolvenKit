using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerYaibaShowroomController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("orderedFact")] 
		public CName OrderedFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("toBuyPageAnim")] 
		public CName ToBuyPageAnim
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("modelText")] 
		public inkTextWidgetReference ModelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("homePage")] 
		public inkWidgetReference HomePage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("buyButton")] 
		public inkWidgetReference BuyButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("buyPage")] 
		public inkWidgetReference BuyPage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("playerBalanceText")] 
		public inkTextWidgetReference PlayerBalanceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("detailsCanvas")] 
		public inkWidgetReference DetailsCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("speedometer")] 
		public inkImageWidgetReference Speedometer
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("orderButton")] 
		public inkWidgetReference OrderButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("backButton")] 
		public inkWidgetReference BackButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("wheelCoverCheckBox")] 
		public inkWidgetReference WheelCoverCheckBox
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("wheelRimsCheckBox")] 
		public inkWidgetReference WheelRimsCheckBox
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("brandingCheckBox")] 
		public inkWidgetReference BrandingCheckBox
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("backRestCheckBox")] 
		public inkWidgetReference BackRestCheckBox
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("wheelCoverPreview")] 
		public inkWidgetReference WheelCoverPreview
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("wheelRimsPreview")] 
		public inkWidgetReference WheelRimsPreview
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("brandingPreview")] 
		public inkWidgetReference BrandingPreview
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("backRestPreview")] 
		public inkWidgetReference BackRestPreview
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(22)] 
		[RED("orderButtonController")] 
		public CWeakHandle<YaibaButton> OrderButtonController
		{
			get => GetPropertyValue<CWeakHandle<YaibaButton>>();
			set => SetPropertyValue<CWeakHandle<YaibaButton>>(value);
		}

		[Ordinal(23)] 
		[RED("backButtonController")] 
		public CWeakHandle<YaibaButton> BackButtonController
		{
			get => GetPropertyValue<CWeakHandle<YaibaButton>>();
			set => SetPropertyValue<CWeakHandle<YaibaButton>>(value);
		}

		[Ordinal(24)] 
		[RED("wheelCoverCheckController")] 
		public CWeakHandle<CheckYaibaOption> WheelCoverCheckController
		{
			get => GetPropertyValue<CWeakHandle<CheckYaibaOption>>();
			set => SetPropertyValue<CWeakHandle<CheckYaibaOption>>(value);
		}

		[Ordinal(25)] 
		[RED("wheelRimsCheckController")] 
		public CWeakHandle<CheckYaibaOption> WheelRimsCheckController
		{
			get => GetPropertyValue<CWeakHandle<CheckYaibaOption>>();
			set => SetPropertyValue<CWeakHandle<CheckYaibaOption>>(value);
		}

		[Ordinal(26)] 
		[RED("brandingCheckController")] 
		public CWeakHandle<CheckYaibaOption> BrandingCheckController
		{
			get => GetPropertyValue<CWeakHandle<CheckYaibaOption>>();
			set => SetPropertyValue<CWeakHandle<CheckYaibaOption>>(value);
		}

		[Ordinal(27)] 
		[RED("backRestCheckController")] 
		public CWeakHandle<CheckYaibaOption> BackRestCheckController
		{
			get => GetPropertyValue<CWeakHandle<CheckYaibaOption>>();
			set => SetPropertyValue<CWeakHandle<CheckYaibaOption>>(value);
		}

		[Ordinal(28)] 
		[RED("wheelCoverFact")] 
		public CName WheelCoverFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(29)] 
		[RED("WheelRimsFact")] 
		public CName WheelRimsFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("BrandingFact")] 
		public CName BrandingFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("BackRestFact")] 
		public CName BackRestFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(32)] 
		[RED("isAnimated")] 
		public CBool IsAnimated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		public ComputerYaibaShowroomController()
		{
			ModelText = new inkTextWidgetReference();
			HomePage = new inkWidgetReference();
			BuyButton = new inkWidgetReference();
			BuyPage = new inkWidgetReference();
			PlayerBalanceText = new inkTextWidgetReference();
			DetailsCanvas = new inkWidgetReference();
			Speedometer = new inkImageWidgetReference();
			OrderButton = new inkWidgetReference();
			BackButton = new inkWidgetReference();
			WheelCoverCheckBox = new inkWidgetReference();
			WheelRimsCheckBox = new inkWidgetReference();
			BrandingCheckBox = new inkWidgetReference();
			BackRestCheckBox = new inkWidgetReference();
			WheelCoverPreview = new inkWidgetReference();
			WheelRimsPreview = new inkWidgetReference();
			BrandingPreview = new inkWidgetReference();
			BackRestPreview = new inkWidgetReference();
			WheelCoverFact = "mq060_muramasa_wheel_cover";
			WheelRimsFact = "mq060_muramasa_wheel_rims";
			BrandingFact = "mq060_muramasa_branding";
			BackRestFact = "mq060_muramasa_back_rest";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
