using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldGIShapeNode : worldGeometryShapeNode
	{
		[Ordinal(0)]  [RED("group")] public CEnum<rendGIGroup> Group { get; set; }
		[Ordinal(1)]  [RED("interior")] public CBool Interior { get; set; }
		[Ordinal(2)]  [RED("priority")] public CUInt32 Priority { get; set; }
		[Ordinal(3)]  [RED("runtime")] public CBool Runtime { get; set; }
		[Ordinal(4)]  [RED("updated")] public CBool Updated { get; set; }

		public worldGIShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
