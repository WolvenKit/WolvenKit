using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannervehicleGameController : BaseChunkGameController
	{
		private CUInt32 _vehicleNameCallbackID;
		private CUInt32 _vehicleManufacturerCallbackID;
		private CUInt32 _vehicleProdYearsCallbackID;
		private CUInt32 _vehicleDriveLayoutCallbackID;
		private CUInt32 _vehicleHorsepowerCallbackID;
		private CUInt32 _vehicleMassCallbackID;
		private CUInt32 _vehicleStateCallbackID;
		private CUInt32 _vehicleInfoCallbackID;
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
		public CUInt32 VehicleNameCallbackID
		{
			get
			{
				if (_vehicleNameCallbackID == null)
				{
					_vehicleNameCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleNameCallbackID", cr2w, this);
				}
				return _vehicleNameCallbackID;
			}
			set
			{
				if (_vehicleNameCallbackID == value)
				{
					return;
				}
				_vehicleNameCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("vehicleManufacturerCallbackID")] 
		public CUInt32 VehicleManufacturerCallbackID
		{
			get
			{
				if (_vehicleManufacturerCallbackID == null)
				{
					_vehicleManufacturerCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleManufacturerCallbackID", cr2w, this);
				}
				return _vehicleManufacturerCallbackID;
			}
			set
			{
				if (_vehicleManufacturerCallbackID == value)
				{
					return;
				}
				_vehicleManufacturerCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("vehicleProdYearsCallbackID")] 
		public CUInt32 VehicleProdYearsCallbackID
		{
			get
			{
				if (_vehicleProdYearsCallbackID == null)
				{
					_vehicleProdYearsCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleProdYearsCallbackID", cr2w, this);
				}
				return _vehicleProdYearsCallbackID;
			}
			set
			{
				if (_vehicleProdYearsCallbackID == value)
				{
					return;
				}
				_vehicleProdYearsCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("vehicleDriveLayoutCallbackID")] 
		public CUInt32 VehicleDriveLayoutCallbackID
		{
			get
			{
				if (_vehicleDriveLayoutCallbackID == null)
				{
					_vehicleDriveLayoutCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleDriveLayoutCallbackID", cr2w, this);
				}
				return _vehicleDriveLayoutCallbackID;
			}
			set
			{
				if (_vehicleDriveLayoutCallbackID == value)
				{
					return;
				}
				_vehicleDriveLayoutCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("vehicleHorsepowerCallbackID")] 
		public CUInt32 VehicleHorsepowerCallbackID
		{
			get
			{
				if (_vehicleHorsepowerCallbackID == null)
				{
					_vehicleHorsepowerCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleHorsepowerCallbackID", cr2w, this);
				}
				return _vehicleHorsepowerCallbackID;
			}
			set
			{
				if (_vehicleHorsepowerCallbackID == value)
				{
					return;
				}
				_vehicleHorsepowerCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("vehicleMassCallbackID")] 
		public CUInt32 VehicleMassCallbackID
		{
			get
			{
				if (_vehicleMassCallbackID == null)
				{
					_vehicleMassCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleMassCallbackID", cr2w, this);
				}
				return _vehicleMassCallbackID;
			}
			set
			{
				if (_vehicleMassCallbackID == value)
				{
					return;
				}
				_vehicleMassCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("vehicleStateCallbackID")] 
		public CUInt32 VehicleStateCallbackID
		{
			get
			{
				if (_vehicleStateCallbackID == null)
				{
					_vehicleStateCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleStateCallbackID", cr2w, this);
				}
				return _vehicleStateCallbackID;
			}
			set
			{
				if (_vehicleStateCallbackID == value)
				{
					return;
				}
				_vehicleStateCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("vehicleInfoCallbackID")] 
		public CUInt32 VehicleInfoCallbackID
		{
			get
			{
				if (_vehicleInfoCallbackID == null)
				{
					_vehicleInfoCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "vehicleInfoCallbackID", cr2w, this);
				}
				return _vehicleInfoCallbackID;
			}
			set
			{
				if (_vehicleInfoCallbackID == value)
				{
					return;
				}
				_vehicleInfoCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isValidVehicleManufacturer")] 
		public CBool IsValidVehicleManufacturer
		{
			get
			{
				if (_isValidVehicleManufacturer == null)
				{
					_isValidVehicleManufacturer = (CBool) CR2WTypeManager.Create("Bool", "isValidVehicleManufacturer", cr2w, this);
				}
				return _isValidVehicleManufacturer;
			}
			set
			{
				if (_isValidVehicleManufacturer == value)
				{
					return;
				}
				_isValidVehicleManufacturer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isValidVehicleName")] 
		public CBool IsValidVehicleName
		{
			get
			{
				if (_isValidVehicleName == null)
				{
					_isValidVehicleName = (CBool) CR2WTypeManager.Create("Bool", "isValidVehicleName", cr2w, this);
				}
				return _isValidVehicleName;
			}
			set
			{
				if (_isValidVehicleName == value)
				{
					return;
				}
				_isValidVehicleName = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isValidVehicleProdYears")] 
		public CBool IsValidVehicleProdYears
		{
			get
			{
				if (_isValidVehicleProdYears == null)
				{
					_isValidVehicleProdYears = (CBool) CR2WTypeManager.Create("Bool", "isValidVehicleProdYears", cr2w, this);
				}
				return _isValidVehicleProdYears;
			}
			set
			{
				if (_isValidVehicleProdYears == value)
				{
					return;
				}
				_isValidVehicleProdYears = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isValidVehicleDriveLayout")] 
		public CBool IsValidVehicleDriveLayout
		{
			get
			{
				if (_isValidVehicleDriveLayout == null)
				{
					_isValidVehicleDriveLayout = (CBool) CR2WTypeManager.Create("Bool", "isValidVehicleDriveLayout", cr2w, this);
				}
				return _isValidVehicleDriveLayout;
			}
			set
			{
				if (_isValidVehicleDriveLayout == value)
				{
					return;
				}
				_isValidVehicleDriveLayout = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isValidVehicleHorsepower")] 
		public CBool IsValidVehicleHorsepower
		{
			get
			{
				if (_isValidVehicleHorsepower == null)
				{
					_isValidVehicleHorsepower = (CBool) CR2WTypeManager.Create("Bool", "isValidVehicleHorsepower", cr2w, this);
				}
				return _isValidVehicleHorsepower;
			}
			set
			{
				if (_isValidVehicleHorsepower == value)
				{
					return;
				}
				_isValidVehicleHorsepower = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isValidVehicleMass")] 
		public CBool IsValidVehicleMass
		{
			get
			{
				if (_isValidVehicleMass == null)
				{
					_isValidVehicleMass = (CBool) CR2WTypeManager.Create("Bool", "isValidVehicleMass", cr2w, this);
				}
				return _isValidVehicleMass;
			}
			set
			{
				if (_isValidVehicleMass == value)
				{
					return;
				}
				_isValidVehicleMass = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("isValidVehicleState")] 
		public CBool IsValidVehicleState
		{
			get
			{
				if (_isValidVehicleState == null)
				{
					_isValidVehicleState = (CBool) CR2WTypeManager.Create("Bool", "isValidVehicleState", cr2w, this);
				}
				return _isValidVehicleState;
			}
			set
			{
				if (_isValidVehicleState == value)
				{
					return;
				}
				_isValidVehicleState = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("isValidVehicleInfo")] 
		public CBool IsValidVehicleInfo
		{
			get
			{
				if (_isValidVehicleInfo == null)
				{
					_isValidVehicleInfo = (CBool) CR2WTypeManager.Create("Bool", "isValidVehicleInfo", cr2w, this);
				}
				return _isValidVehicleInfo;
			}
			set
			{
				if (_isValidVehicleInfo == value)
				{
					return;
				}
				_isValidVehicleInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("vehicleNameText")] 
		public inkTextWidgetReference VehicleNameText
		{
			get
			{
				if (_vehicleNameText == null)
				{
					_vehicleNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vehicleNameText", cr2w, this);
				}
				return _vehicleNameText;
			}
			set
			{
				if (_vehicleNameText == value)
				{
					return;
				}
				_vehicleNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("vehicleManufacturer")] 
		public inkImageWidgetReference VehicleManufacturer
		{
			get
			{
				if (_vehicleManufacturer == null)
				{
					_vehicleManufacturer = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "vehicleManufacturer", cr2w, this);
				}
				return _vehicleManufacturer;
			}
			set
			{
				if (_vehicleManufacturer == value)
				{
					return;
				}
				_vehicleManufacturer = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("vehicleProdYearsText")] 
		public inkTextWidgetReference VehicleProdYearsText
		{
			get
			{
				if (_vehicleProdYearsText == null)
				{
					_vehicleProdYearsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vehicleProdYearsText", cr2w, this);
				}
				return _vehicleProdYearsText;
			}
			set
			{
				if (_vehicleProdYearsText == value)
				{
					return;
				}
				_vehicleProdYearsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("vehicleDriveLayoutText")] 
		public inkTextWidgetReference VehicleDriveLayoutText
		{
			get
			{
				if (_vehicleDriveLayoutText == null)
				{
					_vehicleDriveLayoutText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vehicleDriveLayoutText", cr2w, this);
				}
				return _vehicleDriveLayoutText;
			}
			set
			{
				if (_vehicleDriveLayoutText == value)
				{
					return;
				}
				_vehicleDriveLayoutText = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("vehicleHorsepowerText")] 
		public inkTextWidgetReference VehicleHorsepowerText
		{
			get
			{
				if (_vehicleHorsepowerText == null)
				{
					_vehicleHorsepowerText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vehicleHorsepowerText", cr2w, this);
				}
				return _vehicleHorsepowerText;
			}
			set
			{
				if (_vehicleHorsepowerText == value)
				{
					return;
				}
				_vehicleHorsepowerText = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("vehicleMassText")] 
		public inkTextWidgetReference VehicleMassText
		{
			get
			{
				if (_vehicleMassText == null)
				{
					_vehicleMassText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vehicleMassText", cr2w, this);
				}
				return _vehicleMassText;
			}
			set
			{
				if (_vehicleMassText == value)
				{
					return;
				}
				_vehicleMassText = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("vehicleStateText")] 
		public inkTextWidgetReference VehicleStateText
		{
			get
			{
				if (_vehicleStateText == null)
				{
					_vehicleStateText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vehicleStateText", cr2w, this);
				}
				return _vehicleStateText;
			}
			set
			{
				if (_vehicleStateText == value)
				{
					return;
				}
				_vehicleStateText = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("vehicleInfoText")] 
		public inkTextWidgetReference VehicleInfoText
		{
			get
			{
				if (_vehicleInfoText == null)
				{
					_vehicleInfoText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vehicleInfoText", cr2w, this);
				}
				return _vehicleInfoText;
			}
			set
			{
				if (_vehicleInfoText == value)
				{
					return;
				}
				_vehicleInfoText = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("vehicleNameHolder")] 
		public inkWidgetReference VehicleNameHolder
		{
			get
			{
				if (_vehicleNameHolder == null)
				{
					_vehicleNameHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vehicleNameHolder", cr2w, this);
				}
				return _vehicleNameHolder;
			}
			set
			{
				if (_vehicleNameHolder == value)
				{
					return;
				}
				_vehicleNameHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("vehicleProdYearsHolder")] 
		public inkWidgetReference VehicleProdYearsHolder
		{
			get
			{
				if (_vehicleProdYearsHolder == null)
				{
					_vehicleProdYearsHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vehicleProdYearsHolder", cr2w, this);
				}
				return _vehicleProdYearsHolder;
			}
			set
			{
				if (_vehicleProdYearsHolder == value)
				{
					return;
				}
				_vehicleProdYearsHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("vehicleDriveLayoutHolder")] 
		public inkWidgetReference VehicleDriveLayoutHolder
		{
			get
			{
				if (_vehicleDriveLayoutHolder == null)
				{
					_vehicleDriveLayoutHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vehicleDriveLayoutHolder", cr2w, this);
				}
				return _vehicleDriveLayoutHolder;
			}
			set
			{
				if (_vehicleDriveLayoutHolder == value)
				{
					return;
				}
				_vehicleDriveLayoutHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("vehicleHorsepowerHolder")] 
		public inkWidgetReference VehicleHorsepowerHolder
		{
			get
			{
				if (_vehicleHorsepowerHolder == null)
				{
					_vehicleHorsepowerHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vehicleHorsepowerHolder", cr2w, this);
				}
				return _vehicleHorsepowerHolder;
			}
			set
			{
				if (_vehicleHorsepowerHolder == value)
				{
					return;
				}
				_vehicleHorsepowerHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("vehicleMassHolder")] 
		public inkWidgetReference VehicleMassHolder
		{
			get
			{
				if (_vehicleMassHolder == null)
				{
					_vehicleMassHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vehicleMassHolder", cr2w, this);
				}
				return _vehicleMassHolder;
			}
			set
			{
				if (_vehicleMassHolder == value)
				{
					return;
				}
				_vehicleMassHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("vehicleStateHolder")] 
		public inkWidgetReference VehicleStateHolder
		{
			get
			{
				if (_vehicleStateHolder == null)
				{
					_vehicleStateHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vehicleStateHolder", cr2w, this);
				}
				return _vehicleStateHolder;
			}
			set
			{
				if (_vehicleStateHolder == value)
				{
					return;
				}
				_vehicleStateHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("vehicleInfoHolder")] 
		public inkWidgetReference VehicleInfoHolder
		{
			get
			{
				if (_vehicleInfoHolder == null)
				{
					_vehicleInfoHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "vehicleInfoHolder", cr2w, this);
				}
				return _vehicleInfoHolder;
			}
			set
			{
				if (_vehicleInfoHolder == value)
				{
					return;
				}
				_vehicleInfoHolder = value;
				PropertySet(this);
			}
		}

		public ScannervehicleGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
