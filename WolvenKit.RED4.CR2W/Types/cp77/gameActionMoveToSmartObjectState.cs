using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToSmartObjectState : gameActionMoveToState
	{
		private CUInt64 _targetHash;
		private CBool _usePathfinding;
		private CBool _useStart;
		private CBool _useStop;
		private CEnum<gameSmartObjectInstanceEntryType> _entryType;
		private CEnum<moveMovementType> _movementType;
		private wCHandle<gameObject> _strafingTarget;
		private Vector3 _entryDirection;
		private Vector3 _entryPointPos;
		private Vector4 _entryPointDir;
		private CName _animationName;
		private CBool _isInSmartObject;

		[Ordinal(9)] 
		[RED("targetHash")] 
		public CUInt64 TargetHash
		{
			get
			{
				if (_targetHash == null)
				{
					_targetHash = (CUInt64) CR2WTypeManager.Create("Uint64", "targetHash", cr2w, this);
				}
				return _targetHash;
			}
			set
			{
				if (_targetHash == value)
				{
					return;
				}
				_targetHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("usePathfinding")] 
		public CBool UsePathfinding
		{
			get
			{
				if (_usePathfinding == null)
				{
					_usePathfinding = (CBool) CR2WTypeManager.Create("Bool", "usePathfinding", cr2w, this);
				}
				return _usePathfinding;
			}
			set
			{
				if (_usePathfinding == value)
				{
					return;
				}
				_usePathfinding = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get
			{
				if (_useStart == null)
				{
					_useStart = (CBool) CR2WTypeManager.Create("Bool", "useStart", cr2w, this);
				}
				return _useStart;
			}
			set
			{
				if (_useStart == value)
				{
					return;
				}
				_useStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get
			{
				if (_useStop == null)
				{
					_useStop = (CBool) CR2WTypeManager.Create("Bool", "useStop", cr2w, this);
				}
				return _useStop;
			}
			set
			{
				if (_useStop == value)
				{
					return;
				}
				_useStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("entryType")] 
		public CEnum<gameSmartObjectInstanceEntryType> EntryType
		{
			get
			{
				if (_entryType == null)
				{
					_entryType = (CEnum<gameSmartObjectInstanceEntryType>) CR2WTypeManager.Create("gameSmartObjectInstanceEntryType", "entryType", cr2w, this);
				}
				return _entryType;
			}
			set
			{
				if (_entryType == value)
				{
					return;
				}
				_entryType = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("strafingTarget")] 
		public wCHandle<gameObject> StrafingTarget
		{
			get
			{
				if (_strafingTarget == null)
				{
					_strafingTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "strafingTarget", cr2w, this);
				}
				return _strafingTarget;
			}
			set
			{
				if (_strafingTarget == value)
				{
					return;
				}
				_strafingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("entryDirection")] 
		public Vector3 EntryDirection
		{
			get
			{
				if (_entryDirection == null)
				{
					_entryDirection = (Vector3) CR2WTypeManager.Create("Vector3", "entryDirection", cr2w, this);
				}
				return _entryDirection;
			}
			set
			{
				if (_entryDirection == value)
				{
					return;
				}
				_entryDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("entryPointPos")] 
		public Vector3 EntryPointPos
		{
			get
			{
				if (_entryPointPos == null)
				{
					_entryPointPos = (Vector3) CR2WTypeManager.Create("Vector3", "entryPointPos", cr2w, this);
				}
				return _entryPointPos;
			}
			set
			{
				if (_entryPointPos == value)
				{
					return;
				}
				_entryPointPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("entryPointDir")] 
		public Vector4 EntryPointDir
		{
			get
			{
				if (_entryPointDir == null)
				{
					_entryPointDir = (Vector4) CR2WTypeManager.Create("Vector4", "entryPointDir", cr2w, this);
				}
				return _entryPointDir;
			}
			set
			{
				if (_entryPointDir == value)
				{
					return;
				}
				_entryPointDir = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("isInSmartObject")] 
		public CBool IsInSmartObject
		{
			get
			{
				if (_isInSmartObject == null)
				{
					_isInSmartObject = (CBool) CR2WTypeManager.Create("Bool", "isInSmartObject", cr2w, this);
				}
				return _isInSmartObject;
			}
			set
			{
				if (_isInSmartObject == value)
				{
					return;
				}
				_isInSmartObject = value;
				PropertySet(this);
			}
		}

		public gameActionMoveToSmartObjectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
