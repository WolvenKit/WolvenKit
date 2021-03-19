using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldWidgetComponent : IWorldWidgetComponent
	{
		private rRef<inkWidgetLibraryResource> _cursorResource;
		private raRef<inkWidgetLibraryResource> _widgetResource;
		private CName _itemNameToSpawn;
		private raRef<CBitmapTexture> _staticTextureResource;
		private worlduiSceneWidgetProperties _sceneWidgetProperties;
		private SUIScreenDefinition _screenDefinition;

		[Ordinal(10)] 
		[RED("cursorResource")] 
		public rRef<inkWidgetLibraryResource> CursorResource
		{
			get => GetProperty(ref _cursorResource);
			set => SetProperty(ref _cursorResource, value);
		}

		[Ordinal(11)] 
		[RED("widgetResource")] 
		public raRef<inkWidgetLibraryResource> WidgetResource
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
		public raRef<CBitmapTexture> StaticTextureResource
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

		public WorldWidgetComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
