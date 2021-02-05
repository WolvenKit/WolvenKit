using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiScannerGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("currentTarget")] public entEntityID CurrentTarget { get; set; }
		[Ordinal(8)]  [RED("scanLock")] public CBool ScanLock { get; set; }
		[Ordinal(9)]  [RED("percentValue")] public CFloat PercentValue { get; set; }
		[Ordinal(10)]  [RED("oldPercentValue")] public CFloat OldPercentValue { get; set; }
		[Ordinal(11)]  [RED("bbWeaponInfo")] public wCHandle<gameIBlackboard> BbWeaponInfo { get; set; }
		[Ordinal(12)]  [RED("BraindanceBB")] public wCHandle<gameIBlackboard> BraindanceBB { get; set; }
		[Ordinal(13)]  [RED("bbWeaponEventId")] public CUInt32 BbWeaponEventId { get; set; }
		[Ordinal(14)]  [RED("BBID_BraindanceActive")] public CUInt32 BBID_BraindanceActive { get; set; }
		[Ordinal(15)]  [RED("scannerData")] public scannerDataStructure ScannerData { get; set; }
		[Ordinal(16)]  [RED("curObj")] public GameObjectScanStats CurObj { get; set; }
		[Ordinal(17)]  [RED("scannerBorderMain")] public wCHandle<inkCompoundWidget> ScannerBorderMain { get; set; }
		[Ordinal(18)]  [RED("scannerBorderController")] public wCHandle<scannerBorderLogicController> ScannerBorderController { get; set; }
		[Ordinal(19)]  [RED("scannerProgressMain")] public wCHandle<inkCompoundWidget> ScannerProgressMain { get; set; }
		[Ordinal(20)]  [RED("scannerFullScreenOverlay")] public wCHandle<inkWidget> ScannerFullScreenOverlay { get; set; }
		[Ordinal(21)]  [RED("center_frame")] public wCHandle<inkImageWidget> Center_frame { get; set; }
		[Ordinal(22)]  [RED("squares")] public CArray<wCHandle<inkImageWidget>> Squares { get; set; }
		[Ordinal(23)]  [RED("squaresFilled")] public CArray<wCHandle<inkImageWidget>> SquaresFilled { get; set; }
		[Ordinal(24)]  [RED("isUnarmed")] public CBool IsUnarmed { get; set; }
		[Ordinal(25)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(26)]  [RED("isFinish")] public CBool IsFinish { get; set; }
		[Ordinal(27)]  [RED("isScanned")] public CBool IsScanned { get; set; }
		[Ordinal(28)]  [RED("isBraindanceActive")] public CBool IsBraindanceActive { get; set; }
		[Ordinal(29)]  [RED("border_show")] public CHandle<inkanimDefinition> Border_show { get; set; }
		[Ordinal(30)]  [RED("center_show")] public CHandle<inkanimDefinition> Center_show { get; set; }
		[Ordinal(31)]  [RED("center_hide")] public CHandle<inkanimDefinition> Center_hide { get; set; }
		[Ordinal(32)]  [RED("dots_show")] public CHandle<inkanimDefinition> Dots_show { get; set; }
		[Ordinal(33)]  [RED("dots_hide")] public CHandle<inkanimDefinition> Dots_hide { get; set; }
		[Ordinal(34)]  [RED("BorderAnimProxy")] public CHandle<inkanimProxy> BorderAnimProxy { get; set; }
		[Ordinal(35)]  [RED("soundFinishedOn")] public CName SoundFinishedOn { get; set; }
		[Ordinal(36)]  [RED("soundFinishedOff")] public CName SoundFinishedOff { get; set; }
		[Ordinal(37)]  [RED("playerSpawnedCallbackID")] public CUInt32 PlayerSpawnedCallbackID { get; set; }
		[Ordinal(38)]  [RED("BBID_IsEnabledChange")] public CUInt32 BBID_IsEnabledChange { get; set; }
		[Ordinal(39)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(40)]  [RED("isShown")] public CBool IsShown { get; set; }
		[Ordinal(41)]  [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }

		public gameuiScannerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
