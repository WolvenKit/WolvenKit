using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkStepperController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("Change")] public inkStepperChangedCallback Change { get; set; }
		[Ordinal(1)]  [RED("currentValueDisplay")] public inkTextWidgetReference CurrentValueDisplay { get; set; }
		[Ordinal(2)]  [RED("cycledNavigation")] public CBool CycledNavigation { get; set; }
		[Ordinal(3)]  [RED("indicatorContainer")] public inkCompoundWidgetReference IndicatorContainer { get; set; }
		[Ordinal(4)]  [RED("indicatorUnitLibraryID")] public CName IndicatorUnitLibraryID { get; set; }
		[Ordinal(5)]  [RED("leftButton")] public inkWidgetReference LeftButton { get; set; }
		[Ordinal(6)]  [RED("rightButton")] public inkWidgetReference RightButton { get; set; }

		public inkStepperController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
