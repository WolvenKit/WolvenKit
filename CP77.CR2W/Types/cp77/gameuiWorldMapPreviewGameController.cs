using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapPreviewGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("cursorTemplate")] public raRef<entEntityTemplate> CursorTemplate { get; set; }
		[Ordinal(1)]  [RED("viewEnvironmentDefinition")] public rRef<worldEnvironmentAreaParameters> ViewEnvironmentDefinition { get; set; }
		[Ordinal(2)]  [RED("viewTemplate")] public raRef<entEntityTemplate> ViewTemplate { get; set; }

		public gameuiWorldMapPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
