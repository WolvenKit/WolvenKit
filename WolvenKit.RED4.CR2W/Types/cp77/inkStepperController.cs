using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStepperController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("cycledNavigation")] public CBool CycledNavigation { get; set; }
		[Ordinal(2)] [RED("indicatorUnitLibraryID")] public CName IndicatorUnitLibraryID { get; set; }
		[Ordinal(3)] [RED("currentValueDisplay")] public inkTextWidgetReference CurrentValueDisplay { get; set; }
		[Ordinal(4)] [RED("indicatorContainer")] public inkCompoundWidgetReference IndicatorContainer { get; set; }
		[Ordinal(5)] [RED("leftButton")] public inkWidgetReference LeftButton { get; set; }
		[Ordinal(6)] [RED("rightButton")] public inkWidgetReference RightButton { get; set; }
		[Ordinal(7)] [RED("Change")] public inkStepperChangedCallback Change { get; set; }

		public inkStepperController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
