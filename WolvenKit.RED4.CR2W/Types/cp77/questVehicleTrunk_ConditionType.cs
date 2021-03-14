using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleTrunk_ConditionType : questIVehicleConditionType
	{
		private CBool _anyVehicle;
		private CBool _playerVehicle;
		private gameEntityReference _vehicleRef;
		private CBool _anyObject;
		private gameEntityReference _objectRef;
		private CBool _inverted;
		private CBool _isInside;

		[Ordinal(0)] 
		[RED("anyVehicle")] 
		public CBool AnyVehicle
		{
			get
			{
				if (_anyVehicle == null)
				{
					_anyVehicle = (CBool) CR2WTypeManager.Create("Bool", "anyVehicle", cr2w, this);
				}
				return _anyVehicle;
			}
			set
			{
				if (_anyVehicle == value)
				{
					return;
				}
				_anyVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerVehicle")] 
		public CBool PlayerVehicle
		{
			get
			{
				if (_playerVehicle == null)
				{
					_playerVehicle = (CBool) CR2WTypeManager.Create("Bool", "playerVehicle", cr2w, this);
				}
				return _playerVehicle;
			}
			set
			{
				if (_playerVehicle == value)
				{
					return;
				}
				_playerVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("anyObject")] 
		public CBool AnyObject
		{
			get
			{
				if (_anyObject == null)
				{
					_anyObject = (CBool) CR2WTypeManager.Create("Bool", "anyObject", cr2w, this);
				}
				return _anyObject;
			}
			set
			{
				if (_anyObject == value)
				{
					return;
				}
				_anyObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isInside")] 
		public CBool IsInside
		{
			get
			{
				if (_isInside == null)
				{
					_isInside = (CBool) CR2WTypeManager.Create("Bool", "isInside", cr2w, this);
				}
				return _isInside;
			}
			set
			{
				if (_isInside == value)
				{
					return;
				}
				_isInside = value;
				PropertySet(this);
			}
		}

		public questVehicleTrunk_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
