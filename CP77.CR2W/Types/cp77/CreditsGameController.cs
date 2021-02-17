using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CreditsGameController : gameuiCreditsController
	{
		[Ordinal(25)] [RED("videoContainer")] public inkCompoundWidgetReference VideoContainer { get; set; }
		[Ordinal(26)] [RED("sceneTexture")] public inkImageWidgetReference SceneTexture { get; set; }
		[Ordinal(27)] [RED("backgroundVideo")] public inkVideoWidgetReference BackgroundVideo { get; set; }
		[Ordinal(28)] [RED("binkVideo")] public inkVideoWidgetReference BinkVideo { get; set; }
		[Ordinal(29)] [RED("binkVideos")] public CArray<gameuiBinkResource> BinkVideos { get; set; }
		[Ordinal(30)] [RED("currentBinkVideo")] public CInt32 CurrentBinkVideo { get; set; }
		[Ordinal(31)] [RED("videoSummary")] public inkVideoWidgetSummary VideoSummary { get; set; }
		[Ordinal(32)] [RED("isDataSet")] public CBool IsDataSet { get; set; }

		public CreditsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
