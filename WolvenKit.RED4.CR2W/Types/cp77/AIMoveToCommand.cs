using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveToCommand : AIMoveCommand
	{
		private AIPositionSpec _movementTarget;
		private CBool _rotateEntityTowardsFacingTarget;
		private AIPositionSpec _facingTarget;
		private CEnum<moveMovementType> _movementType;
		private CBool _ignoreNavigation;
		private CBool _useStart;
		private CBool _useStop;
		private CFloat _desiredDistanceFromTarget;
		private CBool _finishWhenDestinationReached;

		[Ordinal(7)] 
		[RED("movementTarget")] 
		public AIPositionSpec MovementTarget
		{
			get
			{
				if (_movementTarget == null)
				{
					_movementTarget = (AIPositionSpec) CR2WTypeManager.Create("AIPositionSpec", "movementTarget", cr2w, this);
				}
				return _movementTarget;
			}
			set
			{
				if (_movementTarget == value)
				{
					return;
				}
				_movementTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get
			{
				if (_rotateEntityTowardsFacingTarget == null)
				{
					_rotateEntityTowardsFacingTarget = (CBool) CR2WTypeManager.Create("Bool", "rotateEntityTowardsFacingTarget", cr2w, this);
				}
				return _rotateEntityTowardsFacingTarget;
			}
			set
			{
				if (_rotateEntityTowardsFacingTarget == value)
				{
					return;
				}
				_rotateEntityTowardsFacingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("facingTarget")] 
		public AIPositionSpec FacingTarget
		{
			get
			{
				if (_facingTarget == null)
				{
					_facingTarget = (AIPositionSpec) CR2WTypeManager.Create("AIPositionSpec", "facingTarget", cr2w, this);
				}
				return _facingTarget;
			}
			set
			{
				if (_facingTarget == value)
				{
					return;
				}
				_facingTarget = value;
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
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get
			{
				if (_ignoreNavigation == null)
				{
					_ignoreNavigation = (CBool) CR2WTypeManager.Create("Bool", "ignoreNavigation", cr2w, this);
				}
				return _ignoreNavigation;
			}
			set
			{
				if (_ignoreNavigation == value)
				{
					return;
				}
				_ignoreNavigation = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("desiredDistanceFromTarget")] 
		public CFloat DesiredDistanceFromTarget
		{
			get
			{
				if (_desiredDistanceFromTarget == null)
				{
					_desiredDistanceFromTarget = (CFloat) CR2WTypeManager.Create("Float", "desiredDistanceFromTarget", cr2w, this);
				}
				return _desiredDistanceFromTarget;
			}
			set
			{
				if (_desiredDistanceFromTarget == value)
				{
					return;
				}
				_desiredDistanceFromTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("finishWhenDestinationReached")] 
		public CBool FinishWhenDestinationReached
		{
			get
			{
				if (_finishWhenDestinationReached == null)
				{
					_finishWhenDestinationReached = (CBool) CR2WTypeManager.Create("Bool", "finishWhenDestinationReached", cr2w, this);
				}
				return _finishWhenDestinationReached;
			}
			set
			{
				if (_finishWhenDestinationReached == value)
				{
					return;
				}
				_finishWhenDestinationReached = value;
				PropertySet(this);
			}
		}

		public AIMoveToCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
