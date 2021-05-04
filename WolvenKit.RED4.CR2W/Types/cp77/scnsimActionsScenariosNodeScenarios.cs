using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnsimActionsScenariosNodeScenarios : CVariable
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

		public scnsimActionsScenariosNodeScenarios(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
