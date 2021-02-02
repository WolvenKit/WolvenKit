using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkHudEntriesResource : CResource
	{
		[Ordinal(0)]  [RED("rootWidget")] public rRef<inkWidgetLibraryResource> RootWidget { get; set; }
		[Ordinal(1)]  [RED("entries")] public CArray<inkHudWidgetSpawnEntry> Entries { get; set; }
		[Ordinal(2)]  [RED("themeOverride")] public CName ThemeOverride { get; set; }

		public inkHudEntriesResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
