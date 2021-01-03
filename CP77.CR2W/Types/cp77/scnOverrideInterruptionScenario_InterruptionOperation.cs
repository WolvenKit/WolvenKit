using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnOverrideInterruptionScenario_InterruptionOperation : scnIInterruptionOperation
	{
		[Ordinal(0)]  [RED("scenarioId")] public scnInterruptionScenarioId ScenarioId { get; set; }
		[Ordinal(1)]  [RED("scenarioOperations")] public CArray<CHandle<scnIInterruptionScenarioOperation>> ScenarioOperations { get; set; }

		public scnOverrideInterruptionScenario_InterruptionOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
