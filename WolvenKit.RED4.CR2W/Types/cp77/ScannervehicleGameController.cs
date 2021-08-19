using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannervehicleGameController : BaseChunkGameController
	{
		private CHandle<redCallbackObject> _vehicleNameCallbackID;
		private CHandle<redCallbackObject> _vehicleManufacturerCallbackID;
		private CHandle<redCallbackObject> _vehicleProdYearsCallbackID;
		private CHandle<redCallbackObject> _vehicleDriveLayoutCallbackID;
		private CHandle<redCallbackObject> _vehicleHorsepowerCallbackID;
		private CHandle<redCallbackObject> _vehicleMassCallbackID;
		private CHandle<redCallbackObject> _vehicleStateCallbackID;
		private CHandle<redCallbackObject> _vehicleInfoCallbackID;
		private CBool _isValidVehicleManufacturer;
		private CBool _isValidVehicleName;
		private CBool _isValidVehicleProdYears;
		private CBool _isValidVehicleDriveLayout;
		private CBool _isValidVehicleHorsepower;
		private CBool _isValidVehicleMass;
		private CBool _isValidVehicleState;
		private CBool _isValidVehicleInfo;
		private inkTextWidgetReference _vehicleNameText;
		private inkImageWidgetReference _vehicleManufacturer;
		private inkTextWidgetReference _vehicleProdYearsText;
		private inkTextWidgetReference _vehicleDriveLayoutText;
		private inkTextWidgetReference _vehicleHorsepowerText;
		private inkTextWidgetReference _vehicleMassText;
		private inkTextWidgetReference _vehicleStateText;
		private inkTextWidgetReference _vehicleInfoText;
		private inkWidgetReference _vehicleNameHolder;
		private inkWidgetReference _vehicleProdYearsHolder;
		private inkWidgetReference _vehicleDriveLayoutHolder;
		private inkWidgetReference _vehicleHorsepowerHolder;
		private inkWidgetReference _vehicleMassHolder;
		private inkWidgetReference _vehicleStateHolder;
		private inkWidgetReference _vehicleInfoHolder;

		[Ordinal(5)] 
		[RED("vehicleNameCallbackID")] 
		public CHandle<redCallbackObject> VehicleNameCallbackID
		{
			get => GetProperty(ref _vehicleNameCallbackID);
			set => SetProperty(ref _vehicleNameCallbackID, value);
		}

		[Ordinal(6)] 
		[RED("vehicleManufacturerCallbackID")] 
		public CHandle<redCallbackObject> VehicleManufacturerCallbackID
		{
			get => GetProperty(ref _vehicleManufacturerCallbackID);
			set => SetProperty(ref _vehicleManufacturerCallbackID, value);
		}

		[Ordinal(7)] 
		[RED("vehicleProdYearsCallbackID")] 
		public CHandle<redCallbackObject> VehicleProdYearsCallbackID
		{
			get => GetProperty(ref _vehicleProdYearsCallbackID);
			set => SetProperty(ref _vehicleProdYearsCallbackID, value);
		}

		[Ordinal(8)] 
		[RED("vehicleDriveLayoutCallbackID")] 
		public CHandle<redCallbackObject> VehicleDriveLayoutCallbackID
		{
			get => GetProperty(ref _vehicleDriveLayoutCallbackID);
			set => SetProperty(ref _vehicleDriveLayoutCallbackID, value);
		}

		[Ordinal(9)] 
		[RED("vehicleHorsepowerCallbackID")] 
		public CHandle<redCallbackObject> VehicleHorsepowerCallbackID
		{
			get => GetProperty(ref _vehicleHorsepowerCallbackID);
			set => SetProperty(ref _vehicleHorsepowerCallbackID, value);
		}

		[Ordinal(10)] 
		[RED("vehicleMassCallbackID")] 
		public CHandle<redCallbackObject> VehicleMassCallbackID
		{
			get => GetProperty(ref _vehicleMassCallbackID);
			set => SetProperty(ref _vehicleMassCallbackID, value);
		}

		[Ordinal(11)] 
		[RED("vehicleStateCallbackID")] 
		public CHandle<redCallbackObject> VehicleStateCallbackID
		{
			get => GetProperty(ref _vehicleStateCallbackID);
			set => SetProperty(ref _vehicleStateCallbackID, value);
		}

		[Ordinal(12)] 
		[RED("vehicleInfoCallbackID")] 
		public CHandle<redCallbackObject> VehicleInfoCallbackID
		{
			get => GetProperty(ref _vehicleInfoCallbackID);
			set => SetProperty(ref _vehicleInfoCallbackID, value);
		}

		[Ordinal(13)] 
		[RED("isValidVehicleManufacturer")] 
		public CBool IsValidVehicleManufacturer
		{
			get => GetProperty(ref _isValidVehicleManufacturer);
			set => SetProperty(ref _isValidVehicleManufacturer, value);
		}

		[Ordinal(14)] 
		[RED("isValidVehicleName")] 
		public CBool IsValidVehicleName
		{
			get => GetProperty(ref _isValidVehicleName);
			set => SetProperty(ref _isValidVehicleName, value);
		}

		[Ordinal(15)] 
		[RED("isValidVehicleProdYears")] 
		public CBool IsValidVehicleProdYears
		{
			get => GetProperty(ref _isValidVehicleProdYears);
			set => SetProperty(ref _isValidVehicleProdYears, value);
		}

		[Ordinal(16)] 
		[RED("isValidVehicleDriveLayout")] 
		public CBool IsValidVehicleDriveLayout
		{
			get => GetProperty(ref _isValidVehicleDriveLayout);
			set => SetProperty(ref _isValidVehicleDriveLayout, value);
		}

		[Ordinal(17)] 
		[RED("isValidVehicleHorsepower")] 
		public CBool IsValidVehicleHorsepower
		{
			get => GetProperty(ref _isValidVehicleHorsepower);
			set => SetProperty(ref _isValidVehicleHorsepower, value);
		}

		[Ordinal(18)] 
		[RED("isValidVehicleMass")] 
		public CBool IsValidVehicleMass
		{
			get => GetProperty(ref _isValidVehicleMass);
			set => SetProperty(ref _isValidVehicleMass, value);
		}

		[Ordinal(19)] 
		[RED("isValidVehicleState")] 
		public CBool IsValidVehicleState
		{
			get => GetProperty(ref _isValidVehicleState);
			set => SetProperty(ref _isValidVehicleState, value);
		}

		[Ordinal(20)] 
		[RED("isValidVehicleInfo")] 
		public CBool IsValidVehicleInfo
		{
			get => GetProperty(ref _isValidVehicleInfo);
			set => SetProperty(ref _isValidVehicleInfo, value);
		}

		[Ordinal(21)] 
		[RED("vehicleNameText")] 
		public inkTextWidgetReference VehicleNameText
		{
			get => GetProperty(ref _vehicleNameText);
			set => SetProperty(ref _vehicleNameText, value);
		}

		[Ordinal(22)] 
		[RED("vehicleManufacturer")] 
		public inkImageWidgetReference VehicleManufacturer
		{
			get => GetProperty(ref _vehicleManufacturer);
			set => SetProperty(ref _vehicleManufacturer, value);
		}

		[Ordinal(23)] 
		[RED("vehicleProdYearsText")] 
		public inkTextWidgetReference VehicleProdYearsText
		{
			get => GetProperty(ref _vehicleProdYearsText);
			set => SetProperty(ref _vehicleProdYearsText, value);
		}

		[Ordinal(24)] 
		[RED("vehicleDriveLayoutText")] 
		public inkTextWidgetReference VehicleDriveLayoutText
		{
			get => GetProperty(ref _vehicleDriveLayoutText);
			set => SetProperty(ref _vehicleDriveLayoutText, value);
		}

		[Ordinal(25)] 
		[RED("vehicleHorsepowerText")] 
		public inkTextWidgetReference VehicleHorsepowerText
		{
			get => GetProperty(ref _vehicleHorsepowerText);
			set => SetProperty(ref _vehicleHorsepowerText, value);
		}

		[Ordinal(26)] 
		[RED("vehicleMassText")] 
		public inkTextWidgetReference VehicleMassText
		{
			get => GetProperty(ref _vehicleMassText);
			set => SetProperty(ref _vehicleMassText, value);
		}

		[Ordinal(27)] 
		[RED("vehicleStateText")] 
		public inkTextWidgetReference VehicleStateText
		{
			get => GetProperty(ref _vehicleStateText);
			set => SetProperty(ref _vehicleStateText, value);
		}

		[Ordinal(28)] 
		[RED("vehicleInfoText")] 
		public inkTextWidgetReference VehicleInfoText
		{
			get => GetProperty(ref _vehicleInfoText);
			set => SetProperty(ref _vehicleInfoText, value);
		}

		[Ordinal(29)] 
		[RED("vehicleNameHolder")] 
		public inkWidgetReference VehicleNameHolder
		{
			get => GetProperty(ref _vehicleNameHolder);
			set => SetProperty(ref _vehicleNameHolder, value);
		}

		[Ordinal(30)] 
		[RED("vehicleProdYearsHolder")] 
		public inkWidgetReference VehicleProdYearsHolder
		{
			get => GetProperty(ref _vehicleProdYearsHolder);
			set => SetProperty(ref _vehicleProdYearsHolder, value);
		}

		[Ordinal(31)] 
		[RED("vehicleDriveLayoutHolder")] 
		public inkWidgetReference VehicleDriveLayoutHolder
		{
			get => GetProperty(ref _vehicleDriveLayoutHolder);
			set => SetProperty(ref _vehicleDriveLayoutHolder, value);
		}

		[Ordinal(32)] 
		[RED("vehicleHorsepowerHolder")] 
		public inkWidgetReference VehicleHorsepowerHolder
		{
			get => GetProperty(ref _vehicleHorsepowerHolder);
			set => SetProperty(ref _vehicleHorsepowerHolder, value);
		}

		[Ordinal(33)] 
		[RED("vehicleMassHolder")] 
		public inkWidgetReference VehicleMassHolder
		{
			get => GetProperty(ref _vehicleMassHolder);
			set => SetProperty(ref _vehicleMassHolder, value);
		}

		[Ordinal(34)] 
		[RED("vehicleStateHolder")] 
		public inkWidgetReference VehicleStateHolder
		{
			get => GetProperty(ref _vehicleStateHolder);
			set => SetProperty(ref _vehicleStateHolder, value);
		}

		[Ordinal(35)] 
		[RED("vehicleInfoHolder")] 
		public inkWidgetReference VehicleInfoHolder
		{
			get => GetProperty(ref _vehicleInfoHolder);
			set => SetProperty(ref _vehicleInfoHolder, value);
		}

		public ScannervehicleGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
