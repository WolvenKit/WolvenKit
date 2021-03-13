using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scannerDetailsGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("scannerCountainer")] public inkCompoundWidgetReference ScannerCountainer { get; set; }
		[Ordinal(10)] [RED("quickhackContainer")] public inkCompoundWidgetReference QuickhackContainer { get; set; }
		[Ordinal(11)] [RED("cluesContainer")] public inkCompoundWidgetReference CluesContainer { get; set; }
		[Ordinal(12)] [RED("fllufContainer")] public inkCompoundWidgetReference FllufContainer { get; set; }
		[Ordinal(13)] [RED("bg")] public inkWidgetReference Bg { get; set; }
		[Ordinal(14)] [RED("toggleDescirptionHackPart")] public inkWidgetReference ToggleDescirptionHackPart { get; set; }
		[Ordinal(15)] [RED("toggleDescriptionScanIcon")] public inkWidgetReference ToggleDescriptionScanIcon { get; set; }
		[Ordinal(16)] [RED("fitToContentBackground")] public inkWidgetReference FitToContentBackground { get; set; }
		[Ordinal(17)] [RED("kiroshiLogo")] public inkWidgetReference KiroshiLogo { get; set; }
		[Ordinal(18)] [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(19)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(20)] [RED("objectTypeCallbackID")] public CUInt32 ObjectTypeCallbackID { get; set; }
		[Ordinal(21)] [RED("uiScannerChunkBlackboard")] public CHandle<gameIBlackboard> UiScannerChunkBlackboard { get; set; }
		[Ordinal(22)] [RED("scanningState")] public CEnum<gameScanningState> ScanningState { get; set; }
		[Ordinal(23)] [RED("scanStatusCallbackID")] public CUInt32 ScanStatusCallbackID { get; set; }
		[Ordinal(24)] [RED("scanObjectCallbackID")] public CUInt32 ScanObjectCallbackID { get; set; }
		[Ordinal(25)] [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }
		[Ordinal(26)] [RED("quickSlotsBoard")] public CHandle<gameIBlackboard> QuickSlotsBoard { get; set; }
		[Ordinal(27)] [RED("quickSlotsCallbackID")] public CUInt32 QuickSlotsCallbackID { get; set; }
		[Ordinal(28)] [RED("quickhackStartedCallbackID")] public CUInt32 QuickhackStartedCallbackID { get; set; }
		[Ordinal(29)] [RED("scannedObjectType")] public CEnum<ScannerObjectType> ScannedObjectType { get; set; }
		[Ordinal(30)] [RED("showScanAnimProxy")] public CHandle<inkanimProxy> ShowScanAnimProxy { get; set; }
		[Ordinal(31)] [RED("hideScanAnimProxy")] public CHandle<inkanimProxy> HideScanAnimProxy { get; set; }
		[Ordinal(32)] [RED("toggleScanDescriptionAnimProxy")] public CHandle<inkanimProxy> ToggleScanDescriptionAnimProxy { get; set; }
		[Ordinal(33)] [RED("previousToggleAnimName")] public CName PreviousToggleAnimName { get; set; }
		[Ordinal(34)] [RED("hasHacks")] public CBool HasHacks { get; set; }
		[Ordinal(35)] [RED("lastScannedObject")] public entEntityID LastScannedObject { get; set; }
		[Ordinal(36)] [RED("isDescriptionVisible")] public CBool IsDescriptionVisible { get; set; }

		public scannerDetailsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
