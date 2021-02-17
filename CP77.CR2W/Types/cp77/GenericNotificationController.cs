using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GenericNotificationController : gameuiGenericNotificationReceiverGameController
	{
		[Ordinal(3)] [RED("titleRef")] public inkTextWidgetReference TitleRef { get; set; }
		[Ordinal(4)] [RED("textRef")] public inkTextWidgetReference TextRef { get; set; }
		[Ordinal(5)] [RED("actionLabelRef")] public inkTextWidgetReference ActionLabelRef { get; set; }
		[Ordinal(6)] [RED("actionRef")] public inkWidgetReference ActionRef { get; set; }
		[Ordinal(7)] [RED("blockAction")] public CBool BlockAction { get; set; }
		[Ordinal(8)] [RED("translationAnimationCtrl")] public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl { get; set; }
		[Ordinal(9)] [RED("data")] public CHandle<gameuiGenericNotificationViewData> Data { get; set; }
		[Ordinal(10)] [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(11)] [RED("isInteractive")] public CBool IsInteractive { get; set; }

		public GenericNotificationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
