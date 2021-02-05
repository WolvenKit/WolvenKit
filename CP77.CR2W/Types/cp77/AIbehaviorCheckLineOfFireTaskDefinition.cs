using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCheckLineOfFireTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("slotName")] public CHandle<AIArgumentMapping> SlotName { get; set; }
		[Ordinal(1)]  [RED("attachmentName")] public CHandle<AIArgumentMapping> AttachmentName { get; set; }
		[Ordinal(2)]  [RED("spread")] public CHandle<AIArgumentMapping> Spread { get; set; }
		[Ordinal(3)]  [RED("maxRange")] public CHandle<AIArgumentMapping> MaxRange { get; set; }

		public AIbehaviorCheckLineOfFireTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
