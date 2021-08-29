using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleSummonWidgetGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _vehicleNameLabel;
		private inkImageWidgetReference _vehicleTypeIcon;
		private inkImageWidgetReference _vehicleManufactorIcon;
		private inkTextWidgetReference _distanceLabel;
		private inkTextWidgetReference _isWaiting;
		private CEnum<EMeasurementUnit> _unit;
		private inkTextWidgetReference _unitText;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _animationCounterProxy;
		private inkanimPlaybackOptions _optionIntro;
		private inkanimPlaybackOptions _optionCounter;
		private CHandle<VehicleSummonDataDef> _vehicleSummonDataDef;
		private CWeakHandle<gameIBlackboard> _vehicleSummonDataBB;
		private CHandle<redCallbackObject> _vehicleSummonStateCallback;
		private CUInt32 _vehicleSummonState;
		private Vector4 _vehiclePos;
		private Vector4 _playerPos;
		private Vector4 _distanceVector;
		private ScriptGameInstance _gameInstance;
		private CInt32 _distance;
		private entEntityID _vehicleID;
		private CWeakHandle<entEntity> _vehicleEntity;
		private CWeakHandle<vehicleBaseObject> _vehicle;
		private CHandle<gamedataVehicle_Record> _vehicleRecord;
		private CHandle<textTextParameterSet> _textParams;
		private CHandle<gamedataUIIcon_Record> _iconRecord;

		[Ordinal(9)] 
		[RED("vehicleNameLabel")] 
		public inkTextWidgetReference VehicleNameLabel
		{
			get => GetProperty(ref _vehicleNameLabel);
			set => SetProperty(ref _vehicleNameLabel, value);
		}

		[Ordinal(10)] 
		[RED("vehicleTypeIcon")] 
		public inkImageWidgetReference VehicleTypeIcon
		{
			get => GetProperty(ref _vehicleTypeIcon);
			set => SetProperty(ref _vehicleTypeIcon, value);
		}

		[Ordinal(11)] 
		[RED("vehicleManufactorIcon")] 
		public inkImageWidgetReference VehicleManufactorIcon
		{
			get => GetProperty(ref _vehicleManufactorIcon);
			set => SetProperty(ref _vehicleManufactorIcon, value);
		}

		[Ordinal(12)] 
		[RED("distanceLabel")] 
		public inkTextWidgetReference DistanceLabel
		{
			get => GetProperty(ref _distanceLabel);
			set => SetProperty(ref _distanceLabel, value);
		}

		[Ordinal(13)] 
		[RED("isWaiting")] 
		public inkTextWidgetReference IsWaiting
		{
			get => GetProperty(ref _isWaiting);
			set => SetProperty(ref _isWaiting, value);
		}

		[Ordinal(14)] 
		[RED("unit")] 
		public CEnum<EMeasurementUnit> Unit
		{
			get => GetProperty(ref _unit);
			set => SetProperty(ref _unit, value);
		}

		[Ordinal(15)] 
		[RED("unitText")] 
		public inkTextWidgetReference UnitText
		{
			get => GetProperty(ref _unitText);
			set => SetProperty(ref _unitText, value);
		}

		[Ordinal(16)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(17)] 
		[RED("animationCounterProxy")] 
		public CHandle<inkanimProxy> AnimationCounterProxy
		{
			get => GetProperty(ref _animationCounterProxy);
			set => SetProperty(ref _animationCounterProxy, value);
		}

		[Ordinal(18)] 
		[RED("optionIntro")] 
		public inkanimPlaybackOptions OptionIntro
		{
			get => GetProperty(ref _optionIntro);
			set => SetProperty(ref _optionIntro, value);
		}

		[Ordinal(19)] 
		[RED("optionCounter")] 
		public inkanimPlaybackOptions OptionCounter
		{
			get => GetProperty(ref _optionCounter);
			set => SetProperty(ref _optionCounter, value);
		}

		[Ordinal(20)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get => GetProperty(ref _vehicleSummonDataDef);
			set => SetProperty(ref _vehicleSummonDataDef, value);
		}

		[Ordinal(21)] 
		[RED("vehicleSummonDataBB")] 
		public CWeakHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get => GetProperty(ref _vehicleSummonDataBB);
			set => SetProperty(ref _vehicleSummonDataBB, value);
		}

		[Ordinal(22)] 
		[RED("vehicleSummonStateCallback")] 
		public CHandle<redCallbackObject> VehicleSummonStateCallback
		{
			get => GetProperty(ref _vehicleSummonStateCallback);
			set => SetProperty(ref _vehicleSummonStateCallback, value);
		}

		[Ordinal(23)] 
		[RED("vehicleSummonState")] 
		public CUInt32 VehicleSummonState
		{
			get => GetProperty(ref _vehicleSummonState);
			set => SetProperty(ref _vehicleSummonState, value);
		}

		[Ordinal(24)] 
		[RED("vehiclePos")] 
		public Vector4 VehiclePos
		{
			get => GetProperty(ref _vehiclePos);
			set => SetProperty(ref _vehiclePos, value);
		}

		[Ordinal(25)] 
		[RED("playerPos")] 
		public Vector4 PlayerPos
		{
			get => GetProperty(ref _playerPos);
			set => SetProperty(ref _playerPos, value);
		}

		[Ordinal(26)] 
		[RED("distanceVector")] 
		public Vector4 DistanceVector
		{
			get => GetProperty(ref _distanceVector);
			set => SetProperty(ref _distanceVector, value);
		}

		[Ordinal(27)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(28)] 
		[RED("distance")] 
		public CInt32 Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(29)] 
		[RED("vehicleID")] 
		public entEntityID VehicleID
		{
			get => GetProperty(ref _vehicleID);
			set => SetProperty(ref _vehicleID, value);
		}

		[Ordinal(30)] 
		[RED("vehicleEntity")] 
		public CWeakHandle<entEntity> VehicleEntity
		{
			get => GetProperty(ref _vehicleEntity);
			set => SetProperty(ref _vehicleEntity, value);
		}

		[Ordinal(31)] 
		[RED("vehicle")] 
		public CWeakHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(32)] 
		[RED("vehicleRecord")] 
		public CHandle<gamedataVehicle_Record> VehicleRecord
		{
			get => GetProperty(ref _vehicleRecord);
			set => SetProperty(ref _vehicleRecord, value);
		}

		[Ordinal(33)] 
		[RED("textParams")] 
		public CHandle<textTextParameterSet> TextParams
		{
			get => GetProperty(ref _textParams);
			set => SetProperty(ref _textParams, value);
		}

		[Ordinal(34)] 
		[RED("iconRecord")] 
		public CHandle<gamedataUIIcon_Record> IconRecord
		{
			get => GetProperty(ref _iconRecord);
			set => SetProperty(ref _iconRecord, value);
		}
	}
}
