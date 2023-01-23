using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gametimeLogicController : IVehicleModuleController
	{
		[Ordinal(1)] 
		[RED("gametimeTextWidget")] 
		public inkTextWidgetReference GametimeTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("gametimeBBConnectionId")] 
		public CHandle<redCallbackObject> GametimeBBConnectionId
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

		[Ordinal(5)] 
		[RED("parent")] 
		public CWeakHandle<vehicleUIGameController> Parent
		{
			get => GetPropertyValue<CWeakHandle<vehicleUIGameController>>();
			set => SetPropertyValue<CWeakHandle<vehicleUIGameController>>(value);
		}

		public gametimeLogicController()
		{
			GametimeTextWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
