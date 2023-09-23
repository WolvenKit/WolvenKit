using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CarHotkeyController : GenericHotkeyController
	{
		[Ordinal(23)] 
		[RED("carIconSlot")] 
		public inkImageWidgetReference CarIconSlot
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("vehicleSystem")] 
		public CWeakHandle<gameVehicleSystem> VehicleSystem
		{
			get => GetPropertyValue<CWeakHandle<gameVehicleSystem>>();
			set => SetPropertyValue<CWeakHandle<gameVehicleSystem>>(value);
		}

		[Ordinal(25)] 
		[RED("psmBB")] 
		public CWeakHandle<gameIBlackboard> PsmBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(26)] 
		[RED("bbListener")] 
		public CHandle<redCallbackObject> BbListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public CarHotkeyController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
