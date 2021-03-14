using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectPropertyDictionaryPropertyEntry : CVariable
	{
		private CUInt16 _id;
		private CUInt32 _usage;
		private CName _animationName;
		private CUInt64 _sourceAnimset;
		private CEnum<gameSmartObjectPointType> _type;
		private CEnum<moveMovementType> _movementType;
		private CEnum<moveMovementOrientationType> _movementOrientation;
		private CBool _isOnNavmesh;
		private CBool _isReachable;
		private CBool _overObstacle;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt16) CR2WTypeManager.Create("Uint16", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("usage")] 
		public CUInt32 Usage
		{
			get
			{
				if (_usage == null)
				{
					_usage = (CUInt32) CR2WTypeManager.Create("Uint32", "usage", cr2w, this);
				}
				return _usage;
			}
			set
			{
				if (_usage == value)
				{
					return;
				}
				_usage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sourceAnimset")] 
		public CUInt64 SourceAnimset
		{
			get
			{
				if (_sourceAnimset == null)
				{
					_sourceAnimset = (CUInt64) CR2WTypeManager.Create("Uint64", "sourceAnimset", cr2w, this);
				}
				return _sourceAnimset;
			}
			set
			{
				if (_sourceAnimset == value)
				{
					return;
				}
				_sourceAnimset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameSmartObjectPointType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameSmartObjectPointType>) CR2WTypeManager.Create("gameSmartObjectPointType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CEnum<moveMovementType>) CR2WTypeManager.Create("moveMovementType", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("movementOrientation")] 
		public CEnum<moveMovementOrientationType> MovementOrientation
		{
			get
			{
				if (_movementOrientation == null)
				{
					_movementOrientation = (CEnum<moveMovementOrientationType>) CR2WTypeManager.Create("moveMovementOrientationType", "movementOrientation", cr2w, this);
				}
				return _movementOrientation;
			}
			set
			{
				if (_movementOrientation == value)
				{
					return;
				}
				_movementOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isOnNavmesh")] 
		public CBool IsOnNavmesh
		{
			get
			{
				if (_isOnNavmesh == null)
				{
					_isOnNavmesh = (CBool) CR2WTypeManager.Create("Bool", "isOnNavmesh", cr2w, this);
				}
				return _isOnNavmesh;
			}
			set
			{
				if (_isOnNavmesh == value)
				{
					return;
				}
				_isOnNavmesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isReachable")] 
		public CBool IsReachable
		{
			get
			{
				if (_isReachable == null)
				{
					_isReachable = (CBool) CR2WTypeManager.Create("Bool", "isReachable", cr2w, this);
				}
				return _isReachable;
			}
			set
			{
				if (_isReachable == value)
				{
					return;
				}
				_isReachable = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("overObstacle")] 
		public CBool OverObstacle
		{
			get
			{
				if (_overObstacle == null)
				{
					_overObstacle = (CBool) CR2WTypeManager.Create("Bool", "overObstacle", cr2w, this);
				}
				return _overObstacle;
			}
			set
			{
				if (_overObstacle == value)
				{
					return;
				}
				_overObstacle = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectPropertyDictionaryPropertyEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
