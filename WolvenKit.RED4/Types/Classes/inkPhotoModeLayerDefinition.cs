using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkPhotoModeLayerDefinition : inkLayerDefinition
	{
		[Ordinal(8)] 
		[RED("photoModeResource")] 
		public CResourceReference<inkWidgetLibraryResource> PhotoModeResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(9)] 
		[RED("stickersResource")] 
		public CResourceReference<inkWidgetLibraryResource> StickersResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(10)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetPropertyValue<CResourceReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceReference<inkWidgetLibraryResource>>(value);
		}

		public inkPhotoModeLayerDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
