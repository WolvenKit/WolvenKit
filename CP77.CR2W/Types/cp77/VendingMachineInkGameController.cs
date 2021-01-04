using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendingMachineInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("ActionsPanel")] public inkHorizontalPanelWidgetReference ActionsPanel { get; set; }
		[Ordinal(1)]  [RED("noMoneyPanel")] public inkCompoundWidgetReference NoMoneyPanel { get; set; }
		[Ordinal(2)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(3)]  [RED("onSoldOutListener")] public CUInt32 OnSoldOutListener { get; set; }
		[Ordinal(4)]  [RED("onUpdateStatusListener")] public CUInt32 OnUpdateStatusListener { get; set; }
		[Ordinal(5)]  [RED("priceText")] public inkTextWidgetReference PriceText { get; set; }
		[Ordinal(6)]  [RED("soldOut")] public CBool SoldOut { get; set; }
		[Ordinal(7)]  [RED("soldOutPanel")] public inkCompoundWidgetReference SoldOutPanel { get; set; }
		[Ordinal(8)]  [RED("state")] public CEnum<PaymentStatus> State { get; set; }

		public VendingMachineInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
