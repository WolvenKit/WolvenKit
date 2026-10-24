using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GalleryScreenshotFullPreview : GalleryFullPreview
	{
		[Ordinal(13)] 
		[RED("favoriteIcon")] 
		public inkWidgetReference FavoriteIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public GalleryScreenshotFullPreview()
		{
			FavoriteIcon = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
