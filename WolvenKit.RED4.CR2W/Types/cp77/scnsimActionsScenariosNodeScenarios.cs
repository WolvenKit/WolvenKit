using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnsimActionsScenariosNodeScenarios : CVariable
	{
		[Ordinal(0)] [RED("nodeId")] public scnNodeId NodeId { get; set; }
		[Ordinal(1)] [RED("scenarios")] public CArray<CHandle<scnsimIActionScenario>> Scenarios { get; set; }
		[Ordinal(2)] [RED("fallback")] public CHandle<scnsimIActionScenario> Fallback { get; set; }

		public scnsimActionsScenariosNodeScenarios(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
