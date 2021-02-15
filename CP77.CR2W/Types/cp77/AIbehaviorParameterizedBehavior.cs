using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorParameterizedBehavior : ISerializable
	{
		[Ordinal(0)] [RED("treeDefinition")] public rRef<AIbehaviorResource> TreeDefinition { get; set; }
		[Ordinal(1)] [RED("argumentsOverrides")] public CArray<AIArgumentOverrideWrapper> ArgumentsOverrides { get; set; }

		public AIbehaviorParameterizedBehavior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
