using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractiveAdInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("ProcessingVideo")] public inkVideoWidgetReference ProcessingVideo { get; set; }
		[Ordinal(17)] [RED("PersonalAd")] public inkVideoWidgetReference PersonalAd { get; set; }
		[Ordinal(18)] [RED("CommonAd")] public inkVideoWidgetReference CommonAd { get; set; }
		[Ordinal(19)] [RED("fadeDuration")] public CFloat FadeDuration { get; set; }
		[Ordinal(20)] [RED("animFade")] public CHandle<inkanimDefinition> AnimFade { get; set; }
		[Ordinal(21)] [RED("animOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(22)] [RED("showAd")] public CBool ShowAd { get; set; }
		[Ordinal(23)] [RED("onShowAdListener")] public CUInt32 OnShowAdListener { get; set; }
		[Ordinal(24)] [RED("onShowVendorListener")] public CUInt32 OnShowVendorListener { get; set; }

		public InteractiveAdInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
