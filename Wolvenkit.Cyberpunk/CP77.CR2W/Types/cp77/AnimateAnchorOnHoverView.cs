using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimateAnchorOnHoverView : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("AnimProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("AnimTime")] public CFloat AnimTime { get; set; }
		[Ordinal(2)]  [RED("HoverAnchor")] public Vector2 HoverAnchor { get; set; }
		[Ordinal(3)]  [RED("NormalAnchor")] public Vector2 NormalAnchor { get; set; }
		[Ordinal(4)]  [RED("Raycaster")] public inkWidgetReference Raycaster { get; set; }

		public AnimateAnchorOnHoverView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
