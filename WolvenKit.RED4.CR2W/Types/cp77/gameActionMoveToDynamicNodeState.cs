using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToDynamicNodeState : gameActionMoveToState
	{
		private wCHandle<gameObject> _target;
		private wCHandle<gameObject> _strafingTarget;
		private CFloat _desiredDistanceFromTarget;
		private CBool _stopWhenDestinationReached;
		private CFloat _pathfindingUpdateInterval;
		private CBool _usePathfinding;
		private CBool _useStart;
		private CBool _useStop;

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("pathfindingUpdateInterval")] 
		public CFloat PathfindingUpdateInterval
		{
			get
			{
				if (_pathfindingUpdateInterval == null)
				{
					_pathfindingUpdateInterval = (CFloat) CR2WTypeManager.Create("Float", "pathfindingUpdateInterval", cr2w, this);
				}
				return _pathfindingUpdateInterval;
			}
			set
			{
				if (_pathfindingUpdateInterval == value)
				{
					return;
				}
				_pathfindingUpdateInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		public gameActionMoveToDynamicNodeState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
