using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTrafficWorkspotTransitionData : ISerializable
	{
		private CHandle<gameSetupWorkspotActionEvent> _workspotData;
		private CHandle<worldTrafficGlobalPathPosition> _returnPosition;
		private Vector3 _workspotExitTangent;
		private Vector3 _trafficLaneReturnTangent;

		[Ordinal(0)] 
		[RED("workspotData")] 
		public CHandle<gameSetupWorkspotActionEvent> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(1)] 
		[RED("returnPosition")] 
		public CHandle<worldTrafficGlobalPathPosition> ReturnPosition
		{
			get => GetProperty(ref _returnPosition);
			set => SetProperty(ref _returnPosition, value);
		}

		[Ordinal(2)] 
		[RED("workspotExitTangent")] 
		public Vector3 WorkspotExitTangent
		{
			get => GetProperty(ref _workspotExitTangent);
			set => SetProperty(ref _workspotExitTangent, value);
		}

		[Ordinal(3)] 
		[RED("trafficLaneReturnTangent")] 
		public Vector3 TrafficLaneReturnTangent
		{
			get => GetProperty(ref _trafficLaneReturnTangent);
			set => SetProperty(ref _trafficLaneReturnTangent, value);
		}
	}
}
