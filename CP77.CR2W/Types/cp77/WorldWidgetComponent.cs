using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WorldWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(0)]  [RED("cursorResource")] public rRef<inkWidgetLibraryResource> CursorResource { get; set; }
		[Ordinal(1)]  [RED("itemNameToSpawn")] public CName ItemNameToSpawn { get; set; }
		[Ordinal(2)]  [RED("sceneWidgetProperties")] public worlduiSceneWidgetProperties SceneWidgetProperties { get; set; }
		[Ordinal(3)]  [RED("screenDefinition")] public SUIScreenDefinition ScreenDefinition { get; set; }
		[Ordinal(4)]  [RED("staticTextureResource")] public raRef<CBitmapTexture> StaticTextureResource { get; set; }
		[Ordinal(5)]  [RED("widgetResource")] public raRef<inkWidgetLibraryResource> WidgetResource { get; set; }

		public WorldWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
