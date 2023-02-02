using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeSticker : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("stickersController")] 
		public CWeakHandle<gameuiPhotoModeStickersController> StickersController
		{
			get => GetPropertyValue<CWeakHandle<gameuiPhotoModeStickersController>>();
			set => SetPropertyValue<CWeakHandle<gameuiPhotoModeStickersController>>(value);
		}

		public PhotoModeSticker()
		{
			Image = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
