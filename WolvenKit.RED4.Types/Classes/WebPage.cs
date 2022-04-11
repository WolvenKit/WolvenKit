using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WebPage : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textList")] 
		public CArray<inkTextWidgetReference> TextList
		{
			get => GetPropertyValue<CArray<inkTextWidgetReference>>();
			set => SetPropertyValue<CArray<inkTextWidgetReference>>(value);
		}

		[Ordinal(2)] 
		[RED("rectangleList")] 
		public CArray<inkRectangleWidgetReference> RectangleList
		{
			get => GetPropertyValue<CArray<inkRectangleWidgetReference>>();
			set => SetPropertyValue<CArray<inkRectangleWidgetReference>>(value);
		}

		[Ordinal(3)] 
		[RED("imageList")] 
		public CArray<inkImageWidgetReference> ImageList
		{
			get => GetPropertyValue<CArray<inkImageWidgetReference>>();
			set => SetPropertyValue<CArray<inkImageWidgetReference>>(value);
		}

		[Ordinal(4)] 
		[RED("videoList")] 
		public CArray<inkVideoWidgetReference> VideoList
		{
			get => GetPropertyValue<CArray<inkVideoWidgetReference>>();
			set => SetPropertyValue<CArray<inkVideoWidgetReference>>(value);
		}

		[Ordinal(5)] 
		[RED("lastClickedLinkAddress")] 
		public CString LastClickedLinkAddress
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("HOME_IMAGE_NAME")] 
		public CString HOME_IMAGE_NAME
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("HOME_TEXT_NAME")] 
		public CString HOME_TEXT_NAME
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public WebPage()
		{
			TextList = new();
			RectangleList = new();
			ImageList = new();
			VideoList = new();
			HOME_IMAGE_NAME = "ImageLink";
			HOME_TEXT_NAME = "TextLink";
		}
	}
}
