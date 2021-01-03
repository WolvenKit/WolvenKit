using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CurrencyNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("CurrencyDiff")] public inkTextWidgetReference CurrencyDiff { get; set; }
		[Ordinal(1)]  [RED("CurrencyTotal")] public inkTextWidgetReference CurrencyTotal { get; set; }
		[Ordinal(2)]  [RED("CurrencyUpdateAnimation")] public CName CurrencyUpdateAnimation { get; set; }
		[Ordinal(3)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(4)]  [RED("blackboard")] public CHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(5)]  [RED("currencyData")] public CHandle<CurrencyUpdateNotificationViewData> CurrencyData { get; set; }
		[Ordinal(6)]  [RED("diff_animator")] public CHandle<inkTextValueProgressAnimationController> Diff_animator { get; set; }
		[Ordinal(7)]  [RED("total_animator")] public CHandle<inkTextValueProgressAnimationController> Total_animator { get; set; }
		[Ordinal(8)]  [RED("uiSystemBB")] public CHandle<UI_SystemDef> UiSystemBB { get; set; }
		[Ordinal(9)]  [RED("uiSystemId")] public CUInt32 UiSystemId { get; set; }

		public CurrencyNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
