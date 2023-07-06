using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleInteriorUIGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("vehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(10)] 
		[RED("vehicleBBStateConectionId")] 
		public CHandle<redCallbackObject> VehicleBBStateConectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("vehicleBBReadyConectionId")] 
		public CHandle<redCallbackObject> VehicleBBReadyConectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("vehicleBBUIActivId")] 
		public CHandle<redCallbackObject> VehicleBBUIActivId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("speedBBConnectionId")] 
		public CHandle<redCallbackObject> SpeedBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("gearBBConnectionId")] 
		public CHandle<redCallbackObject> GearBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(16)] 
		[RED("rpmMaxBBConnectionId")] 
		public CHandle<redCallbackObject> RpmMaxBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("autopilotOnId")] 
		public CHandle<redCallbackObject> AutopilotOnId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(18)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCanvasWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("speedTextWidget")] 
		public inkTextWidgetReference SpeedTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("gearTextWidget")] 
		public inkTextWidgetReference GearTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("rpmValueWidget")] 
		public inkTextWidgetReference RpmValueWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("rpmGaugeForegroundWidget")] 
		public inkRectangleWidgetReference RpmGaugeForegroundWidget
		{
			get => GetPropertyValue<inkRectangleWidgetReference>();
			set => SetPropertyValue<inkRectangleWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("autopilotTextWidget")] 
		public inkTextWidgetReference AutopilotTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("activeChunks")] 
		public CInt32 ActiveChunks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("chunksNumber")] 
		public CInt32 ChunksNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(26)] 
		[RED("dynamicRpmPath")] 
		public CName DynamicRpmPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("rpmPerChunk")] 
		public CInt32 RpmPerChunk
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(28)] 
		[RED("hasRevMax")] 
		public CBool HasRevMax
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("rpmGaugeMaxSize")] 
		public Vector2 RpmGaugeMaxSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(30)] 
		[RED("rpmMaxValue")] 
		public CFloat RpmMaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("isInAutoPilot")] 
		public CBool IsInAutoPilot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(32)] 
		[RED("isVehicleReady")] 
		public CBool IsVehicleReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("HudRedLineAnimation")] 
		public CHandle<inkanimProxy> HudRedLineAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public vehicleInteriorUIGameController()
		{
			SpeedTextWidget = new inkTextWidgetReference();
			GearTextWidget = new inkTextWidgetReference();
			RpmValueWidget = new inkTextWidgetReference();
			RpmGaugeForegroundWidget = new inkRectangleWidgetReference();
			AutopilotTextWidget = new inkTextWidgetReference();
			RpmGaugeMaxSize = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
