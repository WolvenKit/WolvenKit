using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToPositionState : gameActionReplicatedState
	{
		private Vector3 _target;
		private CBool _useSpotReservation;
		private CBool _usePathfinding;
		private CBool _useStart;
		private CBool _useStop;
		private CEnum<moveMovementType> _movementType;
		private wCHandle<gameObject> _strafingTarget;

		[Ordinal(5)] 
		[RED("target")] 
		public Vector3 Target
		{
			get
			{
				if (_target == null)
				{
					_target = (Vector3) CR2WTypeManager.Create("Vector3", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("useSpotReservation")] 
		public CBool UseSpotReservation
		{
			get
			{
				if (_useSpotReservation == null)
				{
					_useSpotReservation = (CBool) CR2WTypeManager.Create("Bool", "useSpotReservation", cr2w, this);
				}
				return _useSpotReservation;
			}
			set
			{
				if (_useSpotReservation == value)
				{
					return;
				}
				_useSpotReservation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		public gameActionMoveToPositionState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
