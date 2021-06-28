using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CarHotkeyController : GenericHotkeyController
	{
		private inkImageWidgetReference _carIconSlot;
		private wCHandle<gameVehicleSystem> _vehicleSystem;
		private CHandle<gameIBlackboard> _psmBB;
		private CUInt32 _bbListener;

		[Ordinal(19)] 
		[RED("carIconSlot")] 
		public inkImageWidgetReference CarIconSlot
		{
			get => GetProperty(ref _carIconSlot);
			set => SetProperty(ref _carIconSlot, value);
		}

		[Ordinal(20)] 
		[RED("vehicleSystem")] 
		public wCHandle<gameVehicleSystem> VehicleSystem
		{
			get => GetProperty(ref _vehicleSystem);
			set => SetProperty(ref _vehicleSystem, value);
		}

		[Ordinal(21)] 
		[RED("psmBB")] 
		public CHandle<gameIBlackboard> PsmBB
		{
			get => GetProperty(ref _psmBB);
			set => SetProperty(ref _psmBB, value);
		}

		[Ordinal(22)] 
		[RED("bbListener")] 
		public CUInt32 BbListener
		{
			get => GetProperty(ref _bbListener);
			set => SetProperty(ref _bbListener, value);
		}

		public CarHotkeyController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
