using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NewGameMenuGameController : PreGameSubMenuGameController
	{
		[Ordinal(0)]  [RED("categories")] public wCHandle<inkSelectorController> Categories { get; set; }
		[Ordinal(1)]  [RED("gameDefinitions")] public wCHandle<inkSelectorController> GameDefinitions { get; set; }
		[Ordinal(2)]  [RED("genders")] public wCHandle<inkSelectorController> Genders { get; set; }

		public NewGameMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
