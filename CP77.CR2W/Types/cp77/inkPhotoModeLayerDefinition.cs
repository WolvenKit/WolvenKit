using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkPhotoModeLayerDefinition : inkLayerDefinition
	{
		[Ordinal(0)]  [RED("photoModeResource")] public rRef<inkWidgetLibraryResource> PhotoModeResource { get; set; }
		[Ordinal(1)]  [RED("stickersResource")] public rRef<inkWidgetLibraryResource> StickersResource { get; set; }
		[Ordinal(2)]  [RED("cursorResource")] public rRef<inkWidgetLibraryResource> CursorResource { get; set; }

		public inkPhotoModeLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
