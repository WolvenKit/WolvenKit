using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioGalleryPreviewImageController : AnimatedListItemController
	{
		[Ordinal(33)] 
		[RED("modDetailsItem")] 
		public CWeakHandle<ModDetailsItem> ModDetailsItem
		{
			get => GetPropertyValue<CWeakHandle<ModDetailsItem>>();
			set => SetPropertyValue<CWeakHandle<ModDetailsItem>>(value);
		}

		[Ordinal(34)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		public ModioGalleryPreviewImageController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
