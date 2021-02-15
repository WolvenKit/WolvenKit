using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorInstantConditionDefinition : ISerializable
	{
		[Ordinal(0)] [RED("condition")] public CHandle<AIbehaviorConditionDefinition> Condition { get; set; }

		public AIbehaviorInstantConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
