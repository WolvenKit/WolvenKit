using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleDetailsLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("backButton")] 
		public inkWidgetReference BackButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("purchaseButton")] 
		public inkWidgetReference PurchaseButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("ownedWidget")] 
		public inkWidgetReference OwnedWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("insufficientMoneyWidget")] 
		public inkWidgetReference InsufficientMoneyWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("detailsImage")] 
		public inkImageWidgetReference DetailsImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("vehicleNameText")] 
		public inkTextWidgetReference VehicleNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("detailsText")] 
		public inkTextWidgetReference DetailsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("gunImage")] 
		public inkImageWidgetReference GunImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("rocketImage")] 
		public inkImageWidgetReference RocketImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("custoImage")] 
		public inkImageWidgetReference CustoImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("priceWrapper")] 
		public inkWidgetReference PriceWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("discountWrapper")] 
		public inkWidgetReference DiscountWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("discountText")] 
		public inkTextWidgetReference DiscountText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("originalPriceWrapper")] 
		public inkWidgetReference OriginalPriceWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("originalPriceText")] 
		public inkTextWidgetReference OriginalPriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("discountImageWrapper")] 
		public inkWidgetReference DiscountImageWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("howToUnlockWrapper")] 
		public inkWidgetReference HowToUnlockWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("howToUnlockText")] 
		public inkTextWidgetReference HowToUnlockText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("offerRecord")] 
		public CWeakHandle<gamedataVehicleOffer_Record> OfferRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataVehicleOffer_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataVehicleOffer_Record>>(value);
		}

		[Ordinal(22)] 
		[RED("price")] 
		public CInt32 Price
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("discount")] 
		public CFloat Discount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public VehicleDetailsLogicController()
		{
			BackButton = new inkWidgetReference();
			PurchaseButton = new inkWidgetReference();
			OwnedWidget = new inkWidgetReference();
			InsufficientMoneyWidget = new inkWidgetReference();
			DetailsImage = new inkImageWidgetReference();
			VehicleNameText = new inkTextWidgetReference();
			DetailsText = new inkTextWidgetReference();
			ScrollControllerWidget = new inkWidgetReference();
			GunImage = new inkImageWidgetReference();
			RocketImage = new inkImageWidgetReference();
			CustoImage = new inkImageWidgetReference();
			PriceWrapper = new inkWidgetReference();
			PriceText = new inkTextWidgetReference();
			DiscountWrapper = new inkWidgetReference();
			DiscountText = new inkTextWidgetReference();
			OriginalPriceWrapper = new inkWidgetReference();
			OriginalPriceText = new inkTextWidgetReference();
			DiscountImageWrapper = new inkWidgetReference();
			HowToUnlockWrapper = new inkWidgetReference();
			HowToUnlockText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
