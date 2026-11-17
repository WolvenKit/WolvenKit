using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioGalleryPreviewData : GalleryPreviewData
	{
		[Ordinal(7)] 
		[RED("modDetailsItem")] 
		public CWeakHandle<ModDetailsItem> ModDetailsItem
		{
			get => GetPropertyValue<CWeakHandle<ModDetailsItem>>();
			set => SetPropertyValue<CWeakHandle<ModDetailsItem>>(value);
		}

		[Ordinal(8)] 
		[RED("ownerMenu")] 
		public CWeakHandle<BrowserModsMenuGameController> OwnerMenu
		{
			get => GetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>();
			set => SetPropertyValue<CWeakHandle<BrowserModsMenuGameController>>(value);
		}

		public ModioGalleryPreviewData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
