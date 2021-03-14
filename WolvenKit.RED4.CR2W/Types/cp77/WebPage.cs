using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WebPage : inkWidgetLogicController
	{
		private CArray<inkTextWidgetReference> _textList;
		private CArray<inkRectangleWidgetReference> _rectangleList;
		private CArray<inkImageWidgetReference> _imageList;
		private CArray<inkVideoWidgetReference> _videoList;
		private CString _lastClickedLinkAddress;
		private CString _hOME_IMAGE_NAME;
		private CString _hOME_TEXT_NAME;

		[Ordinal(1)] 
		[RED("textList")] 
		public CArray<inkTextWidgetReference> TextList
		{
			get
			{
				if (_textList == null)
				{
					_textList = (CArray<inkTextWidgetReference>) CR2WTypeManager.Create("array:inkTextWidgetReference", "textList", cr2w, this);
				}
				return _textList;
			}
			set
			{
				if (_textList == value)
				{
					return;
				}
				_textList = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rectangleList")] 
		public CArray<inkRectangleWidgetReference> RectangleList
		{
			get
			{
				if (_rectangleList == null)
				{
					_rectangleList = (CArray<inkRectangleWidgetReference>) CR2WTypeManager.Create("array:inkRectangleWidgetReference", "rectangleList", cr2w, this);
				}
				return _rectangleList;
			}
			set
			{
				if (_rectangleList == value)
				{
					return;
				}
				_rectangleList = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("imageList")] 
		public CArray<inkImageWidgetReference> ImageList
		{
			get
			{
				if (_imageList == null)
				{
					_imageList = (CArray<inkImageWidgetReference>) CR2WTypeManager.Create("array:inkImageWidgetReference", "imageList", cr2w, this);
				}
				return _imageList;
			}
			set
			{
				if (_imageList == value)
				{
					return;
				}
				_imageList = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("videoList")] 
		public CArray<inkVideoWidgetReference> VideoList
		{
			get
			{
				if (_videoList == null)
				{
					_videoList = (CArray<inkVideoWidgetReference>) CR2WTypeManager.Create("array:inkVideoWidgetReference", "videoList", cr2w, this);
				}
				return _videoList;
			}
			set
			{
				if (_videoList == value)
				{
					return;
				}
				_videoList = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lastClickedLinkAddress")] 
		public CString LastClickedLinkAddress
		{
			get
			{
				if (_lastClickedLinkAddress == null)
				{
					_lastClickedLinkAddress = (CString) CR2WTypeManager.Create("String", "lastClickedLinkAddress", cr2w, this);
				}
				return _lastClickedLinkAddress;
			}
			set
			{
				if (_lastClickedLinkAddress == value)
				{
					return;
				}
				_lastClickedLinkAddress = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("HOME_IMAGE_NAME")] 
		public CString HOME_IMAGE_NAME
		{
			get
			{
				if (_hOME_IMAGE_NAME == null)
				{
					_hOME_IMAGE_NAME = (CString) CR2WTypeManager.Create("String", "HOME_IMAGE_NAME", cr2w, this);
				}
				return _hOME_IMAGE_NAME;
			}
			set
			{
				if (_hOME_IMAGE_NAME == value)
				{
					return;
				}
				_hOME_IMAGE_NAME = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("HOME_TEXT_NAME")] 
		public CString HOME_TEXT_NAME
		{
			get
			{
				if (_hOME_TEXT_NAME == null)
				{
					_hOME_TEXT_NAME = (CString) CR2WTypeManager.Create("String", "HOME_TEXT_NAME", cr2w, this);
				}
				return _hOME_TEXT_NAME;
			}
			set
			{
				if (_hOME_TEXT_NAME == value)
				{
					return;
				}
				_hOME_TEXT_NAME = value;
				PropertySet(this);
			}
		}

		public WebPage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
