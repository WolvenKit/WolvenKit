using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleOfferLogicController : BaseButtonView
	{
		[Ordinal(5)] 
		[RED("vehicleImage")] 
		public inkImageWidgetReference VehicleImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("border")] 
		public inkWidgetReference Border
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("ownedIndicator")] 
		public inkWidgetReference OwnedIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
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
		[RED("priceTextWrapper")] 
		public inkWidgetReference PriceTextWrapper
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
		[RED("originalPriceTextWrapper")] 
		public inkWidgetReference OriginalPriceTextWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("originalPriceText")] 
		public inkTextWidgetReference OriginalPriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("discountedPriceTextWrapper")] 
		public inkWidgetReference DiscountedPriceTextWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("discountedPriceText")] 
		public inkTextWidgetReference DiscountedPriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("discountWrapper")] 
		public inkWidgetReference DiscountWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("discountText")] 
		public inkTextWidgetReference DiscountText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("discoutImage")] 
		public inkWidgetReference DiscoutImage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("offerRecord")] 
		public CWeakHandle<gamedataVehicleOffer_Record> OfferRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataVehicleOffer_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataVehicleOffer_Record>>(value);
		}

		[Ordinal(22)] 
		[RED("state")] 
		public CEnum<EVehicleOfferState> State
		{
			get => GetPropertyValue<CEnum<EVehicleOfferState>>();
			set => SetPropertyValue<CEnum<EVehicleOfferState>>(value);
		}

		[Ordinal(23)] 
		[RED("styleWidget")] 
		public CWeakHandle<inkWidget> StyleWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(24)] 
		[RED("discount")] 
		public CFloat Discount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("discountApplicable")] 
		public CBool DiscountApplicable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleOfferLogicController()
		{
			VehicleImage = new inkImageWidgetReference();
			Border = new inkWidgetReference();
			OwnedIndicator = new inkWidgetReference();
			NameText = new inkTextWidgetReference();
			GunImage = new inkImageWidgetReference();
			RocketImage = new inkImageWidgetReference();
			CustoImage = new inkImageWidgetReference();
			PriceTextWrapper = new inkWidgetReference();
			PriceText = new inkTextWidgetReference();
			OriginalPriceTextWrapper = new inkWidgetReference();
			OriginalPriceText = new inkTextWidgetReference();
			DiscountedPriceTextWrapper = new inkWidgetReference();
			DiscountedPriceText = new inkTextWidgetReference();
			DiscountWrapper = new inkWidgetReference();
			DiscountText = new inkTextWidgetReference();
			DiscoutImage = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
