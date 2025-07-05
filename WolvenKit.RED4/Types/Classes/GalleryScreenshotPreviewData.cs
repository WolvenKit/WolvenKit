using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GalleryScreenshotPreviewData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("screenshotIndex")] 
		public CInt32 ScreenshotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("screenshotWidth")] 
		public CInt32 ScreenshotWidth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("screenshotHeight")] 
		public CInt32 ScreenshotHeight
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("Path")] 
		public CString Path
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("Hash")] 
		public CUInt32 Hash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("creationDate")] 
		public CUInt64 CreationDate
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(13)] 
		[RED("isFavorite")] 
		public CBool IsFavorite
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("canBeDeleted")] 
		public CBool CanBeDeleted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("screenshotItem")] 
		public CWeakHandle<GalleryScreenshotItem> ScreenshotItem
		{
			get => GetPropertyValue<CWeakHandle<GalleryScreenshotItem>>();
			set => SetPropertyValue<CWeakHandle<GalleryScreenshotItem>>(value);
		}

		[Ordinal(16)] 
		[RED("favoriteManager")] 
		public CWeakHandle<GalleryFavoriteManager> FavoriteManager
		{
			get => GetPropertyValue<CWeakHandle<GalleryFavoriteManager>>();
			set => SetPropertyValue<CWeakHandle<GalleryFavoriteManager>>(value);
		}

		[Ordinal(17)] 
		[RED("galleryController")] 
		public CWeakHandle<GalleryMenuGameController> GalleryController
		{
			get => GetPropertyValue<CWeakHandle<GalleryMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<GalleryMenuGameController>>(value);
		}

		public GalleryScreenshotPreviewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
