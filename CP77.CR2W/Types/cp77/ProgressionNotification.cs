using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProgressionNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("titleRef")] public inkTextWidgetReference TitleRef { get; set; }
		[Ordinal(1)]  [RED("textRef")] public inkTextWidgetReference TextRef { get; set; }
		[Ordinal(2)]  [RED("actionLabelRef")] public inkTextWidgetReference ActionLabelRef { get; set; }
		[Ordinal(3)]  [RED("actionRef")] public inkWidgetReference ActionRef { get; set; }
		[Ordinal(4)]  [RED("blockAction")] public CBool BlockAction { get; set; }
		[Ordinal(5)]  [RED("translationAnimationCtrl")] public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl { get; set; }
		[Ordinal(6)]  [RED("data")] public CHandle<gameuiGenericNotificationViewData> Data { get; set; }
		[Ordinal(7)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(8)]  [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(9)]  [RED("progression_data")] public CHandle<gameuiProgressionViewData> Progression_data { get; set; }
		[Ordinal(10)]  [RED("expBar")] public inkWidgetReference ExpBar { get; set; }
		[Ordinal(11)]  [RED("expText")] public inkTextWidgetReference ExpText { get; set; }
		[Ordinal(12)]  [RED("barFG")] public inkWidgetReference BarFG { get; set; }
		[Ordinal(13)]  [RED("barBG")] public inkWidgetReference BarBG { get; set; }
		[Ordinal(14)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(15)]  [RED("currentLevel")] public inkTextWidgetReference CurrentLevel { get; set; }
		[Ordinal(16)]  [RED("nextLevel")] public inkTextWidgetReference NextLevel { get; set; }
		[Ordinal(17)]  [RED("expBarWidthSize")] public CFloat ExpBarWidthSize { get; set; }
		[Ordinal(18)]  [RED("expBarHeightSize")] public CFloat ExpBarHeightSize { get; set; }
		[Ordinal(19)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(20)]  [RED("barAnimationProxy")] public CHandle<inkanimProxy> BarAnimationProxy { get; set; }

		public ProgressionNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
