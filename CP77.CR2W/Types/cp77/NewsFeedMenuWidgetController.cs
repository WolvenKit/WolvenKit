using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NewsFeedMenuWidgetController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("bannerWidgetsData")] public CArray<SBannerWidgetPackage> BannerWidgetsData { get; set; }
		[Ordinal(1)]  [RED("bannersListWidget")] public inkWidgetReference BannersListWidget { get; set; }
		[Ordinal(2)]  [RED("bannersListWidgetPath")] public CName BannersListWidgetPath { get; set; }
		[Ordinal(3)]  [RED("fullBannerWidgetData")] public SBannerWidgetPackage FullBannerWidgetData { get; set; }
		[Ordinal(4)]  [RED("isInitialized")] public CBool IsInitialized { get; set; }

		public NewsFeedMenuWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
