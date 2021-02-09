using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerBannerWidgetController : DeviceInkLogicControllerBase
	{
		[Ordinal(4)]  [RED("titleWidget")] public inkTextWidgetReference TitleWidget { get; set; }
		[Ordinal(5)]  [RED("textContentWidget")] public inkTextWidgetReference TextContentWidget { get; set; }
		[Ordinal(6)]  [RED("videoContentWidget")] public inkVideoWidgetReference VideoContentWidget { get; set; }
		[Ordinal(7)]  [RED("imageContentWidget")] public inkImageWidgetReference ImageContentWidget { get; set; }
		[Ordinal(8)]  [RED("bannerButtonWidget")] public inkWidgetReference BannerButtonWidget { get; set; }
		[Ordinal(9)]  [RED("bannerData")] public SBannerWidgetPackage BannerData { get; set; }
		[Ordinal(10)]  [RED("lastPlayedVideo")] public redResourceReferenceScriptToken LastPlayedVideo { get; set; }

		public ComputerBannerWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
