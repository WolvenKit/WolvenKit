using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetOnWindowCombatDecorator : AIVehicleTaskAbstract
	{
		private CHandle<VehicleExternalWindowRequestEvent> _windowOpenEvent;
		private gamemountingMountingInfo _mountInfo;
		private wCHandle<gameObject> _vehicle;
		private CName _slotName;

		[Ordinal(0)] 
		[RED("windowOpenEvent")] 
		public CHandle<VehicleExternalWindowRequestEvent> WindowOpenEvent
		{
			get => GetProperty(ref _windowOpenEvent);
			set => SetProperty(ref _windowOpenEvent, value);
		}

		[Ordinal(1)] 
		[RED("mountInfo")] 
		public gamemountingMountingInfo MountInfo
		{
			get => GetProperty(ref _mountInfo);
			set => SetProperty(ref _mountInfo, value);
		}

		[Ordinal(2)] 
		[RED("vehicle")] 
		public wCHandle<gameObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(3)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		public GetOnWindowCombatDecorator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
