using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleUILoadingBarController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("minSize")] public Vector2 MinSize { get; set; }
		[Ordinal(1)]  [RED("maxSize")] public Vector2 MaxSize { get; set; }
		[Ordinal(2)]  [RED("imageWidgetPath")] public CName ImageWidgetPath { get; set; }
		[Ordinal(3)]  [RED("textWidgetPath")] public CName TextWidgetPath { get; set; }
		[Ordinal(4)]  [RED("currentSize")] public Vector2 CurrentSize { get; set; }
		[Ordinal(5)]  [RED("imageWidget")] public wCHandle<inkImageWidget> ImageWidget { get; set; }
		[Ordinal(6)]  [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }

		public sampleUILoadingBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
