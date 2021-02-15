using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemLogPopupLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("quantity")] public inkTextWidgetReference Quantity { get; set; }
		[Ordinal(2)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(4)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(5)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(6)] [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(7)] [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }

		public ItemLogPopupLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
