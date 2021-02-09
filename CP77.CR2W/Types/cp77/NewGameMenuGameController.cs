using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NewGameMenuGameController : PreGameSubMenuGameController
	{
		[Ordinal(1)]  [RED("categories")] public wCHandle<inkSelectorController> Categories { get; set; }
		[Ordinal(2)]  [RED("gameDefinitions")] public wCHandle<inkSelectorController> GameDefinitions { get; set; }
		[Ordinal(3)]  [RED("genders")] public wCHandle<inkSelectorController> Genders { get; set; }

		public NewGameMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
