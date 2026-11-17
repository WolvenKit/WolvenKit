using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioGalleryPreviewPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<ModioGalleryPreviewData> Data
		{
			get => GetPropertyValue<CHandle<ModioGalleryPreviewData>>();
			set => SetPropertyValue<CHandle<ModioGalleryPreviewData>>(value);
		}

		public ModioGalleryPreviewPopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
