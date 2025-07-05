using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTrafficWorkspotTransitionData : ISerializable
	{
		[Ordinal(0)] 
		[RED("workspotData")] 
		public CHandle<gameSetupWorkspotActionEvent> WorkspotData
		{
			get => GetPropertyValue<CHandle<gameSetupWorkspotActionEvent>>();
			set => SetPropertyValue<CHandle<gameSetupWorkspotActionEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("returnPosition")] 
		public CHandle<worldTrafficGlobalPathPosition> ReturnPosition
		{
			get => GetPropertyValue<CHandle<worldTrafficGlobalPathPosition>>();
			set => SetPropertyValue<CHandle<worldTrafficGlobalPathPosition>>(value);
		}

		[Ordinal(2)] 
		[RED("workspotExitTangent")] 
		public Vector3 WorkspotExitTangent
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("trafficLaneReturnTangent")] 
		public Vector3 TrafficLaneReturnTangent
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameTrafficWorkspotTransitionData()
		{
			WorkspotExitTangent = new Vector3();
			TrafficLaneReturnTangent = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
