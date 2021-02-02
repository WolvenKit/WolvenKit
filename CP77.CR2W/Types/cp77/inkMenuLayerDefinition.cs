using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkMenuLayerDefinition : inkLayerDefinition
	{
		[Ordinal(0)]  [RED("menuResource")] public rRef<inkMenuResource> MenuResource { get; set; }
		[Ordinal(1)]  [RED("cursorResource")] public rRef<inkWidgetLibraryResource> CursorResource { get; set; }

		public inkMenuLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
