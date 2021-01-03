using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldCompiledCommunityAreaNode : worldNode
	{
		[Ordinal(0)]  [RED("area")] public CHandle<communityArea> Area { get; set; }
		[Ordinal(1)]  [RED("sourceObjectId")] public entEntityID SourceObjectId { get; set; }

		public worldCompiledCommunityAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
