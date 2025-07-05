using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class analogSpeedometerLogicController : IVehicleModuleController
	{
		[Ordinal(1)] 
		[RED("analogSpeedNeedleWidget")] 
		public inkWidgetReference AnalogSpeedNeedleWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("analogSpeedNeedleMinRotation")] 
		public CFloat AnalogSpeedNeedleMinRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("analogSpeedNeedleMaxRotation")] 
		public CFloat AnalogSpeedNeedleMaxRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("analogSpeedNeedleMaxValue")] 
		public CFloat AnalogSpeedNeedleMaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(6)] 
		[RED("vehBB")] 
		public CWeakHandle<gameIBlackboard> VehBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(7)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		public analogSpeedometerLogicController()
		{
			AnalogSpeedNeedleWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
