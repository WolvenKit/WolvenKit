using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkPhotoModeLayerDefinition : inkLayerDefinition
	{
		private CResourceReference<inkWidgetLibraryResource> _photoModeResource;
		private CResourceReference<inkWidgetLibraryResource> _stickersResource;
		private CResourceReference<inkWidgetLibraryResource> _cursorResource;

		[Ordinal(8)] 
		[RED("photoModeResource")] 
		public CResourceReference<inkWidgetLibraryResource> PhotoModeResource
		{
			get => GetProperty(ref _photoModeResource);
			set => SetProperty(ref _photoModeResource, value);
		}

		[Ordinal(9)] 
		[RED("stickersResource")] 
		public CResourceReference<inkWidgetLibraryResource> StickersResource
		{
			get => GetProperty(ref _stickersResource);
			set => SetProperty(ref _stickersResource, value);
		}

		[Ordinal(10)] 
		[RED("cursorResource")] 
		public CResourceReference<inkWidgetLibraryResource> CursorResource
		{
			get => GetProperty(ref _cursorResource);
			set => SetProperty(ref _cursorResource, value);
		}
	}
}
