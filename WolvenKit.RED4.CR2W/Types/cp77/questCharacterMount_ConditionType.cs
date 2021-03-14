using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterMount_ConditionType : questICharacterConditionType
	{
		private CBool _anyParent;
		private gameEntityReference _parentRef;
		private CBool _parentIsPlayer;
		private CBool _anyChild;
		private gameEntityReference _childRef;
		private CBool _childIsPlayer;
		private CEnum<questMountConditionType> _condition;
		private CBool _enterAnimationFinished;
		private CEnum<gameMountingSlotRole> _role;
		private CBool _usePlayersVehicle;
		private CString _playerVehicleName;
		private CEnum<questMountVehicleType> _vehicleType;
		private CEnum<questMountVehicleOrigin> _vehicleOrigin;

		[Ordinal(0)] 
		[RED("anyParent")] 
		public CBool AnyParent
		{
			get
			{
				if (_anyParent == null)
				{
					_anyParent = (CBool) CR2WTypeManager.Create("Bool", "anyParent", cr2w, this);
				}
				return _anyParent;
			}
			set
			{
				if (_anyParent == value)
				{
					return;
				}
				_anyParent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get
			{
				if (_parentRef == null)
				{
					_parentRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "parentRef", cr2w, this);
				}
				return _parentRef;
			}
			set
			{
				if (_parentRef == value)
				{
					return;
				}
				_parentRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("parentIsPlayer")] 
		public CBool ParentIsPlayer
		{
			get
			{
				if (_parentIsPlayer == null)
				{
					_parentIsPlayer = (CBool) CR2WTypeManager.Create("Bool", "parentIsPlayer", cr2w, this);
				}
				return _parentIsPlayer;
			}
			set
			{
				if (_parentIsPlayer == value)
				{
					return;
				}
				_parentIsPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("anyChild")] 
		public CBool AnyChild
		{
			get
			{
				if (_anyChild == null)
				{
					_anyChild = (CBool) CR2WTypeManager.Create("Bool", "anyChild", cr2w, this);
				}
				return _anyChild;
			}
			set
			{
				if (_anyChild == value)
				{
					return;
				}
				_anyChild = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("childRef")] 
		public gameEntityReference ChildRef
		{
			get
			{
				if (_childRef == null)
				{
					_childRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "childRef", cr2w, this);
				}
				return _childRef;
			}
			set
			{
				if (_childRef == value)
				{
					return;
				}
				_childRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("childIsPlayer")] 
		public CBool ChildIsPlayer
		{
			get
			{
				if (_childIsPlayer == null)
				{
					_childIsPlayer = (CBool) CR2WTypeManager.Create("Bool", "childIsPlayer", cr2w, this);
				}
				return _childIsPlayer;
			}
			set
			{
				if (_childIsPlayer == value)
				{
					return;
				}
				_childIsPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("condition")] 
		public CEnum<questMountConditionType> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CEnum<questMountConditionType>) CR2WTypeManager.Create("questMountConditionType", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("enterAnimationFinished")] 
		public CBool EnterAnimationFinished
		{
			get
			{
				if (_enterAnimationFinished == null)
				{
					_enterAnimationFinished = (CBool) CR2WTypeManager.Create("Bool", "enterAnimationFinished", cr2w, this);
				}
				return _enterAnimationFinished;
			}
			set
			{
				if (_enterAnimationFinished == value)
				{
					return;
				}
				_enterAnimationFinished = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("role")] 
		public CEnum<gameMountingSlotRole> Role
		{
			get
			{
				if (_role == null)
				{
					_role = (CEnum<gameMountingSlotRole>) CR2WTypeManager.Create("gameMountingSlotRole", "role", cr2w, this);
				}
				return _role;
			}
			set
			{
				if (_role == value)
				{
					return;
				}
				_role = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("usePlayersVehicle")] 
		public CBool UsePlayersVehicle
		{
			get
			{
				if (_usePlayersVehicle == null)
				{
					_usePlayersVehicle = (CBool) CR2WTypeManager.Create("Bool", "usePlayersVehicle", cr2w, this);
				}
				return _usePlayersVehicle;
			}
			set
			{
				if (_usePlayersVehicle == value)
				{
					return;
				}
				_usePlayersVehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("playerVehicleName")] 
		public CString PlayerVehicleName
		{
			get
			{
				if (_playerVehicleName == null)
				{
					_playerVehicleName = (CString) CR2WTypeManager.Create("String", "playerVehicleName", cr2w, this);
				}
				return _playerVehicleName;
			}
			set
			{
				if (_playerVehicleName == value)
				{
					return;
				}
				_playerVehicleName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("vehicleType")] 
		public CEnum<questMountVehicleType> VehicleType
		{
			get
			{
				if (_vehicleType == null)
				{
					_vehicleType = (CEnum<questMountVehicleType>) CR2WTypeManager.Create("questMountVehicleType", "vehicleType", cr2w, this);
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

		[Ordinal(12)] 
		[RED("vehicleOrigin")] 
		public CEnum<questMountVehicleOrigin> VehicleOrigin
		{
			get
			{
				if (_vehicleOrigin == null)
				{
					_vehicleOrigin = (CEnum<questMountVehicleOrigin>) CR2WTypeManager.Create("questMountVehicleOrigin", "vehicleOrigin", cr2w, this);
				}
				return _vehicleOrigin;
			}
			set
			{
				if (_vehicleOrigin == value)
				{
					return;
				}
				_vehicleOrigin = value;
				PropertySet(this);
			}
		}

		public questCharacterMount_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
