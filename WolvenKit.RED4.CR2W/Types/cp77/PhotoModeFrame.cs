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
		private CHandle<gameuiPhotoModeStickersController> _stickersController;
		private CName _currentImagePart;
		private CFloat _opacity;

		[Ordinal(1)] 
		[RED("images")] 
		public CArray<inkImageWidgetReference> Images
		{
			get
			{
				if (_images == null)
				{
					_images = (CArray<inkImageWidgetReference>) CR2WTypeManager.Create("array:inkImageWidgetReference", "images", cr2w, this);
				}
				return _images;
			}
			set
			{
				if (_images == value)
				{
					return;
				}
				_images = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("keepImageAspectRatio")] 
		public CBool KeepImageAspectRatio
		{
			get
			{
				if (_keepImageAspectRatio == null)
				{
					_keepImageAspectRatio = (CBool) CR2WTypeManager.Create("Bool", "keepImageAspectRatio", cr2w, this);
				}
				return _keepImageAspectRatio;
			}
			set
			{
				if (_keepImageAspectRatio == value)
				{
					return;
				}
				_keepImageAspectRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("currentImagePart")] 
		public CName CurrentImagePart
		{
			get
			{
				if (_currentImagePart == null)
				{
					_currentImagePart = (CName) CR2WTypeManager.Create("CName", "currentImagePart", cr2w, this);
				}
				return _currentImagePart;
			}
			set
			{
				if (_currentImagePart == value)
				{
					return;
				}
				_currentImagePart = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get
			{
				if (_opacity == null)
				{
					_opacity = (CFloat) CR2WTypeManager.Create("Float", "opacity", cr2w, this);
				}
				return _opacity;
			}
			set
			{
				if (_opacity == value)
				{
					return;
				}
				_opacity = value;
				PropertySet(this);
			}
		}

		public PhotoModeFrame(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
