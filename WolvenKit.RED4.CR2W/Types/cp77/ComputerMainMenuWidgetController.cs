using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerMainMenuWidgetController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("menuButtonsListWidget")] public inkWidgetReference MenuButtonsListWidget { get; set; }
		[Ordinal(2)] [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(3)] [RED("computerMenuButtonWidgetsData")] public CArray<SComputerMenuButtonWidgetPackage> ComputerMenuButtonWidgetsData { get; set; }

		public ComputerMainMenuWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
