using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_PreGameSubMenu : inkMenuScenario
	{
		[Ordinal(0)] [RED("prevScenario")] public CName PrevScenario { get; set; }
		[Ordinal(1)] [RED("currSubMenuName")] public CName CurrSubMenuName { get; set; }

		public MenuScenario_PreGameSubMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
