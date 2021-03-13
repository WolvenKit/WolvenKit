using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCompiledCommunityAreaNode : worldNode
	{
		[Ordinal(4)] [RED("area")] public CHandle<communityArea> Area { get; set; }
		[Ordinal(5)] [RED("sourceObjectId")] public entEntityID SourceObjectId { get; set; }

		public worldCompiledCommunityAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
