using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnsimActionsScenariosNodeScenarios : RedBaseClass
	{
		private scnNodeId _nodeId;
		private CArray<CHandle<scnsimIActionScenario>> _scenarios;
		private CHandle<scnsimIActionScenario> _fallback;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetProperty(ref _nodeId);
			set => SetProperty(ref _nodeId, value);
		}

		[Ordinal(1)] 
		[RED("scenarios")] 
		public CArray<CHandle<scnsimIActionScenario>> Scenarios
		{
			get => GetProperty(ref _scenarios);
			set => SetProperty(ref _scenarios, value);
		}

		[Ordinal(2)] 
		[RED("fallback")] 
		public CHandle<scnsimIActionScenario> Fallback
		{
			get => GetProperty(ref _fallback);
			set => SetProperty(ref _fallback, value);
		}
	}
}
