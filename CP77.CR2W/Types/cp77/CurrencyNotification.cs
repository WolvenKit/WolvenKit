using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CurrencyNotification : GenericNotificationController
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
		[Ordinal(9)]  [RED("CurrencyUpdateAnimation")] public CName CurrencyUpdateAnimation { get; set; }
		[Ordinal(10)]  [RED("CurrencyDiff")] public inkTextWidgetReference CurrencyDiff { get; set; }
		[Ordinal(11)]  [RED("CurrencyTotal")] public inkTextWidgetReference CurrencyTotal { get; set; }
		[Ordinal(12)]  [RED("diff_animator")] public CHandle<inkTextValueProgressAnimationController> Diff_animator { get; set; }
		[Ordinal(13)]  [RED("total_animator")] public CHandle<inkTextValueProgressAnimationController> Total_animator { get; set; }
		[Ordinal(14)]  [RED("currencyData")] public CHandle<CurrencyUpdateNotificationViewData> CurrencyData { get; set; }
		[Ordinal(15)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(16)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(17)]  [RED("uiSystemBB")] public CHandle<UI_SystemDef> UiSystemBB { get; set; }
		[Ordinal(18)]  [RED("uiSystemId")] public CUInt32 UiSystemId { get; set; }

		public CurrencyNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
