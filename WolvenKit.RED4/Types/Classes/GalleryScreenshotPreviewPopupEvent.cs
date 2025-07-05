using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GalleryScreenshotPreviewPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<GalleryScreenshotPreviewData> Data
		{
			get => GetPropertyValue<CHandle<GalleryScreenshotPreviewData>>();
			set => SetPropertyValue<CHandle<GalleryScreenshotPreviewData>>(value);
		}

		public GalleryScreenshotPreviewPopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
