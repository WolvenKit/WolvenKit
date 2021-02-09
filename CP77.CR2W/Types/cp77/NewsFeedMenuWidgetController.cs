using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NewsFeedMenuWidgetController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("bannersListWidgetPath")] public CName BannersListWidgetPath { get; set; }
		[Ordinal(1)]  [RED("bannersListWidget")] public inkWidgetReference BannersListWidget { get; set; }
		[Ordinal(2)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }
		[Ordinal(3)]  [RED("bannerWidgetsData")] public CArray<SBannerWidgetPackage> BannerWidgetsData { get; set; }
		[Ordinal(4)]  [RED("fullBannerWidgetData")] public SBannerWidgetPackage FullBannerWidgetData { get; set; }

		public NewsFeedMenuWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
