using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeFrame : inkWidgetLogicController
	{
		private CArray<inkImageWidgetReference> _images;
		private CBool _keepImageAspectRatio;
		private wCHandle<gameuiPhotoModeStickersController> _stickersController;
		private CName _currentImagePart;
		private CFloat _opacity;

		[Ordinal(1)] 
		[RED("images")] 
		public CArray<inkImageWidgetReference> Images
		{
			get => GetProperty(ref _images);
			set => SetProperty(ref _images, value);
		}

		[Ordinal(2)] 
		[RED("keepImageAspectRatio")] 
		public CBool KeepImageAspectRatio
		{
			get => GetProperty(ref _keepImageAspectRatio);
			set => SetProperty(ref _keepImageAspectRatio, value);
		}

		[Ordinal(3)] 
		[RED("stickersController")] 
		public wCHandle<gameuiPhotoModeStickersController> StickersController
		{
			get => GetProperty(ref _stickersController);
			set => SetProperty(ref _stickersController, value);
		}

		[Ordinal(4)] 
		[RED("currentImagePart")] 
		public CName CurrentImagePart
		{
			get => GetProperty(ref _currentImagePart);
			set => SetProperty(ref _currentImagePart, value);
		}

		[Ordinal(5)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetProperty(ref _opacity);
			set => SetProperty(ref _opacity, value);
		}

		public PhotoModeFrame(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
