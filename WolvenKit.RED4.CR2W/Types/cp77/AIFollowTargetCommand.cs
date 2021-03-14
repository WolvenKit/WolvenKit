using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowTargetCommand : AIMoveCommand
	{
		private wCHandle<gameObject> _target;
		private CFloat _desiredDistance;
		private CFloat _tolerance;
		private CBool _stopWhenDestinationReached;
		private CEnum<moveMovementType> _movementType;
		private wCHandle<gameObject> _lookAtTarget;
		private CBool _matchSpeed;
		private CBool _teleport;

		[Ordinal(7)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
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

		[Ordinal(8)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get
			{
				if (_desiredDistance == null)
				{
					_desiredDistance = (CFloat) CR2WTypeManager.Create("Float", "desiredDistance", cr2w, this);
				}
				return _desiredDistance;
			}
			set
			{
				if (_desiredDistance == value)
				{
					return;
				}
				_desiredDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("tolerance")] 
		public CFloat Tolerance
		{
			get
			{
				if (_tolerance == null)
				{
					_tolerance = (CFloat) CR2WTypeManager.Create("Float", "tolerance", cr2w, this);
				}
				return _tolerance;
			}
			set
			{
				if (_tolerance == value)
				{
					return;
				}
				_tolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("stopWhenDestinationReached")] 
		public CBool StopWhenDestinationReached
		{
			get
			{
				if (_stopWhenDestinationReached == null)
				{
					_stopWhenDestinationReached = (CBool) CR2WTypeManager.Create("Bool", "stopWhenDestinationReached", cr2w, this);
				}
				return _stopWhenDestinationReached;
			}
			set
			{
				if (_stopWhenDestinationReached == value)
				{
					return;
				}
				_stopWhenDestinationReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("lookAtTarget")] 
		public wCHandle<gameObject> LookAtTarget
		{
			get
			{
				if (_lookAtTarget == null)
				{
					_lookAtTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "lookAtTarget", cr2w, this);
				}
				return _lookAtTarget;
			}
			set
			{
				if (_lookAtTarget == value)
				{
					return;
				}
				_lookAtTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("matchSpeed")] 
		public CBool MatchSpeed
		{
			get
			{
				if (_matchSpeed == null)
				{
					_matchSpeed = (CBool) CR2WTypeManager.Create("Bool", "matchSpeed", cr2w, this);
				}
				return _matchSpeed;
			}
			set
			{
				if (_matchSpeed == value)
				{
					return;
				}
				_matchSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("teleport")] 
		public CBool Teleport
		{
			get
			{
				if (_teleport == null)
				{
					_teleport = (CBool) CR2WTypeManager.Create("Bool", "teleport", cr2w, this);
				}
				return _teleport;
			}
			set
			{
				if (_teleport == value)
				{
					return;
				}
				_teleport = value;
				PropertySet(this);
			}
		}

		public AIFollowTargetCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
