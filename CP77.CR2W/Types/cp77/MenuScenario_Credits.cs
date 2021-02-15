using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_Credits : MenuScenario_PreGameSubMenu
	{
		public MenuScenario_Credits(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
