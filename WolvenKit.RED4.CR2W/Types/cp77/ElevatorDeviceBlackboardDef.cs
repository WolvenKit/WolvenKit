using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_String _currentFloor;
		private gamebbScriptID_Bool _isPlayerScanned;
		private gamebbScriptID_Bool _isPaused;

		[Ordinal(7)] 
		[RED("CurrentFloor")] 
		public gamebbScriptID_String CurrentFloor
		{
			get => GetProperty(ref _currentFloor);
			set => SetProperty(ref _currentFloor, value);
		}

		[Ordinal(8)] 
		[RED("isPlayerScanned")] 
		public gamebbScriptID_Bool IsPlayerScanned
		{
			get => GetProperty(ref _isPlayerScanned);
			set => SetProperty(ref _isPlayerScanned, value);
		}

		[Ordinal(9)] 
		[RED("isPaused")] 
		public gamebbScriptID_Bool IsPaused
		{
			get => GetProperty(ref _isPaused);
			set => SetProperty(ref _isPaused, value);
		}

		public ElevatorDeviceBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
