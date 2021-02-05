using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorWaitingMountCommandConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("requestArgument")] public CHandle<AIArgumentMapping> RequestArgument { get; set; }
		[Ordinal(1)]  [RED("callbackName")] public CName CallbackName { get; set; }

		public AIbehaviorWaitingMountCommandConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
