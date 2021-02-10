using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendingMachineInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(14)]  [RED("ActionsPanel")] public inkHorizontalPanelWidgetReference ActionsPanel { get; set; }
		[Ordinal(15)]  [RED("priceText")] public inkTextWidgetReference PriceText { get; set; }
		[Ordinal(16)]  [RED("noMoneyPanel")] public inkCompoundWidgetReference NoMoneyPanel { get; set; }
		[Ordinal(17)]  [RED("soldOutPanel")] public inkCompoundWidgetReference SoldOutPanel { get; set; }
		[Ordinal(18)]  [RED("state")] public CEnum<PaymentStatus> State { get; set; }
		[Ordinal(19)]  [RED("soldOut")] public CBool SoldOut { get; set; }
		[Ordinal(20)]  [RED("onUpdateStatusListener")] public CUInt32 OnUpdateStatusListener { get; set; }
		[Ordinal(21)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(22)]  [RED("onSoldOutListener")] public CUInt32 OnSoldOutListener { get; set; }

		public VendingMachineInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
