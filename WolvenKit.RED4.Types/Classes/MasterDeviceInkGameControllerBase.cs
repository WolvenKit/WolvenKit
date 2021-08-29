using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MasterDeviceInkGameControllerBase : DeviceInkGameControllerBase
	{
		private CArray<SThumbnailWidgetPackage> _thumbnailWidgetsData;
		private CHandle<redCallbackObject> _onThumbnailWidgetsUpdateListener;

		[Ordinal(16)] 
		[RED("thumbnailWidgetsData")] 
		public CArray<SThumbnailWidgetPackage> ThumbnailWidgetsData
		{
			get => GetProperty(ref _thumbnailWidgetsData);
			set => SetProperty(ref _thumbnailWidgetsData, value);
		}

		[Ordinal(17)] 
		[RED("onThumbnailWidgetsUpdateListener")] 
		public CHandle<redCallbackObject> OnThumbnailWidgetsUpdateListener
		{
			get => GetProperty(ref _onThumbnailWidgetsUpdateListener);
			set => SetProperty(ref _onThumbnailWidgetsUpdateListener, value);
		}
	}
}
