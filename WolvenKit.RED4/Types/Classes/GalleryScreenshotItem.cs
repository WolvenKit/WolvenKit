using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GalleryScreenshotItem : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("screenshotPreview")] 
		public inkWidgetReference ScreenshotPreview
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("hoverFrame")] 
		public inkWidgetReference HoverFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("favoriteIcon")] 
		public inkWidgetReference FavoriteIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("emptyBackground")] 
		public inkWidgetReference EmptyBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("errorText")] 
		public inkWidgetReference ErrorText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("selectedBoder")] 
		public inkWidgetReference SelectedBoder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("preloader")] 
		public CWeakHandle<inkCompoundWidget> Preloader
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(9)] 
		[RED("basePreviewSize")] 
		public Vector2 BasePreviewSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(10)] 
		[RED("screenshotData")] 
		public CHandle<GalleryScreenshotPreviewData> ScreenshotData
		{
			get => GetPropertyValue<CHandle<GalleryScreenshotPreviewData>>();
			set => SetPropertyValue<CHandle<GalleryScreenshotPreviewData>>(value);
		}

		[Ordinal(11)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		[Ordinal(12)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("canBeHoveredOver")] 
		public CBool CanBeHoveredOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GalleryScreenshotItem()
		{
			ScreenshotPreview = new inkWidgetReference();
			Container = new inkWidgetReference();
			HoverFrame = new inkWidgetReference();
			FavoriteIcon = new inkWidgetReference();
			EmptyBackground = new inkWidgetReference();
			ErrorText = new inkWidgetReference();
			SelectedBoder = new inkWidgetReference();
			BasePreviewSize = new Vector2();
			CanBeHoveredOver = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
