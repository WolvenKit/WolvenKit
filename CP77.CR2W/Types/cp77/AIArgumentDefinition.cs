using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIArgumentDefinition : ISerializable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("isPersistent")] public CBool IsPersistent { get; set; }
		[Ordinal(2)] [RED("behaviorCallbackName")] public CName BehaviorCallbackName { get; set; }

		public AIArgumentDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
