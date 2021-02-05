using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapPreviewGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("viewTemplate")] public raRef<entEntityTemplate> ViewTemplate { get; set; }
		[Ordinal(2)]  [RED("viewEnvironmentDefinition")] public rRef<worldEnvironmentAreaParameters> ViewEnvironmentDefinition { get; set; }
		[Ordinal(3)]  [RED("cursorTemplate")] public raRef<entEntityTemplate> CursorTemplate { get; set; }

		public gameuiWorldMapPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
