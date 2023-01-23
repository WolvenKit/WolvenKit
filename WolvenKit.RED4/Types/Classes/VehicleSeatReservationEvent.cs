using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleSeatReservationEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("reserve")] 
		public CBool Reserve
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleSeatReservationEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
