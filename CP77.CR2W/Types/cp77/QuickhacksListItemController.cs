using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuickhacksListItemController : inkListItemController
	{
		[Ordinal(0)]  [RED("labelPathRef")] public inkTextWidgetReference LabelPathRef { get; set; }
		[Ordinal(1)]  [RED("expandAnimationDuration")] public CFloat ExpandAnimationDuration { get; set; }
		[Ordinal(2)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)]  [RED("description")] public inkTextWidgetReference Description { get; set; }
		[Ordinal(4)]  [RED("memoryValue")] public inkTextWidgetReference MemoryValue { get; set; }
		[Ordinal(5)]  [RED("memoryCells")] public inkCompoundWidgetReference MemoryCells { get; set; }
		[Ordinal(6)]  [RED("actionStateRoot")] public inkWidgetReference ActionStateRoot { get; set; }
		[Ordinal(7)]  [RED("actionStateText")] public inkTextWidgetReference ActionStateText { get; set; }
		[Ordinal(8)]  [RED("cooldownIcon")] public inkWidgetReference CooldownIcon { get; set; }
		[Ordinal(9)]  [RED("cooldownValue")] public inkTextWidgetReference CooldownValue { get; set; }
		[Ordinal(10)]  [RED("descriptionSize")] public inkWidgetReference DescriptionSize { get; set; }
		[Ordinal(11)]  [RED("costReductionArrow")] public inkWidgetReference CostReductionArrow { get; set; }
		[Ordinal(12)]  [RED("curveRadius")] public CFloat CurveRadius { get; set; }
		[Ordinal(13)]  [RED("selectedLoop")] public CHandle<inkanimProxy> SelectedLoop { get; set; }
		[Ordinal(14)]  [RED("currentAnimationName")] public CName CurrentAnimationName { get; set; }
		[Ordinal(15)]  [RED("choiceAccepted")] public CHandle<inkanimProxy> ChoiceAccepted { get; set; }
		[Ordinal(16)]  [RED("resizeAnim")] public CHandle<inkanimController> ResizeAnim { get; set; }
		[Ordinal(17)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(18)]  [RED("data")] public CHandle<QuickhackData> Data { get; set; }
		[Ordinal(19)]  [RED("isSelected")] public CBool IsSelected { get; set; }
		[Ordinal(20)]  [RED("expanded")] public CBool Expanded { get; set; }
		[Ordinal(21)]  [RED("cachedDescriptionSize")] public Vector2 CachedDescriptionSize { get; set; }
		[Ordinal(22)]  [RED("defaultMargin")] public inkMargin DefaultMargin { get; set; }

		public QuickhacksListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
