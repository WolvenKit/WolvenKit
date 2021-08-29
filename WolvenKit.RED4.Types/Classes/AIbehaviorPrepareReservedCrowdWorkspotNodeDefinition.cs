using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorPrepareReservedCrowdWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _returnPosition;
		private CHandle<AIArgumentMapping> _returnPositionVector;
		private CHandle<AIArgumentMapping> _workspotExitTangent;
		private CHandle<AIArgumentMapping> _joinTrafficSettings;
		private CHandle<AIArgumentMapping> _overrideExit;

		[Ordinal(1)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(2)] 
		[RED("returnPosition")] 
		public CHandle<AIArgumentMapping> ReturnPosition
		{
			get => GetProperty(ref _returnPosition);
			set => SetProperty(ref _returnPosition, value);
		}

		[Ordinal(3)] 
		[RED("returnPositionVector")] 
		public CHandle<AIArgumentMapping> ReturnPositionVector
		{
			get => GetProperty(ref _returnPositionVector);
			set => SetProperty(ref _returnPositionVector, value);
		}

		[Ordinal(4)] 
		[RED("workspotExitTangent")] 
		public CHandle<AIArgumentMapping> WorkspotExitTangent
		{
			get => GetProperty(ref _workspotExitTangent);
			set => SetProperty(ref _workspotExitTangent, value);
		}

		[Ordinal(5)] 
		[RED("joinTrafficSettings")] 
		public CHandle<AIArgumentMapping> JoinTrafficSettings
		{
			get => GetProperty(ref _joinTrafficSettings);
			set => SetProperty(ref _joinTrafficSettings, value);
		}

		[Ordinal(6)] 
		[RED("overrideExit")] 
		public CHandle<AIArgumentMapping> OverrideExit
		{
			get => GetProperty(ref _overrideExit);
			set => SetProperty(ref _overrideExit, value);
		}
	}
}
