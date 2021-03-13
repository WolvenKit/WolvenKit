using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledCommunityAreaNode : worldNode
	{
		[Ordinal(4)] [RED("area")] public CHandle<communityArea> Area { get; set; }
		[Ordinal(5)] [RED("sourceObjectId")] public entEntityID SourceObjectId { get; set; }

		public worldCompiledCommunityAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
