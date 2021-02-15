using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExtractMountDataTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("mountEventData")] public CHandle<AIArgumentMapping> MountEventData { get; set; }
		[Ordinal(2)] [RED("outWorkspotData")] public CHandle<AIArgumentMapping> OutWorkspotData { get; set; }
		[Ordinal(3)] [RED("outIsInstant")] public CHandle<AIArgumentMapping> OutIsInstant { get; set; }

		public AIbehaviorExtractMountDataTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
