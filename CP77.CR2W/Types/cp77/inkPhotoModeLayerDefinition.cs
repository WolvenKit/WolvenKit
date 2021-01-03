using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkPhotoModeLayerDefinition : inkLayerDefinition
	{
		[Ordinal(0)]  [RED("cursorResource")] public rRef<inkWidgetLibraryResource> CursorResource { get; set; }
		[Ordinal(1)]  [RED("photoModeResource")] public rRef<inkWidgetLibraryResource> PhotoModeResource { get; set; }
		[Ordinal(2)]  [RED("stickersResource")] public rRef<inkWidgetLibraryResource> StickersResource { get; set; }

		public inkPhotoModeLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
