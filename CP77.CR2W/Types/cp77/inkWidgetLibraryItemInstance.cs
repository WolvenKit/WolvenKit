using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryItemInstance : ISerializable
	{
		[Ordinal(0)] [RED("rootWidget")] public CHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(1)] [RED("gameController")] public CHandle<inkIWidgetController> GameController { get; set; }
		[Ordinal(2)] [RED("rootResolution")] public CEnum<inkETextureResolution> RootResolution { get; set; }

		public inkWidgetLibraryItemInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
