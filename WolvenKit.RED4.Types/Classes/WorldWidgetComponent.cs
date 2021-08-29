using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldWidgetComponent : IWorldWidgetComponent
	{
		private CResourceReference<inkWidgetLibraryResource> _cursorResource;
		private CResourceAsyncReference<inkWidgetLibraryResource> _widgetResource;
		private CName _itemNameToSpawn;
		private CResourceAsyncReference<CBitmapTexture> _staticTextureResource;
		private worlduiSceneWidgetProperties _sceneWidgetProperties;
		private SUIScreenDefinition _screenDefinition;

		[Ordinal(10)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetProperty(ref _cursorResource);
			set => SetProperty(ref _cursorResource, value);
		}

		[Ordinal(11)] 
		[RED("widgetResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> WidgetResource
		{
			get => GetProperty(ref _widgetResource);
			set => SetProperty(ref _widgetResource, value);
		}

		[Ordinal(12)] 
		[RED("itemNameToSpawn")] 
		public CName ItemNameToSpawn
		{
			get => GetProperty(ref _itemNameToSpawn);
			set => SetProperty(ref _itemNameToSpawn, value);
		}

		[Ordinal(13)] 
		[RED("staticTextureResource")] 
		public CResourceAsyncReference<CBitmapTexture> StaticTextureResource
		{
			get => GetProperty(ref _staticTextureResource);
			set => SetProperty(ref _staticTextureResource, value);
		}

		[Ordinal(14)] 
		[RED("sceneWidgetProperties")] 
		public worlduiSceneWidgetProperties SceneWidgetProperties
		{
			get => GetProperty(ref _sceneWidgetProperties);
			set => SetProperty(ref _sceneWidgetProperties, value);
		}

		[Ordinal(15)] 
		[RED("screenDefinition")] 
		public SUIScreenDefinition ScreenDefinition
		{
			get => GetProperty(ref _screenDefinition);
			set => SetProperty(ref _screenDefinition, value);
		}
	}
}
