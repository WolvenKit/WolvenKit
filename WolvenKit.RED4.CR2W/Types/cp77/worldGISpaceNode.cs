using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldGISpaceNode : worldAreaShapeNode
	{
		[Ordinal(6)] [RED("priority")] public CUInt32 Priority { get; set; }
		[Ordinal(7)] [RED("group")] public CEnum<rendGIGroup> Group { get; set; }
		[Ordinal(8)] [RED("interior")] public CBool Interior { get; set; }
		[Ordinal(9)] [RED("runtime")] public CBool Runtime { get; set; }
		[Ordinal(10)] [RED("updated")] public CBool Updated { get; set; }

		public worldGISpaceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
