using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryItemInstance : ISerializable
	{
		[Ordinal(0)]  [RED("gameController")] public CHandle<inkIWidgetController> GameController { get; set; }
		[Ordinal(1)]  [RED("rootResolution")] public CEnum<inkETextureResolution> RootResolution { get; set; }
		[Ordinal(2)]  [RED("rootWidget")] public CHandle<inkWidget> RootWidget { get; set; }

		public inkWidgetLibraryItemInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
