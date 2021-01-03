using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SpawnLibraryItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("libraryID")] public CName LibraryID { get; set; }

		public SpawnLibraryItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
