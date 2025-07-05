using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GalleryScreenshotFullPreview : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("screenshotContainer")] 
		public inkWidgetReference ScreenshotContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("screenshotMask")] 
		public inkWidgetReference ScreenshotMask
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("screenshotPreview")] 
		public inkImageWidgetReference ScreenshotPreview
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("windowWrapper")] 
		public inkWidgetReference WindowWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("favoriteIcon")] 
		public inkWidgetReference FavoriteIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("preloader")] 
		public CWeakHandle<inkCompoundWidget> Preloader
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(10)] 
		[RED("systemHandler")] 
		public CWeakHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>();
			set => SetPropertyValue<CWeakHandle<inkISystemRequestsHandler>>(value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<GalleryScreenshotPreviewData> Data
		{
			get => GetPropertyValue<CHandle<GalleryScreenshotPreviewData>>();
			set => SetPropertyValue<CHandle<GalleryScreenshotPreviewData>>(value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(13)] 
		[RED("deleteConfirmationToken")] 
		public CHandle<inkGameNotificationToken> DeleteConfirmationToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		public GalleryScreenshotFullPreview()
		{
			ButtonHintsManagerRef = new inkWidgetReference();
			ScreenshotContainer = new inkWidgetReference();
			ScreenshotMask = new inkWidgetReference();
			ScreenshotPreview = new inkImageWidgetReference();
			Container = new inkWidgetReference();
			WindowWrapper = new inkWidgetReference();
			FavoriteIcon = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
