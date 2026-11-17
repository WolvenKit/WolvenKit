using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GalleryArrowController : AnimatedListItemController
	{
		[Ordinal(33)] 
		[RED("bIsLeftArrow")] 
		public CBool BIsLeftArrow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("modGalleryPreview")] 
		public CWeakHandle<ModioGalleryFullPreview> ModGalleryPreview
		{
			get => GetPropertyValue<CWeakHandle<ModioGalleryFullPreview>>();
			set => SetPropertyValue<CWeakHandle<ModioGalleryFullPreview>>(value);
		}

		public GalleryArrowController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
