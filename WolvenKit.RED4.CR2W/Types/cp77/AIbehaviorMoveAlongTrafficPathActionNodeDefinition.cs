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
			get => GetProperty(ref _joinTrafficSettings);
			set => SetProperty(ref _joinTrafficSettings, value);
		}

		[Ordinal(2)] 
		[RED("ignoreTrafficSpots")] 
		public CHandle<AIArgumentMapping> IgnoreTrafficSpots
		{
			get => GetProperty(ref _ignoreTrafficSpots);
			set => SetProperty(ref _ignoreTrafficSpots, value);
		}

		[Ordinal(3)] 
		[RED("useCrowdAnimationGraph")] 
		public CHandle<AIArgumentMapping> UseCrowdAnimationGraph
		{
			get => GetProperty(ref _useCrowdAnimationGraph);
			set => SetProperty(ref _useCrowdAnimationGraph, value);
		}

		[Ordinal(4)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(5)] 
		[RED("workspotExitPositionWS")] 
		public CHandle<AIArgumentMapping> WorkspotExitPositionWS
		{
			get => GetProperty(ref _workspotExitPositionWS);
			set => SetProperty(ref _workspotExitPositionWS, value);
		}

		[Ordinal(6)] 
		[RED("workspotReturnPositionVector")] 
		public CHandle<AIArgumentMapping> WorkspotReturnPositionVector
		{
			get => GetProperty(ref _workspotReturnPositionVector);
			set => SetProperty(ref _workspotReturnPositionVector, value);
		}

		[Ordinal(7)] 
		[RED("workspotExitTangent")] 
		public CHandle<AIArgumentMapping> WorkspotExitTangent
		{
			get => GetProperty(ref _workspotExitTangent);
			set => SetProperty(ref _workspotExitTangent, value);
		}

		[Ordinal(8)] 
		[RED("trafficLaneReturnTangent")] 
		public CHandle<AIArgumentMapping> TrafficLaneReturnTangent
		{
			get => GetProperty(ref _trafficLaneReturnTangent);
			set => SetProperty(ref _trafficLaneReturnTangent, value);
		}

		[Ordinal(9)] 
		[RED("trafficLaneExitTangent")] 
		public CHandle<AIArgumentMapping> TrafficLaneExitTangent
		{
			get => GetProperty(ref _trafficLaneExitTangent);
			set => SetProperty(ref _trafficLaneExitTangent, value);
		}

		public AIbehaviorMoveAlongTrafficPathActionNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
