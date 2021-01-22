using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhotoModeListController : inkListController
	{
		[Ordinal(0)]  [RED("LogoWidget")] public inkWidgetReference LogoWidget { get; set; }
		[Ordinal(1)]  [RED("Panel")] public inkVerticalPanelWidgetReference Panel { get; set; }
		[Ordinal(2)]  [RED("animationTarget")] public CFloat AnimationTarget { get; set; }
		[Ordinal(3)]  [RED("animationTime")] public CFloat AnimationTime { get; set; }
		[Ordinal(4)]  [RED("currentElementAnimation")] public CInt32 CurrentElementAnimation { get; set; }
		[Ordinal(5)]  [RED("elementsAnimationDelay")] public CFloat ElementsAnimationDelay { get; set; }
		[Ordinal(6)]  [RED("elementsAnimationTime")] public CFloat ElementsAnimationTime { get; set; }
		[Ordinal(7)]  [RED("fadeAnim")] public CHandle<inkanimProxy> FadeAnim { get; set; }
		[Ordinal(8)]  [RED("isAnimating")] public CBool IsAnimating { get; set; }

		public PhotoModeListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
