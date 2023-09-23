using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleRemoteControlDrivingUIData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("remoteControlledVehicle")] 
		public CWeakHandle<vehicleBaseObject> RemoteControlledVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(1)] 
		[RED("isDistanceDisconnect")] 
		public CBool IsDistanceDisconnect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleRemoteControlDrivingUIData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
