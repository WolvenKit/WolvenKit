using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NcartDoorScreenInkController : NcartTrainInkControllerBase
	{
		[Ordinal(16)] 
		[RED("LinesList")] 
		public CArray<ncartDoorScreenLineDataDef> LinesList
		{
			get => GetPropertyValue<CArray<ncartDoorScreenLineDataDef>>();
			set => SetPropertyValue<CArray<ncartDoorScreenLineDataDef>>(value);
		}

		[Ordinal(17)] 
		[RED("ActiveLineFactName")] 
		public CName ActiveLineFactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("NextStationFactName")] 
		public CName NextStationFactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("MetroStoppingFactName")] 
		public CName MetroStoppingFactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("questsSystem")] 
		public CWeakHandle<questQuestsSystem> QuestsSystem
		{
			get => GetPropertyValue<CWeakHandle<questQuestsSystem>>();
			set => SetPropertyValue<CWeakHandle<questQuestsSystem>>(value);
		}

		[Ordinal(22)] 
		[RED("StopListenerId")] 
		public CUInt32 StopListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(23)] 
		[RED("NextStationListenerId")] 
		public CUInt32 NextStationListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(24)] 
		[RED("gameTimeCallback")] 
		public CHandle<redCallbackObject> GameTimeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("ncartTextLogo")] 
		public inkImageWidgetReference NcartTextLogo
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("timeWidget")] 
		public inkTextWidgetReference TimeWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("stationNameWidget")] 
		public inkTextWidgetReference StationNameWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("stationStatusWidget")] 
		public inkTextWidgetReference StationStatusWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("districtNameWidget")] 
		public inkTextWidgetReference DistrictNameWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("stationDistrictBackgroundColor")] 
		public inkImageWidgetReference StationDistrictBackgroundColor
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("weather_sun_widget")] 
		public inkImageWidgetReference Weather_sun_widget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("weather_cloud_a_widget")] 
		public inkImageWidgetReference Weather_cloud_a_widget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("weather_cloud_b_widget")] 
		public inkImageWidgetReference Weather_cloud_b_widget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("weather_rain_widget")] 
		public inkImageWidgetReference Weather_rain_widget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("speed_display")] 
		public inkTextWidgetReference Speed_display
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("speed_display_deco_1")] 
		public inkImageWidgetReference Speed_display_deco_1
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("speed_display_deco_2")] 
		public inkImageWidgetReference Speed_display_deco_2
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("speed_display_deco_3")] 
		public inkImageWidgetReference Speed_display_deco_3
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("speed_display_deco_4")] 
		public inkImageWidgetReference Speed_display_deco_4
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("cachedActiveLine")] 
		public CInt32 CachedActiveLine
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(41)] 
		[RED("cachedNextStation")] 
		public CInt32 CachedNextStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(42)] 
		[RED("cachedDistrict")] 
		public CEnum<ENcartDistricts> CachedDistrict
		{
			get => GetPropertyValue<CEnum<ENcartDistricts>>();
			set => SetPropertyValue<CEnum<ENcartDistricts>>(value);
		}

		[Ordinal(43)] 
		[RED("updateDistrictName")] 
		public CBool UpdateDistrictName
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("ownerObject")] 
		public CWeakHandle<vehicleBaseObject> OwnerObject
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(45)] 
		[RED("vehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(46)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(47)] 
		[RED("speedListner")] 
		public CHandle<redCallbackObject> SpeedListner
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(48)] 
		[RED("speedLastValue")] 
		public CFloat SpeedLastValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public NcartDoorScreenInkController()
		{
			LinesList = new();
			NcartTextLogo = new inkImageWidgetReference();
			TimeWidget = new inkTextWidgetReference();
			StationNameWidget = new inkTextWidgetReference();
			StationStatusWidget = new inkTextWidgetReference();
			DistrictNameWidget = new inkTextWidgetReference();
			StationDistrictBackgroundColor = new inkImageWidgetReference();
			Weather_sun_widget = new inkImageWidgetReference();
			Weather_cloud_a_widget = new inkImageWidgetReference();
			Weather_cloud_b_widget = new inkImageWidgetReference();
			Weather_rain_widget = new inkImageWidgetReference();
			Speed_display = new inkTextWidgetReference();
			Speed_display_deco_1 = new inkImageWidgetReference();
			Speed_display_deco_2 = new inkImageWidgetReference();
			Speed_display_deco_3 = new inkImageWidgetReference();
			Speed_display_deco_4 = new inkImageWidgetReference();
			CachedDistrict = Enums.ENcartDistricts.ERROR;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
