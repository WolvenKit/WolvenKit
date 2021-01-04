using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeBrainDefinition : AICTreeNodeCompositeDefinition
	{
		[Ordinal(0)]  [RED("children")] public CArray<CHandle<LibTreeINodeDefinition>> Children { get; set; }
		[Ordinal(1)]  [RED("useScoring")] public CBool UseScoring { get; set; }

		public AICTreeNodeBrainDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
