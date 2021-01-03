using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
