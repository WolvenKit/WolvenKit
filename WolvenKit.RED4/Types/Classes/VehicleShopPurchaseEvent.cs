using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleShopPurchaseEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("offerRecord")] 
		public CWeakHandle<gamedataVehicleOffer_Record> OfferRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataVehicleOffer_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataVehicleOffer_Record>>(value);
		}

		public VehicleShopPurchaseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
