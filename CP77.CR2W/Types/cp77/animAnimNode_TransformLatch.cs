using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformLatch : animAnimNode_TransformValue
	{
		[Ordinal(0)]  [RED("input")] public animTransformLink Input { get; set; }

		public animAnimNode_TransformLatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
