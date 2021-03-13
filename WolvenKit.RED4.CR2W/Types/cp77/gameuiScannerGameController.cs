using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiScannerGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("currentTarget")] public entEntityID CurrentTarget { get; set; }
		[Ordinal(10)] [RED("scanLock")] public CBool ScanLock { get; set; }
		[Ordinal(11)] [RED("percentValue")] public CFloat PercentValue { get; set; }
		[Ordinal(12)] [RED("oldPercentValue")] public CFloat OldPercentValue { get; set; }
		[Ordinal(13)] [RED("bbWeaponInfo")] public wCHandle<gameIBlackboard> BbWeaponInfo { get; set; }
		[Ordinal(14)] [RED("BraindanceBB")] public wCHandle<gameIBlackboard> BraindanceBB { get; set; }
		[Ordinal(15)] [RED("bbWeaponEventId")] public CUInt32 BbWeaponEventId { get; set; }
		[Ordinal(16)] [RED("BBID_BraindanceActive")] public CUInt32 BBID_BraindanceActive { get; set; }
		[Ordinal(17)] [RED("scannerData")] public scannerDataStructure ScannerData { get; set; }
		[Ordinal(18)] [RED("curObj")] public GameObjectScanStats CurObj { get; set; }
		[Ordinal(19)] [RED("scannerBorderMain")] public wCHandle<inkCompoundWidget> ScannerBorderMain { get; set; }
		[Ordinal(20)] [RED("scannerBorderController")] public wCHandle<scannerBorderLogicController> ScannerBorderController { get; set; }
		[Ordinal(21)] [RED("scannerProgressMain")] public wCHandle<inkCompoundWidget> ScannerProgressMain { get; set; }
		[Ordinal(22)] [RED("scannerFullScreenOverlay")] public wCHandle<inkWidget> ScannerFullScreenOverlay { get; set; }
		[Ordinal(23)] [RED("center_frame")] public wCHandle<inkImageWidget> Center_frame { get; set; }
		[Ordinal(24)] [RED("squares")] public CArray<wCHandle<inkImageWidget>> Squares { get; set; }
		[Ordinal(25)] [RED("squaresFilled")] public CArray<wCHandle<inkImageWidget>> SquaresFilled { get; set; }
		[Ordinal(26)] [RED("isUnarmed")] public CBool IsUnarmed { get; set; }
		[Ordinal(27)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(28)] [RED("isFinish")] public CBool IsFinish { get; set; }
		[Ordinal(29)] [RED("isScanned")] public CBool IsScanned { get; set; }
		[Ordinal(30)] [RED("isBraindanceActive")] public CBool IsBraindanceActive { get; set; }
		[Ordinal(31)] [RED("border_show")] public CHandle<inkanimDefinition> Border_show { get; set; }
		[Ordinal(32)] [RED("center_show")] public CHandle<inkanimDefinition> Center_show { get; set; }
		[Ordinal(33)] [RED("center_hide")] public CHandle<inkanimDefinition> Center_hide { get; set; }
		[Ordinal(34)] [RED("dots_show")] public CHandle<inkanimDefinition> Dots_show { get; set; }
		[Ordinal(35)] [RED("dots_hide")] public CHandle<inkanimDefinition> Dots_hide { get; set; }
		[Ordinal(36)] [RED("BorderAnimProxy")] public CHandle<inkanimProxy> BorderAnimProxy { get; set; }
		[Ordinal(37)] [RED("soundFinishedOn")] public CName SoundFinishedOn { get; set; }
		[Ordinal(38)] [RED("soundFinishedOff")] public CName SoundFinishedOff { get; set; }
		[Ordinal(39)] [RED("playerSpawnedCallbackID")] public CUInt32 PlayerSpawnedCallbackID { get; set; }
		[Ordinal(40)] [RED("BBID_IsEnabledChange")] public CUInt32 BBID_IsEnabledChange { get; set; }
		[Ordinal(41)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(42)] [RED("isShown")] public CBool IsShown { get; set; }
		[Ordinal(43)] [RED("playerPuppet")] public wCHandle<gameObject> PlayerPuppet { get; set; }

		public gameuiScannerGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
