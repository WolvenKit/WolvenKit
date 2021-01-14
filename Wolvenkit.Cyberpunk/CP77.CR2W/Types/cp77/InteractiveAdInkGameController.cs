using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractiveAdInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("CommonAd")] public inkVideoWidgetReference CommonAd { get; set; }
		[Ordinal(1)]  [RED("PersonalAd")] public inkVideoWidgetReference PersonalAd { get; set; }
		[Ordinal(2)]  [RED("ProcessingVideo")] public inkVideoWidgetReference ProcessingVideo { get; set; }
		[Ordinal(3)]  [RED("animFade")] public CHandle<inkanimDefinition> AnimFade { get; set; }
		[Ordinal(4)]  [RED("animOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(5)]  [RED("fadeDuration")] public CFloat FadeDuration { get; set; }
		[Ordinal(6)]  [RED("onShowAdListener")] public CUInt32 OnShowAdListener { get; set; }
		[Ordinal(7)]  [RED("onShowVendorListener")] public CUInt32 OnShowVendorListener { get; set; }
		[Ordinal(8)]  [RED("showAd")] public CBool ShowAd { get; set; }

		public InteractiveAdInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
