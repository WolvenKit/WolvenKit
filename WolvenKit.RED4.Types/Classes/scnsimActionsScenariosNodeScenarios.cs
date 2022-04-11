using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnsimActionsScenariosNodeScenarios : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		[Ordinal(1)] 
		[RED("scenarios")] 
		public CArray<CHandle<scnsimIActionScenario>> Scenarios
		{
			get => GetPropertyValue<CArray<CHandle<scnsimIActionScenario>>>();
			set => SetPropertyValue<CArray<CHandle<scnsimIActionScenario>>>(value);
		}

		[Ordinal(2)] 
		[RED("fallback")] 
		public CHandle<scnsimIActionScenario> Fallback
		{
			get => GetPropertyValue<CHandle<scnsimIActionScenario>>();
			set => SetPropertyValue<CHandle<scnsimIActionScenario>>(value);
		}

		public scnsimActionsScenariosNodeScenarios()
		{
			NodeId = new() { Id = 4294967295 };
			Scenarios = new();
		}
	}
}
