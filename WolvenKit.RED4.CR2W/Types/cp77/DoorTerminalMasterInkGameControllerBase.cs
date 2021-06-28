using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DoorTerminalMasterInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		private CArray<gamePersistentID> _currentlyActiveDevices;

		[Ordinal(18)] 
		[RED("currentlyActiveDevices")] 
		public CArray<gamePersistentID> CurrentlyActiveDevices
		{
			get => GetProperty(ref _currentlyActiveDevices);
			set => SetProperty(ref _currentlyActiveDevices, value);
		}

		public DoorTerminalMasterInkGameControllerBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
