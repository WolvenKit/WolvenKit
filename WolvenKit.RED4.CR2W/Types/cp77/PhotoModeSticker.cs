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
			get
			{
				if (_image == null)
				{
					_image = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "image", cr2w, this);
				}
				return _image;
			}
			set
			{
				if (_image == value)
				{
					return;
				}
				_image = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stickersController")] 
		public CHandle<gameuiPhotoModeStickersController> StickersController
		{
			get
			{
				if (_stickersController == null)
				{
					_stickersController = (CHandle<gameuiPhotoModeStickersController>) CR2WTypeManager.Create("handle:gameuiPhotoModeStickersController", "stickersController", cr2w, this);
				}
				return _stickersController;
			}
			set
			{
				if (_stickersController == value)
				{
					return;
				}
				_stickersController = value;
				PropertySet(this);
			}
		}

		public PhotoModeSticker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
