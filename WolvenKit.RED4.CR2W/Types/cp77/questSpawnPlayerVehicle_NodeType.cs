using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnPlayerVehicle_NodeType : questIVehicleManagerNodeType
	{
		private CBool _despawn;
		private CHandle<questUniversalRef> _positionRef;
		private Vector3 _offset;
		private CBool _driveIn;
		private CString _vehicle;
		private CName _vehicleGlobalName;
		private CBool _despawnAllVehicles;

		[Ordinal(0)] 
		[RED("despawn")] 
		public CBool Despawn
		{
			get
			{
				if (_despawn == null)
				{
					_despawn = (CBool) CR2WTypeManager.Create("Bool", "despawn", cr2w, this);
				}
				return _despawn;
			}
			set
			{
				if (_despawn == value)
				{
					return;
				}
				_despawn = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("positionRef")] 
		public CHandle<questUniversalRef> PositionRef
		{
			get
			{
				if (_positionRef == null)
				{
					_positionRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "positionRef", cr2w, this);
				}
				return _positionRef;
			}
			set
			{
				if (_positionRef == value)
				{
					return;
				}
				_positionRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("driveIn")] 
		public CBool DriveIn
		{
			get
			{
				if (_driveIn == null)
				{
					_driveIn = (CBool) CR2WTypeManager.Create("Bool", "driveIn", cr2w, this);
				}
				return _driveIn;
			}
			set
			{
				if (_driveIn == value)
				{
					return;
				}
				_driveIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("vehicle")] 
		public CString Vehicle
		{
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (CString) CR2WTypeManager.Create("String", "vehicle", cr2w, this);
				}
				return _vehicle;
			}
			set
			{
				if (_vehicle == value)
				{
					return;
				}
				_vehicle = value;
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

		[Ordinal(6)] 
		[RED("despawnAllVehicles")] 
		public CBool DespawnAllVehicles
		{
			get
			{
				if (_despawnAllVehicles == null)
				{
					_despawnAllVehicles = (CBool) CR2WTypeManager.Create("Bool", "despawnAllVehicles", cr2w, this);
				}
				return _despawnAllVehicles;
			}
			set
			{
				if (_despawnAllVehicles == value)
				{
					return;
				}
				_despawnAllVehicles = value;
				PropertySet(this);
			}
		}

		public questSpawnPlayerVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
