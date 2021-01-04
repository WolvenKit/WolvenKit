using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnsimActionsScenariosNodeScenarios : CVariable
	{
		[Ordinal(0)]  [RED("fallback")] public CHandle<scnsimIActionScenario> Fallback { get; set; }
		[Ordinal(1)]  [RED("nodeId")] public scnNodeId NodeId { get; set; }
		[Ordinal(2)]  [RED("scenarios")] public CArray<CHandle<scnsimIActionScenario>> Scenarios { get; set; }

		public scnsimActionsScenariosNodeScenarios(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
