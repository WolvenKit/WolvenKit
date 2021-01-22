using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_VectorLatch : animAnimNode_VectorValue
	{
		[Ordinal(0)]  [RED("input")] public animVectorLink Input { get; set; }

		public animAnimNode_VectorLatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
