using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCompiledCommunityAreaNode_Streamable : worldCompiledCommunityAreaNode
	{
		[Ordinal(6)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }

		public worldCompiledCommunityAreaNode_Streamable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
