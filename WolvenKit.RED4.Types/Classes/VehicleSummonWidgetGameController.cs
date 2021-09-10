using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("vehicleManufactorIcon")] 
		public inkImageWidgetReference VehicleManufactorIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("distanceLabel")] 
		public inkTextWidgetReference DistanceLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("isWaiting")] 
		public inkTextWidgetReference IsWaiting
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
		[RED("unitText")] 
		public inkTextWidgetReference UnitText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("animationCounterProxy")] 
		public CHandle<inkanimProxy> AnimationCounterProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("optionIntro")] 
		public inkanimPlaybackOptions OptionIntro
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(19)] 
		[RED("optionCounter")] 
		public inkanimPlaybackOptions OptionCounter
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(20)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get => GetPropertyValue<CHandle<VehicleSummonDataDef>>();
			set => SetPropertyValue<CHandle<VehicleSummonDataDef>>(value);
		}

		[Ordinal(21)] 
		[RED("vehicleSummonDataBB")] 
		public CWeakHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(22)] 
		[RED("vehicleSummonStateCallback")] 
		public CHandle<redCallbackObject> VehicleSummonStateCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(23)] 
		[RED("vehicleSummonState")] 
		public CUInt32 VehicleSummonState
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(24)] 
		[RED("vehiclePos")] 
		public Vector4 VehiclePos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(25)] 
		[RED("playerPos")] 
		public Vector4 PlayerPos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(26)] 
		[RED("distanceVector")] 
		public Vector4 DistanceVector
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(27)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(28)] 
		[RED("distance")] 
		public CInt32 Distance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(29)] 
		[RED("vehicleID")] 
		public entEntityID VehicleID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(30)] 
		[RED("vehicleEntity")] 
		public CWeakHandle<entEntity> VehicleEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(31)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(32)] 
		[RED("vehicleRecord")] 
		public CHandle<gamedataVehicle_Record> VehicleRecord
		{
			get => GetPropertyValue<CHandle<gamedataVehicle_Record>>();
			set => SetPropertyValue<CHandle<gamedataVehicle_Record>>(value);
		}

		[Ordinal(33)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get => GetPropertyValue<CHandle<textTextParameterSet>>();
			set => SetPropertyValue<CHandle<textTextParameterSet>>(value);
		}

		[Ordinal(34)] 
		[RED("iconRecord")] 
		public CHandle<gamedataUIIcon_Record> IconRecord
		{
			get => GetPropertyValue<CHandle<gamedataUIIcon_Record>>();
			set => SetPropertyValue<CHandle<gamedataUIIcon_Record>>(value);
		}

		public VehicleSummonWidgetGameController()
		{
			VehicleNameLabel = new();
			VehicleTypeIcon = new();
			VehicleManufactorIcon = new();
			DistanceLabel = new();
			IsWaiting = new();
			UnitText = new();
			OptionIntro = new();
			OptionCounter = new();
			VehiclePos = new();
			PlayerPos = new();
			DistanceVector = new();
			GameInstance = new();
			VehicleID = new();
		}
	}
}
