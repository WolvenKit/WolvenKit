using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(10)] [RED("cursorResource")] public rRef<inkWidgetLibraryResource> CursorResource { get; set; }
		[Ordinal(11)] [RED("widgetResource")] public raRef<inkWidgetLibraryResource> WidgetResource { get; set; }
		[Ordinal(12)] [RED("itemNameToSpawn")] public CName ItemNameToSpawn { get; set; }
		[Ordinal(13)] [RED("staticTextureResource")] public raRef<CBitmapTexture> StaticTextureResource { get; set; }
		[Ordinal(14)] [RED("sceneWidgetProperties")] public worlduiSceneWidgetProperties SceneWidgetProperties { get; set; }
		[Ordinal(15)] [RED("screenDefinition")] public SUIScreenDefinition ScreenDefinition { get; set; }

		public WorldWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
