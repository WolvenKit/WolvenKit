using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveOnSplineNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _spline;
		private CHandle<AIArgumentMapping> _strafingTarget;
		private CHandle<AIArgumentMapping> _movementType;
		private CHandle<AIArgumentMapping> _ignoreNavigation;
		private CHandle<AIArgumentMapping> _snapToTerrain;
		private CHandle<AIArgumentMapping> _rotateEntity;
		private CHandle<AIArgumentMapping> _startFromClosestPoint;
		private CHandle<AIArgumentMapping> _useStart;
		private CHandle<AIArgumentMapping> _useStop;
		private CHandle<AIArgumentMapping> _reverse;
		private CHandle<AIArgumentMapping> _isBackAndForth;
		private CHandle<AIArgumentMapping> _isInfinite;
		private CHandle<AIArgumentMapping> _numberOfLoops;
		private CHandle<AIArgumentMapping> _useOffMeshLinkReservation;

		[Ordinal(1)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get
			{
				if (_spline == null)
				{
					_spline = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "spline", cr2w, this);
				}
				return _spline;
			}
			set
			{
				if (_spline == value)
				{
					return;
				}
				_spline = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("strafingTarget")] 
		public CHandle<AIArgumentMapping> StrafingTarget
		{
			get
			{
				if (_strafingTarget == null)
				{
					_strafingTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "strafingTarget", cr2w, this);
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

		[Ordinal(5)] 
		[RED("snapToTerrain")] 
		public CHandle<AIArgumentMapping> SnapToTerrain
		{
			get
			{
				if (_snapToTerrain == null)
				{
					_snapToTerrain = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "snapToTerrain", cr2w, this);
				}
				return _snapToTerrain;
			}
			set
			{
				if (_snapToTerrain == value)
				{
					return;
				}
				_snapToTerrain = value;
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
		[RED("startFromClosestPoint")] 
		public CHandle<AIArgumentMapping> StartFromClosestPoint
		{
			get
			{
				if (_startFromClosestPoint == null)
				{
					_startFromClosestPoint = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "startFromClosestPoint", cr2w, this);
				}
				return _startFromClosestPoint;
			}
			set
			{
				if (_startFromClosestPoint == value)
				{
					return;
				}
				_startFromClosestPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("reverse")] 
		public CHandle<AIArgumentMapping> Reverse
		{
			get
			{
				if (_reverse == null)
				{
					_reverse = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "reverse", cr2w, this);
				}
				return _reverse;
			}
			set
			{
				if (_reverse == value)
				{
					return;
				}
				_reverse = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isBackAndForth")] 
		public CHandle<AIArgumentMapping> IsBackAndForth
		{
			get
			{
				if (_isBackAndForth == null)
				{
					_isBackAndForth = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "isBackAndForth", cr2w, this);
				}
				return _isBackAndForth;
			}
			set
			{
				if (_isBackAndForth == value)
				{
					return;
				}
				_isBackAndForth = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isInfinite")] 
		public CHandle<AIArgumentMapping> IsInfinite
		{
			get
			{
				if (_isInfinite == null)
				{
					_isInfinite = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "isInfinite", cr2w, this);
				}
				return _isInfinite;
			}
			set
			{
				if (_isInfinite == value)
				{
					return;
				}
				_isInfinite = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("numberOfLoops")] 
		public CHandle<AIArgumentMapping> NumberOfLoops
		{
			get
			{
				if (_numberOfLoops == null)
				{
					_numberOfLoops = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "numberOfLoops", cr2w, this);
				}
				return _numberOfLoops;
			}
			set
			{
				if (_numberOfLoops == value)
				{
					return;
				}
				_numberOfLoops = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("useOffMeshLinkReservation")] 
		public CHandle<AIArgumentMapping> UseOffMeshLinkReservation
		{
			get
			{
				if (_useOffMeshLinkReservation == null)
				{
					_useOffMeshLinkReservation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useOffMeshLinkReservation", cr2w, this);
				}
				return _useOffMeshLinkReservation;
			}
			set
			{
				if (_useOffMeshLinkReservation == value)
				{
					return;
				}
				_useOffMeshLinkReservation = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionMoveOnSplineNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
