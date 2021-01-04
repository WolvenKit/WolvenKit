using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WebPage : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("HOME_IMAGE_NAME")] public CString HOME_IMAGE_NAME { get; set; }
		[Ordinal(1)]  [RED("HOME_TEXT_NAME")] public CString HOME_TEXT_NAME { get; set; }
		[Ordinal(2)]  [RED("imageList")] public CArray<inkImageWidgetReference> ImageList { get; set; }
		[Ordinal(3)]  [RED("lastClickedLinkAddress")] public CString LastClickedLinkAddress { get; set; }
		[Ordinal(4)]  [RED("rectangleList")] public CArray<inkRectangleWidgetReference> RectangleList { get; set; }
		[Ordinal(5)]  [RED("textList")] public CArray<inkTextWidgetReference> TextList { get; set; }
		[Ordinal(6)]  [RED("videoList")] public CArray<inkVideoWidgetReference> VideoList { get; set; }

		public WebPage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
