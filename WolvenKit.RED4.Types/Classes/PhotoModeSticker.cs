using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhotoModeSticker : inkWidgetLogicController
	{
		private inkImageWidgetReference _image;
		private CWeakHandle<gameuiPhotoModeStickersController> _stickersController;

		[Ordinal(1)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(2)] 
		[RED("stickersController")] 
		public CWeakHandle<gameuiPhotoModeStickersController> StickersController
		{
			get => GetProperty(ref _stickersController);
			set => SetProperty(ref _stickersController, value);
		}
	}
}
