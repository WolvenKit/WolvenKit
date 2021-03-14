using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _movementTarget;
		private CHandle<AIArgumentMapping> _lookAtTarget;
		private CHandle<AIArgumentMapping> _movementType;
		private CHandle<AIArgumentMapping> _tolerance;
		private CHandle<AIArgumentMapping> _ignoreNavigation;
		private CHandle<AIArgumentMapping> _rotateEntity;
		private CHandle<AIArgumentMapping> _useStart;
		private CHandle<AIArgumentMapping> _useStop;
		private CHandle<AIArgumentMapping> _destinationTangent;
		private CHandle<AIArgumentMapping> _startTangent;
		private CHandle<AIArgumentMapping> _spotReservation;
		private CHandle<AIArgumentMapping> _ignoreRestrictedArea;

		[Ordinal(1)] 
		[RED("movementTarget")] 
		public CHandle<AIArgumentMapping> MovementTarget
		{
			get
			{
				if (_movementTarget == null)
				{
					_movementTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "movementTarget", cr2w, this);
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

		[Ordinal(2)] 
		[RED("lookAtTarget")] 
		public CHandle<AIArgumentMapping> LookAtTarget
		{
			get
			{
				if (_lookAtTarget == null)
				{
					_lookAtTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "lookAtTarget", cr2w, this);
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

		[Ordinal(3)] 
		[RED("movementType")] 
		public CHandle<AIArgumentMapping> MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "movementType", cr2w, this);
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
		[RED("tolerance")] 
		public CHandle<AIArgumentMapping> Tolerance
		{
			get
			{
				if (_tolerance == null)
				{
					_tolerance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "tolerance", cr2w, this);
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

		[Ordinal(5)] 
		[RED("ignoreNavigation")] 
		public CHandle<AIArgumentMapping> IgnoreNavigation
		{
			get
			{
				if (_ignoreNavigation == null)
				{
					_ignoreNavigation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "ignoreNavigation", cr2w, this);
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

		[Ordinal(6)] 
		[RED("rotateEntity")] 
		public CHandle<AIArgumentMapping> RotateEntity
		{
			get
			{
				if (_rotateEntity == null)
				{
					_rotateEntity = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rotateEntity", cr2w, this);
				}
				return _rotateEntity;
			}
			set
			{
				if (_rotateEntity == value)
				{
					return;
				}
				_rotateEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("useStart")] 
		public CHandle<AIArgumentMapping> UseStart
		{
			get
			{
				if (_useStart == null)
				{
					_useStart = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useStart", cr2w, this);
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

		[Ordinal(8)] 
		[RED("useStop")] 
		public CHandle<AIArgumentMapping> UseStop
		{
			get
			{
				if (_useStop == null)
				{
					_useStop = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useStop", cr2w, this);
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

		[Ordinal(9)] 
		[RED("destinationTangent")] 
		public CHandle<AIArgumentMapping> DestinationTangent
		{
			get
			{
				if (_destinationTangent == null)
				{
					_destinationTangent = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "destinationTangent", cr2w, this);
				}
				return _destinationTangent;
			}
			set
			{
				if (_destinationTangent == value)
				{
					return;
				}
				_destinationTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("startTangent")] 
		public CHandle<AIArgumentMapping> StartTangent
		{
			get
			{
				if (_startTangent == null)
				{
					_startTangent = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "startTangent", cr2w, this);
				}
				return _startTangent;
			}
			set
			{
				if (_startTangent == value)
				{
					return;
				}
				_startTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("spotReservation")] 
		public CHandle<AIArgumentMapping> SpotReservation
		{
			get
			{
				if (_spotReservation == null)
				{
					_spotReservation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "spotReservation", cr2w, this);
				}
				return _spotReservation;
			}
			set
			{
				if (_spotReservation == value)
				{
					return;
				}
				_spotReservation = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("ignoreRestrictedArea")] 
		public CHandle<AIArgumentMapping> IgnoreRestrictedArea
		{
			get
			{
				if (_ignoreRestrictedArea == null)
				{
					_ignoreRestrictedArea = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "ignoreRestrictedArea", cr2w, this);
				}
				return _ignoreRestrictedArea;
			}
			set
			{
				if (_ignoreRestrictedArea == value)
				{
					return;
				}
				_ignoreRestrictedArea = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
