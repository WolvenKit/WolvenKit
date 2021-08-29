using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorTerminalMasterInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		private CArray<gamePersistentID> _currentlyActiveDevices;

		[Ordinal(18)] 
		[RED("currentlyActiveDevices")] 
		public CArray<gamePersistentID> CurrentlyActiveDevices
		{
			get => GetProperty(ref _currentlyActiveDevices);
			set => SetProperty(ref _currentlyActiveDevices, value);
		}
	}
}
