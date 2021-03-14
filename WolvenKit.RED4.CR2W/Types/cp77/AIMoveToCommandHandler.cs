using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveToCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outIsDynamicMove;
		private CHandle<AIArgumentMapping> _outMovementTarget;
		private CHandle<AIArgumentMapping> _outMovementTargetPos;
		private CHandle<AIArgumentMapping> _outRotateEntityTowardsFacingTarget;
		private CHandle<AIArgumentMapping> _outFacingTarget;
		private CHandle<AIArgumentMapping> _outMovementType;
		private CHandle<AIArgumentMapping> _outIgnoreNavigation;
		private CHandle<AIArgumentMapping> _outUseStart;
		private CHandle<AIArgumentMapping> _outUseStop;
		private CHandle<AIArgumentMapping> _outDesiredDistanceFromTarget;
		private CHandle<AIArgumentMapping> _outFinishWhenDestinationReached;

		[Ordinal(1)] 
		[RED("outIsDynamicMove")] 
		public CHandle<AIArgumentMapping> OutIsDynamicMove
		{
			get
			{
				if (_outIsDynamicMove == null)
				{
					_outIsDynamicMove = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outIsDynamicMove", cr2w, this);
				}
				return _outIsDynamicMove;
			}
			set
			{
				if (_outIsDynamicMove == value)
				{
					return;
				}
				_outIsDynamicMove = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outMovementTarget")] 
		public CHandle<AIArgumentMapping> OutMovementTarget
		{
			get
			{
				if (_outMovementTarget == null)
				{
					_outMovementTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outMovementTarget", cr2w, this);
				}
				return _outMovementTarget;
			}
			set
			{
				if (_outMovementTarget == value)
				{
					return;
				}
				_outMovementTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("outMovementTargetPos")] 
		public CHandle<AIArgumentMapping> OutMovementTargetPos
		{
			get
			{
				if (_outMovementTargetPos == null)
				{
					_outMovementTargetPos = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outMovementTargetPos", cr2w, this);
				}
				return _outMovementTargetPos;
			}
			set
			{
				if (_outMovementTargetPos == value)
				{
					return;
				}
				_outMovementTargetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("outRotateEntityTowardsFacingTarget")] 
		public CHandle<AIArgumentMapping> OutRotateEntityTowardsFacingTarget
		{
			get
			{
				if (_outRotateEntityTowardsFacingTarget == null)
				{
					_outRotateEntityTowardsFacingTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outRotateEntityTowardsFacingTarget", cr2w, this);
				}
				return _outRotateEntityTowardsFacingTarget;
			}
			set
			{
				if (_outRotateEntityTowardsFacingTarget == value)
				{
					return;
				}
				_outRotateEntityTowardsFacingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("outFacingTarget")] 
		public CHandle<AIArgumentMapping> OutFacingTarget
		{
			get
			{
				if (_outFacingTarget == null)
				{
					_outFacingTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outFacingTarget", cr2w, this);
				}
				return _outFacingTarget;
			}
			set
			{
				if (_outFacingTarget == value)
				{
					return;
				}
				_outFacingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("outMovementType")] 
		public CHandle<AIArgumentMapping> OutMovementType
		{
			get
			{
				if (_outMovementType == null)
				{
					_outMovementType = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outMovementType", cr2w, this);
				}
				return _outMovementType;
			}
			set
			{
				if (_outMovementType == value)
				{
					return;
				}
				_outMovementType = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("outIgnoreNavigation")] 
		public CHandle<AIArgumentMapping> OutIgnoreNavigation
		{
			get
			{
				if (_outIgnoreNavigation == null)
				{
					_outIgnoreNavigation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outIgnoreNavigation", cr2w, this);
				}
				return _outIgnoreNavigation;
			}
			set
			{
				if (_outIgnoreNavigation == value)
				{
					return;
				}
				_outIgnoreNavigation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("outUseStart")] 
		public CHandle<AIArgumentMapping> OutUseStart
		{
			get
			{
				if (_outUseStart == null)
				{
					_outUseStart = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outUseStart", cr2w, this);
				}
				return _outUseStart;
			}
			set
			{
				if (_outUseStart == value)
				{
					return;
				}
				_outUseStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("outUseStop")] 
		public CHandle<AIArgumentMapping> OutUseStop
		{
			get
			{
				if (_outUseStop == null)
				{
					_outUseStop = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outUseStop", cr2w, this);
				}
				return _outUseStop;
			}
			set
			{
				if (_outUseStop == value)
				{
					return;
				}
				_outUseStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("outDesiredDistanceFromTarget")] 
		public CHandle<AIArgumentMapping> OutDesiredDistanceFromTarget
		{
			get
			{
				if (_outDesiredDistanceFromTarget == null)
				{
					_outDesiredDistanceFromTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outDesiredDistanceFromTarget", cr2w, this);
				}
				return _outDesiredDistanceFromTarget;
			}
			set
			{
				if (_outDesiredDistanceFromTarget == value)
				{
					return;
				}
				_outDesiredDistanceFromTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("outFinishWhenDestinationReached")] 
		public CHandle<AIArgumentMapping> OutFinishWhenDestinationReached
		{
			get
			{
				if (_outFinishWhenDestinationReached == null)
				{
					_outFinishWhenDestinationReached = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outFinishWhenDestinationReached", cr2w, this);
				}
				return _outFinishWhenDestinationReached;
			}
			set
			{
				if (_outFinishWhenDestinationReached == value)
				{
					return;
				}
				_outFinishWhenDestinationReached = value;
				PropertySet(this);
			}
		}

		public AIMoveToCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
