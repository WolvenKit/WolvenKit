using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_PreGameSubMenu : inkMenuScenario
	{
		[Ordinal(0)]  [RED("currSubMenuName")] public CName CurrSubMenuName { get; set; }
		[Ordinal(1)]  [RED("prevScenario")] public CName PrevScenario { get; set; }

		public MenuScenario_PreGameSubMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
