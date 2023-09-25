using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class speedometerLogicController : IVehicleModuleController
	{
		[Ordinal(1)] 
		[RED("speedTextWidget")] 
		public inkTextWidgetReference SpeedTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(3)] 
		[RED("vehBB")] 
		public CWeakHandle<gameIBlackboard> VehBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(4)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		public speedometerLogicController()
		{
			SpeedTextWidget = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
