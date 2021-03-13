using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickhacksListItemController : inkListItemController
	{
		[Ordinal(16)] [RED("expandAnimationDuration")] public CFloat ExpandAnimationDuration { get; set; }
		[Ordinal(17)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(18)] [RED("description")] public inkTextWidgetReference Description { get; set; }
		[Ordinal(19)] [RED("memoryValue")] public inkTextWidgetReference MemoryValue { get; set; }
		[Ordinal(20)] [RED("memoryCells")] public inkCompoundWidgetReference MemoryCells { get; set; }
		[Ordinal(21)] [RED("actionStateRoot")] public inkWidgetReference ActionStateRoot { get; set; }
		[Ordinal(22)] [RED("actionStateText")] public inkTextWidgetReference ActionStateText { get; set; }
		[Ordinal(23)] [RED("cooldownIcon")] public inkWidgetReference CooldownIcon { get; set; }
		[Ordinal(24)] [RED("cooldownValue")] public inkTextWidgetReference CooldownValue { get; set; }
		[Ordinal(25)] [RED("descriptionSize")] public inkWidgetReference DescriptionSize { get; set; }
		[Ordinal(26)] [RED("costReductionArrow")] public inkWidgetReference CostReductionArrow { get; set; }
		[Ordinal(27)] [RED("curveRadius")] public CFloat CurveRadius { get; set; }
		[Ordinal(28)] [RED("selectedLoop")] public CHandle<inkanimProxy> SelectedLoop { get; set; }
		[Ordinal(29)] [RED("currentAnimationName")] public CName CurrentAnimationName { get; set; }
		[Ordinal(30)] [RED("choiceAccepted")] public CHandle<inkanimProxy> ChoiceAccepted { get; set; }
		[Ordinal(31)] [RED("resizeAnim")] public CHandle<inkanimController> ResizeAnim { get; set; }
		[Ordinal(32)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(33)] [RED("data")] public CHandle<QuickhackData> Data { get; set; }
		[Ordinal(34)] [RED("isSelected")] public CBool IsSelected { get; set; }
		[Ordinal(35)] [RED("expanded")] public CBool Expanded { get; set; }
		[Ordinal(36)] [RED("cachedDescriptionSize")] public Vector2 CachedDescriptionSize { get; set; }
		[Ordinal(37)] [RED("defaultMargin")] public inkMargin DefaultMargin { get; set; }

		public QuickhacksListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
