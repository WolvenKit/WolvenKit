using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorTerminalMasterInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		[Ordinal(18)] 
		[RED("currentlyActiveDevices")] 
		public CArray<gamePersistentID> CurrentlyActiveDevices
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		public DoorTerminalMasterInkGameControllerBase()
		{
			CurrentlyActiveDevices = new();
		}
	}
}
