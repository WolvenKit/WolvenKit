using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProgressionNotification : GenericNotificationController
	{
		[Ordinal(12)] [RED("progression_data")] public CHandle<gameuiProgressionViewData> Progression_data { get; set; }
		[Ordinal(13)] [RED("expBar")] public inkWidgetReference ExpBar { get; set; }
		[Ordinal(14)] [RED("expText")] public inkTextWidgetReference ExpText { get; set; }
		[Ordinal(15)] [RED("barFG")] public inkWidgetReference BarFG { get; set; }
		[Ordinal(16)] [RED("barBG")] public inkWidgetReference BarBG { get; set; }
		[Ordinal(17)] [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(18)] [RED("currentLevel")] public inkTextWidgetReference CurrentLevel { get; set; }
		[Ordinal(19)] [RED("nextLevel")] public inkTextWidgetReference NextLevel { get; set; }
		[Ordinal(20)] [RED("expBarWidthSize")] public CFloat ExpBarWidthSize { get; set; }
		[Ordinal(21)] [RED("expBarHeightSize")] public CFloat ExpBarHeightSize { get; set; }
		[Ordinal(22)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(23)] [RED("barAnimationProxy")] public CHandle<inkanimProxy> BarAnimationProxy { get; set; }

		public ProgressionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
