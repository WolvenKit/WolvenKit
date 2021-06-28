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
			get => GetProperty(ref _textList);
			set => SetProperty(ref _textList, value);
		}

		[Ordinal(2)] 
		[RED("rectangleList")] 
		public CArray<inkRectangleWidgetReference> RectangleList
		{
			get => GetProperty(ref _rectangleList);
			set => SetProperty(ref _rectangleList, value);
		}

		[Ordinal(3)] 
		[RED("imageList")] 
		public CArray<inkImageWidgetReference> ImageList
		{
			get => GetProperty(ref _imageList);
			set => SetProperty(ref _imageList, value);
		}

		[Ordinal(4)] 
		[RED("videoList")] 
		public CArray<inkVideoWidgetReference> VideoList
		{
			get => GetProperty(ref _videoList);
			set => SetProperty(ref _videoList, value);
		}

		[Ordinal(5)] 
		[RED("lastClickedLinkAddress")] 
		public CString LastClickedLinkAddress
		{
			get => GetProperty(ref _lastClickedLinkAddress);
			set => SetProperty(ref _lastClickedLinkAddress, value);
		}

		[Ordinal(6)] 
		[RED("HOME_IMAGE_NAME")] 
		public CString HOME_IMAGE_NAME
		{
			get => GetProperty(ref _hOME_IMAGE_NAME);
			set => SetProperty(ref _hOME_IMAGE_NAME, value);
		}

		[Ordinal(7)] 
		[RED("HOME_TEXT_NAME")] 
		public CString HOME_TEXT_NAME
		{
			get => GetProperty(ref _hOME_TEXT_NAME);
			set => SetProperty(ref _hOME_TEXT_NAME, value);
		}

		public WebPage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
