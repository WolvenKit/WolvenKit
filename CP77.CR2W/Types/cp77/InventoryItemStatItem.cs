using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryItemStatItem : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("differenceBar")] public wCHandle<StatisticDifferenceBarController> DifferenceBar { get; set; }
		[Ordinal(1)]  [RED("differenceBarRef")] public inkWidgetReference DifferenceBarRef { get; set; }
		[Ordinal(2)]  [RED("diffrenceArrowIndicatorRef")] public inkWidgetReference DiffrenceArrowIndicatorRef { get; set; }
		[Ordinal(3)]  [RED("labelText")] public inkTextWidgetReference LabelText { get; set; }
		[Ordinal(4)]  [RED("negativeState")] public CName NegativeState { get; set; }
		[Ordinal(5)]  [RED("positiveState")] public CName PositiveState { get; set; }
		[Ordinal(6)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(7)]  [RED("valueText")] public inkTextWidgetReference ValueText { get; set; }

		public InventoryItemStatItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
