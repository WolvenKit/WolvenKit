using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRemoteControlDrivingHUDGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("overlay")] 
		public inkWidgetReference Overlay
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("vehicleManufacturer")] 
		public inkImageWidgetReference VehicleManufacturer
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("containerSignalStrength")] 
		public inkWidgetReference ContainerSignalStrength
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("signalStrengthBarFill")] 
		public inkWidgetReference SignalStrengthBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("containerSignalStrengthIntroOutroAnimProxy")] 
		public CHandle<inkanimProxy> ContainerSignalStrengthIntroOutroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("weakSignalStrengthAnimProxy")] 
		public CHandle<inkanimProxy> WeakSignalStrengthAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(15)] 
		[RED("remoteControlledVehicleDataCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleDataCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("remoteControlledVehicleCameraChangedToTPPCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleCameraChangedToTPPCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("remoteControlledVehicle")] 
		public CWeakHandle<vehicleBaseObject> RemoteControlledVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(18)] 
		[RED("maxRemoteControlDrivingRange")] 
		public CFloat MaxRemoteControlDrivingRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetPropertyValue<gameNewMappinID>();
			set => SetPropertyValue<gameNewMappinID>(value);
		}

		public gameuiRemoteControlDrivingHUDGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
