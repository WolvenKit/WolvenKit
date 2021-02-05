using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scannerDetailsGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("scannerCountainer")] public inkCompoundWidgetReference ScannerCountainer { get; set; }
		[Ordinal(8)]  [RED("quickhackContainer")] public inkCompoundWidgetReference QuickhackContainer { get; set; }
		[Ordinal(9)]  [RED("cluesContainer")] public inkCompoundWidgetReference CluesContainer { get; set; }
		[Ordinal(10)]  [RED("fllufContainer")] public inkCompoundWidgetReference FllufContainer { get; set; }
		[Ordinal(11)]  [RED("bg")] public inkWidgetReference Bg { get; set; }
		[Ordinal(12)]  [RED("toggleDescirptionHackPart")] public inkWidgetReference ToggleDescirptionHackPart { get; set; }
		[Ordinal(13)]  [RED("toggleDescriptionScanIcon")] public inkWidgetReference ToggleDescriptionScanIcon { get; set; }
		[Ordinal(14)]  [RED("fitToContentBackground")] public inkWidgetReference FitToContentBackground { get; set; }
		[Ordinal(15)]  [RED("kiroshiLogo")] public inkWidgetReference KiroshiLogo { get; set; }
		[Ordinal(16)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(17)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(18)]  [RED("objectTypeCallbackID")] public CUInt32 ObjectTypeCallbackID { get; set; }
		[Ordinal(19)]  [RED("uiScannerChunkBlackboard")] public CHandle<gameIBlackboard> UiScannerChunkBlackboard { get; set; }
		[Ordinal(20)]  [RED("scanningState")] public CEnum<gameScanningState> ScanningState { get; set; }
		[Ordinal(21)]  [RED("scanStatusCallbackID")] public CUInt32 ScanStatusCallbackID { get; set; }
		[Ordinal(22)]  [RED("scanObjectCallbackID")] public CUInt32 ScanObjectCallbackID { get; set; }
		[Ordinal(23)]  [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }
		[Ordinal(24)]  [RED("quickSlotsBoard")] public CHandle<gameIBlackboard> QuickSlotsBoard { get; set; }
		[Ordinal(25)]  [RED("quickSlotsCallbackID")] public CUInt32 QuickSlotsCallbackID { get; set; }
		[Ordinal(26)]  [RED("quickhackStartedCallbackID")] public CUInt32 QuickhackStartedCallbackID { get; set; }
		[Ordinal(27)]  [RED("scannedObjectType")] public CEnum<ScannerObjectType> ScannedObjectType { get; set; }
		[Ordinal(28)]  [RED("showScanAnimProxy")] public CHandle<inkanimProxy> ShowScanAnimProxy { get; set; }
		[Ordinal(29)]  [RED("hideScanAnimProxy")] public CHandle<inkanimProxy> HideScanAnimProxy { get; set; }
		[Ordinal(30)]  [RED("toggleScanDescriptionAnimProxy")] public CHandle<inkanimProxy> ToggleScanDescriptionAnimProxy { get; set; }
		[Ordinal(31)]  [RED("previousToggleAnimName")] public CName PreviousToggleAnimName { get; set; }
		[Ordinal(32)]  [RED("hasHacks")] public CBool HasHacks { get; set; }
		[Ordinal(33)]  [RED("lastScannedObject")] public entEntityID LastScannedObject { get; set; }
		[Ordinal(34)]  [RED("isDescriptionVisible")] public CBool IsDescriptionVisible { get; set; }

		public scannerDetailsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
