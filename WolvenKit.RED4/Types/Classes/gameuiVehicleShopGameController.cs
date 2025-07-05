using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiVehicleShopGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("homePage")] 
		public inkWidgetReference HomePage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("homePageMainText")] 
		public inkTextWidgetReference HomePageMainText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("rightSidePanel")] 
		public inkWidgetReference RightSidePanel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("headerImage")] 
		public inkWidgetReference HeaderImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("offersCanvas")] 
		public inkWidgetReference OffersCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("detailsCanvas")] 
		public inkWidgetReference DetailsCanvas
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("brandsListWidget")] 
		public inkCompoundWidgetReference BrandsListWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("offersGridWidget")] 
		public inkCompoundWidgetReference OffersGridWidget
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("headerText")] 
		public inkTextWidgetReference HeaderText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("playerBalanceText")] 
		public inkTextWidgetReference PlayerBalanceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("playerBalanceAnimator")] 
		public CWeakHandle<MoneyLabelController> PlayerBalanceAnimator
		{
			get => GetPropertyValue<CWeakHandle<MoneyLabelController>>();
			set => SetPropertyValue<CWeakHandle<MoneyLabelController>>(value);
		}

		[Ordinal(14)] 
		[RED("callback")] 
		public CHandle<VehicleShopPlayerBalanceCallback> Callback
		{
			get => GetPropertyValue<CHandle<VehicleShopPlayerBalanceCallback>>();
			set => SetPropertyValue<CHandle<VehicleShopPlayerBalanceCallback>>(value);
		}

		[Ordinal(15)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(16)] 
		[RED("uiScriptableSystem")] 
		public CWeakHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CWeakHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(17)] 
		[RED("brandButtons")] 
		public CArray<CWeakHandle<VehicleBrandFilterLogicController>> BrandButtons
		{
			get => GetPropertyValue<CArray<CWeakHandle<VehicleBrandFilterLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<VehicleBrandFilterLogicController>>>(value);
		}

		[Ordinal(18)] 
		[RED("offerButtons")] 
		public CArray<CWeakHandle<VehicleOfferLogicController>> OfferButtons
		{
			get => GetPropertyValue<CArray<CWeakHandle<VehicleOfferLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<VehicleOfferLogicController>>>(value);
		}

		[Ordinal(19)] 
		[RED("detailsController")] 
		public CWeakHandle<VehicleDetailsLogicController> DetailsController
		{
			get => GetPropertyValue<CWeakHandle<VehicleDetailsLogicController>>();
			set => SetPropertyValue<CWeakHandle<VehicleDetailsLogicController>>(value);
		}

		[Ordinal(20)] 
		[RED("currentBrandController")] 
		public CWeakHandle<VehicleBrandFilterLogicController> CurrentBrandController
		{
			get => GetPropertyValue<CWeakHandle<VehicleBrandFilterLogicController>>();
			set => SetPropertyValue<CWeakHandle<VehicleBrandFilterLogicController>>(value);
		}

		[Ordinal(21)] 
		[RED("discount")] 
		public CFloat Discount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("c_discountFactTDBID")] 
		public TweakDBID C_discountFactTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(23)] 
		[RED("c_discountValuesTDBID")] 
		public TweakDBID C_discountValuesTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameuiVehicleShopGameController()
		{
			HomePage = new inkWidgetReference();
			HomePageMainText = new inkTextWidgetReference();
			RightSidePanel = new inkWidgetReference();
			HeaderImage = new inkWidgetReference();
			OffersCanvas = new inkWidgetReference();
			DetailsCanvas = new inkWidgetReference();
			BrandsListWidget = new inkCompoundWidgetReference();
			OffersGridWidget = new inkCompoundWidgetReference();
			HeaderText = new inkTextWidgetReference();
			ScrollControllerWidget = new inkWidgetReference();
			PlayerBalanceText = new inkTextWidgetReference();
			BrandButtons = new();
			OfferButtons = new();
			C_discountFactTDBID = "RTDB.VehicleDiscountSettings.discountFact";
			C_discountValuesTDBID = "RTDB.VehicleDiscountSettings.discountValues";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
