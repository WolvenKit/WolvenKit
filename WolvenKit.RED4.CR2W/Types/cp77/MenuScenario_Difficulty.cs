using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_Difficulty : MenuScenario_PreGameSubMenu
	{
		public MenuScenario_Difficulty(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
