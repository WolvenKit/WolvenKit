using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_BoothMode : MenuScenario_PreGameSubMenu
	{
		[Ordinal(0)]  [RED("prevScenario")] public CName PrevScenario { get; set; }
		[Ordinal(1)]  [RED("currSubMenuName")] public CName CurrSubMenuName { get; set; }

		public MenuScenario_BoothMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
