using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimateAnchorOnHoverView : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("Raycaster")] public inkWidgetReference Raycaster { get; set; }
		[Ordinal(2)] [RED("AnimProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(3)] [RED("HoverAnchor")] public Vector2 HoverAnchor { get; set; }
		[Ordinal(4)] [RED("NormalAnchor")] public Vector2 NormalAnchor { get; set; }
		[Ordinal(5)] [RED("AnimTime")] public CFloat AnimTime { get; set; }

		public AnimateAnchorOnHoverView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
