using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldWidgetComponent : IWorldWidgetComponent
	{
		[Ordinal(12)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(13)] 
		[RED("widgetResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> WidgetResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(14)] 
		[RED("itemNameToSpawn")] 
		public CName ItemNameToSpawn
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("staticTextureResource")] 
		public CResourceAsyncReference<CBitmapTexture> StaticTextureResource
		{
			get => GetPropertyValue<CResourceAsyncReference<CBitmapTexture>>();
			set => SetPropertyValue<CResourceAsyncReference<CBitmapTexture>>(value);
		}

		[Ordinal(16)] 
		[RED("sceneWidgetProperties")] 
		public worlduiSceneWidgetProperties SceneWidgetProperties
		{
			get => GetPropertyValue<worlduiSceneWidgetProperties>();
			set => SetPropertyValue<worlduiSceneWidgetProperties>(value);
		}

		[Ordinal(17)] 
		[RED("spawnDistanceOverride")] 
		public CFloat SpawnDistanceOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("limitedSpawnDistanceFromVehicle")] 
		public CBool LimitedSpawnDistanceFromVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
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
			SpawnDistanceOverride = -1.000000F;
			LimitedSpawnDistanceFromVehicle = true;
			ScreenDefinition = new();
		}
	}
}
