using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTaskDefinition : ISerializable
	{
		[Ordinal(0)] [RED("ignoreTaskCompletion")] public CBool IgnoreTaskCompletion { get; set; }

		public AIbehaviorTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
