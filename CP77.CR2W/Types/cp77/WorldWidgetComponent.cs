using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(0)]  [RED("cursorResource")] public rRef<inkWidgetLibraryResource> CursorResource { get; set; }
		[Ordinal(1)]  [RED("widgetResource")] public raRef<inkWidgetLibraryResource> WidgetResource { get; set; }
		[Ordinal(2)]  [RED("itemNameToSpawn")] public CName ItemNameToSpawn { get; set; }
		[Ordinal(3)]  [RED("staticTextureResource")] public raRef<CBitmapTexture> StaticTextureResource { get; set; }
		[Ordinal(4)]  [RED("sceneWidgetProperties")] public worlduiSceneWidgetProperties SceneWidgetProperties { get; set; }
		[Ordinal(5)]  [RED("screenDefinition")] public SUIScreenDefinition ScreenDefinition { get; set; }

		public WorldWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
