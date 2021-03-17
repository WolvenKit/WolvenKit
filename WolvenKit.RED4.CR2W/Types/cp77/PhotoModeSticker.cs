using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeSticker : inkWidgetLogicController
	{
		private inkImageWidgetReference _image;
		private CHandle<gameuiPhotoModeStickersController> _stickersController;

		[Ordinal(1)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(2)] 
		[RED("stickersController")] 
		public CHandle<gameuiPhotoModeStickersController> StickersController
		{
			get => GetProperty(ref _stickersController);
			set => SetProperty(ref _stickersController, value);
		}

		public PhotoModeSticker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
