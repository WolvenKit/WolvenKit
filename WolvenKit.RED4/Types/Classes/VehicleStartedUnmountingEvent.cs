using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleStartedUnmountingEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("isMounting")] 
		public CBool IsMounting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("character")] 
		public CWeakHandle<gameObject> Character
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public VehicleStartedUnmountingEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
