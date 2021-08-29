using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CarHotkeyController : GenericHotkeyController
	{
		private inkImageWidgetReference _carIconSlot;
		private CWeakHandle<gameVehicleSystem> _vehicleSystem;
		private CWeakHandle<gameIBlackboard> _psmBB;
		private CHandle<redCallbackObject> _bbListener;

		[Ordinal(19)] 
		[RED("carIconSlot")] 
		public inkImageWidgetReference CarIconSlot
		{
			get => GetProperty(ref _carIconSlot);
			set => SetProperty(ref _carIconSlot, value);
		}

		[Ordinal(20)] 
		[RED("vehicleSystem")] 
		public CWeakHandle<gameVehicleSystem> VehicleSystem
		{
			get => GetProperty(ref _vehicleSystem);
			set => SetProperty(ref _vehicleSystem, value);
		}

		[Ordinal(21)] 
		[RED("psmBB")] 
		public CWeakHandle<gameIBlackboard> PsmBB
		{
			get => GetProperty(ref _psmBB);
			set => SetProperty(ref _psmBB, value);
		}

		[Ordinal(22)] 
		[RED("bbListener")] 
		public CHandle<redCallbackObject> BbListener
		{
			get => GetProperty(ref _bbListener);
			set => SetProperty(ref _bbListener, value);
		}
	}
}
