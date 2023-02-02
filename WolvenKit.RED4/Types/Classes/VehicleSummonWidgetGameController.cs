using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleSummonWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("vehicleNameLabel")] 
		public inkTextWidgetReference VehicleNameLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("vehicleTypeIcon")] 
		public inkImageWidgetReference VehicleTypeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("vehicleManufactorHolder")] 
		public inkWidgetReference VehicleManufactorHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("vehicleManufactorIcon")] 
		public inkImageWidgetReference VehicleManufactorIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("distanceLabel")] 
		public inkTextWidgetReference DistanceLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("unit")] 
		public CEnum<EMeasurementUnit> Unit
		{
			get => GetPropertyValue<CEnum<EMeasurementUnit>>();
			set => SetPropertyValue<CEnum<EMeasurementUnit>>(value);
		}

		[Ordinal(15)] 
		[RED("subText")] 
		public inkTextWidgetReference SubText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("radioStationName")] 
		public inkTextWidgetReference RadioStationName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(19)] 
		[RED("animationCounterProxy")] 
		public CHandle<inkanimProxy> AnimationCounterProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(20)] 
		[RED("optionIntro")] 
		public inkanimPlaybackOptions OptionIntro
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(21)] 
		[RED("optionCounter")] 
		public inkanimPlaybackOptions OptionCounter
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(22)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get => GetPropertyValue<CHandle<VehicleSummonDataDef>>();
			set => SetPropertyValue<CHandle<VehicleSummonDataDef>>(value);
		}

		[Ordinal(23)] 
		[RED("vehicleSummonDataBB")] 
		public CWeakHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(24)] 
		[RED("vehicleSummonStateCallback")] 
		public CHandle<redCallbackObject> VehicleSummonStateCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("vehicleSummonState")] 
		public CUInt32 VehicleSummonState
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(26)] 
		[RED("vehiclePurchaseDataDef")] 
		public CHandle<VehiclePurchaseDataDef> VehiclePurchaseDataDef
		{
			get => GetPropertyValue<CHandle<VehiclePurchaseDataDef>>();
			set => SetPropertyValue<CHandle<VehiclePurchaseDataDef>>(value);
		}

		[Ordinal(27)] 
		[RED("vehiclePurchaseDataBB")] 
		public CWeakHandle<gameIBlackboard> VehiclePurchaseDataBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(28)] 
		[RED("vehiclePurchaseStateCallback")] 
		public CHandle<redCallbackObject> VehiclePurchaseStateCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("purchasedVehicleID")] 
		public TweakDBID PurchasedVehicleID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(30)] 
		[RED("stateChangesCallback")] 
		public CHandle<redCallbackObject> StateChangesCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("songNameChangeCallback")] 
		public CHandle<redCallbackObject> SongNameChangeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("activeVehicleBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(33)] 
		[RED("mountCallback")] 
		public CHandle<redCallbackObject> MountCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("vehiclePos")] 
		public Vector4 VehiclePos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(35)] 
		[RED("playerPos")] 
		public Vector4 PlayerPos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(36)] 
		[RED("distanceVector")] 
		public Vector4 DistanceVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(37)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(38)] 
		[RED("distance")] 
		public CInt32 Distance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(39)] 
		[RED("vehicleID")] 
		public entEntityID VehicleID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(40)] 
		[RED("vehicleEntity")] 
		public CWeakHandle<entEntity> VehicleEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(41)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(42)] 
		[RED("vehicleRecord")] 
		public CHandle<gamedataVehicle_Record> VehicleRecord
		{
			get => GetPropertyValue<CHandle<gamedataVehicle_Record>>();
			set => SetPropertyValue<CHandle<gamedataVehicle_Record>>(value);
		}

		[Ordinal(43)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(44)] 
		[RED("iconRecord")] 
		public CHandle<gamedataUIIcon_Record> IconRecord
		{
			get => GetPropertyValue<CHandle<gamedataUIIcon_Record>>();
			set => SetPropertyValue<CHandle<gamedataUIIcon_Record>>(value);
		}

		[Ordinal(45)] 
		[RED("playerVehicle")] 
		public CWeakHandle<vehicleBaseObject> PlayerVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(46)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public VehicleSummonWidgetGameController()
		{
			VehicleNameLabel = new();
			VehicleTypeIcon = new();
			VehicleManufactorHolder = new();
			VehicleManufactorIcon = new();
			DistanceLabel = new();
			SubText = new();
			RadioStationName = new();
			OptionIntro = new();
			OptionCounter = new();
			VehiclePos = new();
			PlayerPos = new();
			DistanceVector = new();
			GameInstance = new();
			VehicleID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
