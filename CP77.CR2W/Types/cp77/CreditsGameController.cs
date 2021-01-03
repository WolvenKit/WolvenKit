using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CreditsGameController : gameuiCreditsController
	{
		[Ordinal(0)]  [RED("backgroundVideo")] public inkVideoWidgetReference BackgroundVideo { get; set; }
		[Ordinal(1)]  [RED("binkVideo")] public inkVideoWidgetReference BinkVideo { get; set; }
		[Ordinal(2)]  [RED("binkVideos")] public CArray<gameuiBinkResource> BinkVideos { get; set; }
		[Ordinal(3)]  [RED("currentBinkVideo")] public CInt32 CurrentBinkVideo { get; set; }
		[Ordinal(4)]  [RED("isDataSet")] public CBool IsDataSet { get; set; }
		[Ordinal(5)]  [RED("sceneTexture")] public inkImageWidgetReference SceneTexture { get; set; }
		[Ordinal(6)]  [RED("videoContainer")] public inkCompoundWidgetReference VideoContainer { get; set; }
		[Ordinal(7)]  [RED("videoSummary")] public inkVideoWidgetSummary VideoSummary { get; set; }

		public CreditsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
