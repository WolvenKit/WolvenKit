using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GetOnWindowCombatDecorator : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("windowOpenEvent")] 
		public CHandle<VehicleExternalWindowRequestEvent> WindowOpenEvent
		{
			get => GetPropertyValue<CHandle<VehicleExternalWindowRequestEvent>>();
			set => SetPropertyValue<CHandle<VehicleExternalWindowRequestEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("mountInfo")] 
		public gamemountingMountingInfo MountInfo
		{
			get => GetPropertyValue<gamemountingMountingInfo>();
			set => SetPropertyValue<gamemountingMountingInfo>(value);
		}

		[Ordinal(2)] 
		[RED("vehicle")] 
		public CWeakHandle<gameObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public GetOnWindowCombatDecorator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
