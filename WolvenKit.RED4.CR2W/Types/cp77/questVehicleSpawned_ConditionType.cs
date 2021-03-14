using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleSpawned_ConditionType : questIVehicleConditionType
	{
		private CEnum<questSpawnedVehicleType> _vehicleType;
		private gameEntityReference _vehicleRef;
		private CUInt32 _count;
		private CEnum<EComparisonType> _comparisonType;
		private CString _vehicleName;
		private CName _vehicleGlobalName;

		[Ordinal(0)] 
		[RED("vehicleType")] 
		public CEnum<questSpawnedVehicleType> VehicleType
		{
			get
			{
				if (_vehicleType == null)
				{
					_vehicleType = (CEnum<questSpawnedVehicleType>) CR2WTypeManager.Create("questSpawnedVehicleType", "vehicleType", cr2w, this);
				}
				return _vehicleType;
			}
			set
			{
				if (_vehicleType == value)
				{
					return;
				}
				_vehicleType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get
			{
				if (_vehicleRef == null)
				{
					_vehicleRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "vehicleRef", cr2w, this);
				}
				return _vehicleRef;
			}
			set
			{
				if (_vehicleRef == value)
				{
					return;
				}
				_vehicleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get
			{
				if (_count == null)
				{
					_count = (CUInt32) CR2WTypeManager.Create("Uint32", "count", cr2w, this);
				}
				return _count;
			}
			set
			{
				if (_count == value)
				{
					return;
				}
				_count = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get
			{
				if (_comparisonType == null)
				{
					_comparisonType = (CEnum<EComparisonType>) CR2WTypeManager.Create("EComparisonType", "comparisonType", cr2w, this);
				}
				return _comparisonType;
			}
			set
			{
				if (_comparisonType == value)
				{
					return;
				}
				_comparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("vehicleName")] 
		public CString VehicleName
		{
			get
			{
				if (_vehicleName == null)
				{
					_vehicleName = (CString) CR2WTypeManager.Create("String", "vehicleName", cr2w, this);
				}
				return _vehicleName;
			}
			set
			{
				if (_vehicleName == value)
				{
					return;
				}
				_vehicleName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("vehicleGlobalName")] 
		public CName VehicleGlobalName
		{
			get
			{
				if (_vehicleGlobalName == null)
				{
					_vehicleGlobalName = (CName) CR2WTypeManager.Create("CName", "vehicleGlobalName", cr2w, this);
				}
				return _vehicleGlobalName;
			}
			set
			{
				if (_vehicleGlobalName == value)
				{
					return;
				}
				_vehicleGlobalName = value;
				PropertySet(this);
			}
		}

		public questVehicleSpawned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
