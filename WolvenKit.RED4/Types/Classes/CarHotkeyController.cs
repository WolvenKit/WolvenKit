using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CarHotkeyController : GenericHotkeyController
	{
		[Ordinal(19)] 
		[RED("carIconSlot")] 
		public inkImageWidgetReference CarIconSlot
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("vehicleSystem")] 
		public CWeakHandle<gameVehicleSystem> VehicleSystem
		{
			get => GetPropertyValue<CWeakHandle<gameVehicleSystem>>();
			set => SetPropertyValue<CWeakHandle<gameVehicleSystem>>(value);
		}

		[Ordinal(21)] 
		[RED("psmBB")] 
		public CWeakHandle<gameIBlackboard> PsmBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(22)] 
		[RED("bbListener")] 
		public CHandle<redCallbackObject> BbListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public CarHotkeyController()
		{
			HotkeyBackground = new();
			ButtonHint = new();
			Restrictions = new();
			DebugCommands = new();
			CarIconSlot = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
