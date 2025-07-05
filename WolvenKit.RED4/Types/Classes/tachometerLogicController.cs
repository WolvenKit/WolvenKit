using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class tachometerLogicController : IVehicleModuleController
	{
		[Ordinal(1)] 
		[RED("rpmValueWidget")] 
		public inkTextWidgetReference RpmValueWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("rpmGaugeForegroundWidget")] 
		public inkRectangleWidgetReference RpmGaugeForegroundWidget
		{
			get => GetPropertyValue<inkRectangleWidgetReference>();
			set => SetPropertyValue<inkRectangleWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("scaleX")] 
		public CBool ScaleX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("rpmValueBBConnectionId")] 
		public CHandle<redCallbackObject> RpmValueBBConnectionId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("vehBB")] 
		public CWeakHandle<gameIBlackboard> VehBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(6)] 
		[RED("rpmGaugeMaxSize")] 
		public Vector2 RpmGaugeMaxSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(7)] 
		[RED("rpmMaxValue")] 
		public CFloat RpmMaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("rpmMinValue")] 
		public CFloat RpmMinValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("currentRPM")] 
		public CInt32 CurrentRPM
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public tachometerLogicController()
		{
			RpmValueWidget = new inkTextWidgetReference();
			RpmGaugeForegroundWidget = new inkRectangleWidgetReference();
			RpmGaugeMaxSize = new Vector2();
			CurrentRPM = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
