using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DebugMenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		[Ordinal(0)]  [RED("cpoDefaultMenu")] public CName CpoDefaultMenu { get; set; }
		[Ordinal(1)]  [RED("defaultMenu")] public CName DefaultMenu { get; set; }

		public DebugMenuScenario_HubMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
