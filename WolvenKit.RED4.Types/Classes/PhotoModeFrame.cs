using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhotoModeFrame : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("images")] 
		public CArray<inkImageWidgetReference> Images
		{
			get => GetPropertyValue<CArray<inkImageWidgetReference>>();
			set => SetPropertyValue<CArray<inkImageWidgetReference>>(value);
		}

		[Ordinal(2)] 
		[RED("keepImageAspectRatio")] 
		public CBool KeepImageAspectRatio
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("stickersController")] 
		public CWeakHandle<gameuiPhotoModeStickersController> StickersController
		{
			get => GetPropertyValue<CWeakHandle<gameuiPhotoModeStickersController>>();
			set => SetPropertyValue<CWeakHandle<gameuiPhotoModeStickersController>>(value);
		}

		[Ordinal(4)] 
		[RED("currentImagePart")] 
		public CName CurrentImagePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PhotoModeFrame()
		{
			Images = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
