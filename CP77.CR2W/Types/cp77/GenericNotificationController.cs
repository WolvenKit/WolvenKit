using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GenericNotificationController : gameuiGenericNotificationReceiverGameController
	{
		[Ordinal(0)]  [RED("actionLabelRef")] public inkTextWidgetReference ActionLabelRef { get; set; }
		[Ordinal(1)]  [RED("actionRef")] public inkWidgetReference ActionRef { get; set; }
		[Ordinal(2)]  [RED("blockAction")] public CBool BlockAction { get; set; }
		[Ordinal(3)]  [RED("data")] public CHandle<gameuiGenericNotificationViewData> Data { get; set; }
		[Ordinal(4)]  [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(5)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(6)]  [RED("textRef")] public inkTextWidgetReference TextRef { get; set; }
		[Ordinal(7)]  [RED("titleRef")] public inkTextWidgetReference TitleRef { get; set; }
		[Ordinal(8)]  [RED("translationAnimationCtrl")] public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl { get; set; }

		public GenericNotificationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
