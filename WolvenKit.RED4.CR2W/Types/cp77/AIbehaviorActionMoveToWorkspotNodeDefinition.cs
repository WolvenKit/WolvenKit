using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveToWorkspotNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _workspotSetup;
		private CHandle<AIArgumentMapping> _lookAtTarget;
		private CHandle<AIArgumentMapping> _movementType;
		private CHandle<AIArgumentMapping> _tolerance;
		private CHandle<AIArgumentMapping> _ignoreNavigation;
		private CHandle<AIArgumentMapping> _rotateEntity;
		private CHandle<AIArgumentMapping> _useStart;
		private CHandle<AIArgumentMapping> _spotReservation;
		private CHandle<AIArgumentMapping> _startTangent;
		private CHandle<AIArgumentMapping> _fastForwardAfterTeleport;
		private CHandle<AIArgumentMapping> _ignoreExploration;

		[Ordinal(1)] 
		[RED("workspotSetup")] 
		public CHandle<AIArgumentMapping> WorkspotSetup
		{
			get
			{
				if (_workspotSetup == null)
				{
					_workspotSetup = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotSetup", cr2w, this);
				}
				return _workspotSetup;
			}
			set
			{
				if (_workspotSetup == value)
				{
					return;
				}
				_workspotSetup = value;
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get
			{
				if (_fastForwardAfterTeleport == null)
				{
					_fastForwardAfterTeleport = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "fastForwardAfterTeleport", cr2w, this);
				}
				return _fastForwardAfterTeleport;
			}
			set
			{
				if (_fastForwardAfterTeleport == value)
				{
					return;
				}
				_fastForwardAfterTeleport = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("ignoreExploration")] 
		public CHandle<AIArgumentMapping> IgnoreExploration
		{
			get
			{
				if (_ignoreExploration == null)
				{
					_ignoreExploration = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "ignoreExploration", cr2w, this);
				}
				return _ignoreExploration;
			}
			set
			{
				if (_ignoreExploration == value)
				{
					return;
				}
				_ignoreExploration = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionMoveToWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
