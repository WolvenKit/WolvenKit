using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class sampleUILoadingBarController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("currentSize")] public Vector2 CurrentSize { get; set; }
		[Ordinal(1)]  [RED("imageWidget")] public wCHandle<inkImageWidget> ImageWidget { get; set; }
		[Ordinal(2)]  [RED("imageWidgetPath")] public CName ImageWidgetPath { get; set; }
		[Ordinal(3)]  [RED("maxSize")] public Vector2 MaxSize { get; set; }
		[Ordinal(4)]  [RED("minSize")] public Vector2 MinSize { get; set; }
		[Ordinal(5)]  [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }
		[Ordinal(6)]  [RED("textWidgetPath")] public CName TextWidgetPath { get; set; }

		public sampleUILoadingBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
