using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMoveToParams : questAICommandParams
	{
		private CHandle<questUniversalRef> _movementTargetRef;
		private CHandle<questUniversalRef> _facingTargetRef;
		private CBool _rotateEntityTowardsFacingTarget;
		private CEnum<moveMovementType> _movementType;
		private CBool _ignoreNavigation;
		private CBool _useStart;
		private CBool _useStop;
		private CFloat _desiredDistanceFromTarget;
		private CBool _finishWhenDestinationReached;
		private CBool _repeatCommandOnInterrupt;
		private CBool _executeWhileDespawned;
		private CBool _removeAfterCombat;
		private CBool _ignoreInCombat;
		private CBool _alwaysUseStealth;

		[Ordinal(0)] 
		[RED("movementTargetRef")] 
		public CHandle<questUniversalRef> MovementTargetRef
		{
			get
			{
				if (_movementTargetRef == null)
				{
					_movementTargetRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "movementTargetRef", cr2w, this);
				}
				return _movementTargetRef;
			}
			set
			{
				if (_movementTargetRef == value)
				{
					return;
				}
				_movementTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("facingTargetRef")] 
		public CHandle<questUniversalRef> FacingTargetRef
		{
			get
			{
				if (_facingTargetRef == null)
				{
					_facingTargetRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "facingTargetRef", cr2w, this);
				}
				return _facingTargetRef;
			}
			set
			{
				if (_facingTargetRef == value)
				{
					return;
				}
				_facingTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get
			{
				if (_repeatCommandOnInterrupt == null)
				{
					_repeatCommandOnInterrupt = (CBool) CR2WTypeManager.Create("Bool", "repeatCommandOnInterrupt", cr2w, this);
				}
				return _repeatCommandOnInterrupt;
			}
			set
			{
				if (_repeatCommandOnInterrupt == value)
				{
					return;
				}
				_repeatCommandOnInterrupt = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("executeWhileDespawned")] 
		public CBool ExecuteWhileDespawned
		{
			get
			{
				if (_executeWhileDespawned == null)
				{
					_executeWhileDespawned = (CBool) CR2WTypeManager.Create("Bool", "executeWhileDespawned", cr2w, this);
				}
				return _executeWhileDespawned;
			}
			set
			{
				if (_executeWhileDespawned == value)
				{
					return;
				}
				_executeWhileDespawned = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("removeAfterCombat")] 
		public CBool RemoveAfterCombat
		{
			get
			{
				if (_removeAfterCombat == null)
				{
					_removeAfterCombat = (CBool) CR2WTypeManager.Create("Bool", "removeAfterCombat", cr2w, this);
				}
				return _removeAfterCombat;
			}
			set
			{
				if (_removeAfterCombat == value)
				{
					return;
				}
				_removeAfterCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("ignoreInCombat")] 
		public CBool IgnoreInCombat
		{
			get
			{
				if (_ignoreInCombat == null)
				{
					_ignoreInCombat = (CBool) CR2WTypeManager.Create("Bool", "ignoreInCombat", cr2w, this);
				}
				return _ignoreInCombat;
			}
			set
			{
				if (_ignoreInCombat == value)
				{
					return;
				}
				_ignoreInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get
			{
				if (_alwaysUseStealth == null)
				{
					_alwaysUseStealth = (CBool) CR2WTypeManager.Create("Bool", "alwaysUseStealth", cr2w, this);
				}
				return _alwaysUseStealth;
			}
			set
			{
				if (_alwaysUseStealth == value)
				{
					return;
				}
				_alwaysUseStealth = value;
				PropertySet(this);
			}
		}

		public questMoveToParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
