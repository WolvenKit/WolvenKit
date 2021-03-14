using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMoveAlongTrafficPathActionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _joinTrafficSettings;
		private CHandle<AIArgumentMapping> _ignoreTrafficSpots;
		private CHandle<AIArgumentMapping> _useCrowdAnimationGraph;
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _workspotExitPositionWS;
		private CHandle<AIArgumentMapping> _workspotReturnPositionVector;
		private CHandle<AIArgumentMapping> _workspotExitTangent;
		private CHandle<AIArgumentMapping> _trafficLaneReturnTangent;
		private CHandle<AIArgumentMapping> _trafficLaneExitTangent;

		[Ordinal(1)] 
		[RED("joinTrafficSettings")] 
		public CHandle<AIArgumentMapping> JoinTrafficSettings
		{
			get
			{
				if (_joinTrafficSettings == null)
				{
					_joinTrafficSettings = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "joinTrafficSettings", cr2w, this);
				}
				return _joinTrafficSettings;
			}
			set
			{
				if (_joinTrafficSettings == value)
				{
					return;
				}
				_joinTrafficSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ignoreTrafficSpots")] 
		public CHandle<AIArgumentMapping> IgnoreTrafficSpots
		{
			get
			{
				if (_ignoreTrafficSpots == null)
				{
					_ignoreTrafficSpots = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "ignoreTrafficSpots", cr2w, this);
				}
				return _ignoreTrafficSpots;
			}
			set
			{
				if (_ignoreTrafficSpots == value)
				{
					return;
				}
				_ignoreTrafficSpots = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useCrowdAnimationGraph")] 
		public CHandle<AIArgumentMapping> UseCrowdAnimationGraph
		{
			get
			{
				if (_useCrowdAnimationGraph == null)
				{
					_useCrowdAnimationGraph = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useCrowdAnimationGraph", cr2w, this);
				}
				return _useCrowdAnimationGraph;
			}
			set
			{
				if (_useCrowdAnimationGraph == value)
				{
					return;
				}
				_useCrowdAnimationGraph = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get
			{
				if (_workspotData == null)
				{
					_workspotData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotData", cr2w, this);
				}
				return _workspotData;
			}
			set
			{
				if (_workspotData == value)
				{
					return;
				}
				_workspotData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("workspotExitPositionWS")] 
		public CHandle<AIArgumentMapping> WorkspotExitPositionWS
		{
			get
			{
				if (_workspotExitPositionWS == null)
				{
					_workspotExitPositionWS = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotExitPositionWS", cr2w, this);
				}
				return _workspotExitPositionWS;
			}
			set
			{
				if (_workspotExitPositionWS == value)
				{
					return;
				}
				_workspotExitPositionWS = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("workspotReturnPositionVector")] 
		public CHandle<AIArgumentMapping> WorkspotReturnPositionVector
		{
			get
			{
				if (_workspotReturnPositionVector == null)
				{
					_workspotReturnPositionVector = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotReturnPositionVector", cr2w, this);
				}
				return _workspotReturnPositionVector;
			}
			set
			{
				if (_workspotReturnPositionVector == value)
				{
					return;
				}
				_workspotReturnPositionVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("workspotExitTangent")] 
		public CHandle<AIArgumentMapping> WorkspotExitTangent
		{
			get
			{
				if (_workspotExitTangent == null)
				{
					_workspotExitTangent = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotExitTangent", cr2w, this);
				}
				return _workspotExitTangent;
			}
			set
			{
				if (_workspotExitTangent == value)
				{
					return;
				}
				_workspotExitTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("trafficLaneReturnTangent")] 
		public CHandle<AIArgumentMapping> TrafficLaneReturnTangent
		{
			get
			{
				if (_trafficLaneReturnTangent == null)
				{
					_trafficLaneReturnTangent = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "trafficLaneReturnTangent", cr2w, this);
				}
				return _trafficLaneReturnTangent;
			}
			set
			{
				if (_trafficLaneReturnTangent == value)
				{
					return;
				}
				_trafficLaneReturnTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("trafficLaneExitTangent")] 
		public CHandle<AIArgumentMapping> TrafficLaneExitTangent
		{
			get
			{
				if (_trafficLaneExitTangent == null)
				{
					_trafficLaneExitTangent = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "trafficLaneExitTangent", cr2w, this);
				}
				return _trafficLaneExitTangent;
			}
			set
			{
				if (_trafficLaneExitTangent == value)
				{
					return;
				}
				_trafficLaneExitTangent = value;
				PropertySet(this);
			}
		}

		public AIbehaviorMoveAlongTrafficPathActionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
