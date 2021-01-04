using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProgressionNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("barAnimationProxy")] public CHandle<inkanimProxy> BarAnimationProxy { get; set; }
		[Ordinal(2)]  [RED("barBG")] public inkWidgetReference BarBG { get; set; }
		[Ordinal(3)]  [RED("barFG")] public inkWidgetReference BarFG { get; set; }
		[Ordinal(4)]  [RED("currentLevel")] public inkTextWidgetReference CurrentLevel { get; set; }
		[Ordinal(5)]  [RED("expBar")] public inkWidgetReference ExpBar { get; set; }
		[Ordinal(6)]  [RED("expBarHeightSize")] public CFloat ExpBarHeightSize { get; set; }
		[Ordinal(7)]  [RED("expBarWidthSize")] public CFloat ExpBarWidthSize { get; set; }
		[Ordinal(8)]  [RED("expText")] public inkTextWidgetReference ExpText { get; set; }
		[Ordinal(9)]  [RED("nextLevel")] public inkTextWidgetReference NextLevel { get; set; }
		[Ordinal(10)]  [RED("progression_data")] public CHandle<gameuiProgressionViewData> Progression_data { get; set; }
		[Ordinal(11)]  [RED("root")] public inkWidgetReference Root { get; set; }

		public ProgressionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
