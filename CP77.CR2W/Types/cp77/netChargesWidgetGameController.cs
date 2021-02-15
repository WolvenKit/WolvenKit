using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class netChargesWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("bbPlayerStats")] public CHandle<gameIBlackboard> BbPlayerStats { get; set; }
		[Ordinal(10)] [RED("bbPlayerEventId1")] public CUInt32 BbPlayerEventId1 { get; set; }
		[Ordinal(11)] [RED("bbPlayerEventId2")] public CUInt32 BbPlayerEventId2 { get; set; }
		[Ordinal(12)] [RED("bbPlayerEventId3")] public CUInt32 BbPlayerEventId3 { get; set; }
		[Ordinal(13)] [RED("networkName")] public wCHandle<inkTextWidget> NetworkName { get; set; }
		[Ordinal(14)] [RED("networkStatus")] public wCHandle<inkTextWidget> NetworkStatus { get; set; }
		[Ordinal(15)] [RED("chargesList")] public CArray<wCHandle<inkCompoundWidget>> ChargesList { get; set; }
		[Ordinal(16)] [RED("chargesCurrent")] public CInt32 ChargesCurrent { get; set; }
		[Ordinal(17)] [RED("chargesMax")] public CInt32 ChargesMax { get; set; }
		[Ordinal(18)] [RED("networkNameText")] public CString NetworkNameText { get; set; }
		[Ordinal(19)] [RED("networkStatusText")] public CString NetworkStatusText { get; set; }
		[Ordinal(20)] [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(21)] [RED("chargeList")] public wCHandle<inkHorizontalPanelWidget> ChargeList { get; set; }

		public netChargesWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
