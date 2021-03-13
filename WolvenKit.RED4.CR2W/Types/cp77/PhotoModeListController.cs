using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeListController : inkListController
	{
		[Ordinal(6)] [RED("LogoWidget")] public inkWidgetReference LogoWidget { get; set; }
		[Ordinal(7)] [RED("Panel")] public inkVerticalPanelWidgetReference Panel { get; set; }
		[Ordinal(8)] [RED("fadeAnim")] public CHandle<inkanimProxy> FadeAnim { get; set; }
		[Ordinal(9)] [RED("isAnimating")] public CBool IsAnimating { get; set; }
		[Ordinal(10)] [RED("animationTime")] public CFloat AnimationTime { get; set; }
		[Ordinal(11)] [RED("animationTarget")] public CFloat AnimationTarget { get; set; }
		[Ordinal(12)] [RED("elementsAnimationTime")] public CFloat ElementsAnimationTime { get; set; }
		[Ordinal(13)] [RED("elementsAnimationDelay")] public CFloat ElementsAnimationDelay { get; set; }
		[Ordinal(14)] [RED("currentElementAnimation")] public CInt32 CurrentElementAnimation { get; set; }

		public PhotoModeListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
