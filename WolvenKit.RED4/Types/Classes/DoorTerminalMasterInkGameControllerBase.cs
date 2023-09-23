using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorTerminalMasterInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		[Ordinal(20)] 
		[RED("currentlyActiveDevices")] 
		public CArray<gamePersistentID> CurrentlyActiveDevices
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		public DoorTerminalMasterInkGameControllerBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
