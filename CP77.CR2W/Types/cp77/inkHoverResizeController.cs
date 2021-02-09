using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkHoverResizeController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(1)]  [RED("animToNew")] public CHandle<inkanimDefinition> AnimToNew { get; set; }
		[Ordinal(2)]  [RED("animToOld")] public CHandle<inkanimDefinition> AnimToOld { get; set; }
		[Ordinal(3)]  [RED("vectorNewSize")] public Vector2 VectorNewSize { get; set; }
		[Ordinal(4)]  [RED("vectorOldSize")] public Vector2 VectorOldSize { get; set; }
		[Ordinal(5)]  [RED("animationDuration")] public CFloat AnimationDuration { get; set; }

		public inkHoverResizeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
