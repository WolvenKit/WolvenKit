using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MenuItemController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("menuData")] public MenuData MenuData { get; set; }
		[Ordinal(2)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(3)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(4)] [RED("frameHovered")] public inkWidgetReference FrameHovered { get; set; }
		[Ordinal(5)] [RED("hoverPanel")] public inkWidgetReference HoverPanel { get; set; }
		[Ordinal(6)] [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(7)] [RED("levelFlag")] public inkWidgetReference LevelFlag { get; set; }
		[Ordinal(8)] [RED("attrFlag")] public inkWidgetReference AttrFlag { get; set; }
		[Ordinal(9)] [RED("attrText")] public inkTextWidgetReference AttrText { get; set; }
		[Ordinal(10)] [RED("perkFlag")] public inkWidgetReference PerkFlag { get; set; }
		[Ordinal(11)] [RED("perkText")] public inkTextWidgetReference PerkText { get; set; }
		[Ordinal(12)] [RED("itemHovered")] public CBool ItemHovered { get; set; }
		[Ordinal(13)] [RED("panelHovered")] public CBool PanelHovered { get; set; }
		[Ordinal(14)] [RED("panelTransitionProxy")] public CHandle<inkanimProxy> PanelTransitionProxy { get; set; }
		[Ordinal(15)] [RED("buttonTransitionProxy")] public CHandle<inkanimProxy> ButtonTransitionProxy { get; set; }
		[Ordinal(16)] [RED("isPanelShown")] public CBool IsPanelShown { get; set; }
		[Ordinal(17)] [RED("isDimmed")] public CBool IsDimmed { get; set; }
		[Ordinal(18)] [RED("isHyperlink")] public CBool IsHyperlink { get; set; }

		public MenuItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
