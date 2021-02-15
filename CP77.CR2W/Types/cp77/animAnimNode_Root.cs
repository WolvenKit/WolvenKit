using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Root : animAnimNode_Container
	{
		[Ordinal(2)] [RED("outputNode")] public animPoseLink OutputNode { get; set; }

		public animAnimNode_Root(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
