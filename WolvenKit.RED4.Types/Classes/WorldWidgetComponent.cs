using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(10)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(11)] 
		[RED("widgetResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> WidgetResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(12)] 
		[RED("itemNameToSpawn")] 
		public CName ItemNameToSpawn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("staticTextureResource")] 
		public CResourceAsyncReference<CBitmapTexture> StaticTextureResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		[Ordinal(14)] 
		[RED("sceneWidgetProperties")] 
		public worlduiSceneWidgetProperties SceneWidgetProperties
		{
			get => GetPropertyValue<worlduiSceneWidgetProperties>();
			set => SetPropertyValue<worlduiSceneWidgetProperties>(value);
		}

		[Ordinal(15)] 
		[RED("screenDefinition")] 
		public SUIScreenDefinition ScreenDefinition
		{
			get => GetPropertyValue<SUIScreenDefinition>();
			set => SetPropertyValue<SUIScreenDefinition>(value);
		}

		public WorldWidgetComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			TintColor = new();
			ScreenAreaMultiplier = 1.000000F;
			IsEnabled = true;
			SceneWidgetProperties = new() { ProjectionPlaneSize = new() { X = 1.000000F, Y = 1.000000F }, FaceVector = new() };
			ScreenDefinition = new();
		}
	}
}
