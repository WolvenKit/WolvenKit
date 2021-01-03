using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiScannerGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("BBID_BraindanceActive")] public CUInt32 BBID_BraindanceActive { get; set; }
		[Ordinal(1)]  [RED("BBID_IsEnabledChange")] public CUInt32 BBID_IsEnabledChange { get; set; }
		[Ordinal(2)]  [RED("BorderAnimProxy")] public CHandle<inkanimProxy> BorderAnimProxy { get; set; }
		[Ordinal(3)]  [RED("BraindanceBB")] public CHandle<gameIBlackboard> BraindanceBB { get; set; }
		[Ordinal(4)]  [RED("bbWeaponEventId")] public CUInt32 BbWeaponEventId { get; set; }
		[Ordinal(5)]  [RED("bbWeaponInfo")] public CHandle<gameIBlackboard> BbWeaponInfo { get; set; }
		[Ordinal(6)]  [RED("border_show")] public CHandle<inkanimDefinition> Border_show { get; set; }
		[Ordinal(7)]  [RED("center_frame")] public wCHandle<inkImageWidget> Center_frame { get; set; }
		[Ordinal(8)]  [RED("center_hide")] public CHandle<inkanimDefinition> Center_hide { get; set; }
		[Ordinal(9)]  [RED("center_show")] public CHandle<inkanimDefinition> Center_show { get; set; }
		[Ordinal(10)]  [RED("curObj")] public GameObjectScanStats CurObj { get; set; }
		[Ordinal(11)]  [RED("currentTarget")] public entEntityID CurrentTarget { get; set; }
		[Ordinal(12)]  [RED("dots_hide")] public CHandle<inkanimDefinition> Dots_hide { get; set; }
		[Ordinal(13)]  [RED("dots_show")] public CHandle<inkanimDefinition> Dots_show { get; set; }
		[Ordinal(14)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(15)]  [RED("isBraindanceActive")] public CBool IsBraindanceActive { get; set; }
		[Ordinal(16)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(17)]  [RED("isFinish")] public CBool IsFinish { get; set; }
		[Ordinal(18)]  [RED("isScanned")] public CBool IsScanned { get; set; }
		[Ordinal(19)]  [RED("isShown")] public CBool IsShown { get; set; }
		[Ordinal(20)]  [RED("isUnarmed")] public CBool IsUnarmed { get; set; }
		[Ordinal(21)]  [RED("oldPercentValue")] public CFloat OldPercentValue { get; set; }
		[Ordinal(22)]  [RED("percentValue")] public CFloat PercentValue { get; set; }
		[Ordinal(23)]  [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }
		[Ordinal(24)]  [RED("playerSpawnedCallbackID")] public CUInt32 PlayerSpawnedCallbackID { get; set; }
		[Ordinal(25)]  [RED("scanLock")] public CBool ScanLock { get; set; }
		[Ordinal(26)]  [RED("scannerBorderController")] public wCHandle<scannerBorderLogicController> ScannerBorderController { get; set; }
		[Ordinal(27)]  [RED("scannerBorderMain")] public wCHandle<inkCompoundWidget> ScannerBorderMain { get; set; }
		[Ordinal(28)]  [RED("scannerData")] public scannerDataStructure ScannerData { get; set; }
		[Ordinal(29)]  [RED("scannerFullScreenOverlay")] public wCHandle<inkWidget> ScannerFullScreenOverlay { get; set; }
		[Ordinal(30)]  [RED("scannerProgressMain")] public wCHandle<inkCompoundWidget> ScannerProgressMain { get; set; }
		[Ordinal(31)]  [RED("soundFinishedOff")] public CName SoundFinishedOff { get; set; }
		[Ordinal(32)]  [RED("soundFinishedOn")] public CName SoundFinishedOn { get; set; }
		[Ordinal(33)]  [RED("squares")] public CArray<wCHandle<inkImageWidget>> Squares { get; set; }
		[Ordinal(34)]  [RED("squaresFilled")] public CArray<wCHandle<inkImageWidget>> SquaresFilled { get; set; }

		public gameuiScannerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
