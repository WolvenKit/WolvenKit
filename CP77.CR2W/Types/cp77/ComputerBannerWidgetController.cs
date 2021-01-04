using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerBannerWidgetController : DeviceInkLogicControllerBase
	{
		[Ordinal(0)]  [RED("bannerButtonWidget")] public inkWidgetReference BannerButtonWidget { get; set; }
		[Ordinal(1)]  [RED("bannerData")] public SBannerWidgetPackage BannerData { get; set; }
		[Ordinal(2)]  [RED("imageContentWidget")] public inkImageWidgetReference ImageContentWidget { get; set; }
		[Ordinal(3)]  [RED("lastPlayedVideo")] public redResourceReferenceScriptToken LastPlayedVideo { get; set; }
		[Ordinal(4)]  [RED("textContentWidget")] public inkTextWidgetReference TextContentWidget { get; set; }
		[Ordinal(5)]  [RED("titleWidget")] public inkTextWidgetReference TitleWidget { get; set; }
		[Ordinal(6)]  [RED("videoContentWidget")] public inkVideoWidgetReference VideoContentWidget { get; set; }

		public ComputerBannerWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
