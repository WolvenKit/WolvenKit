using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponent : gameComponent
	{
		[Ordinal(0)]  [RED("BraindanceLayer")] public CEnum<braindanceVisionMode> BraindanceLayer { get; set; }
		[Ordinal(1)]  [RED("autoGenerateBoundingSphere")] public CBool AutoGenerateBoundingSphere { get; set; }
		[Ordinal(2)]  [RED("boundingSphere")] public Sphere BoundingSphere { get; set; }
		[Ordinal(3)]  [RED("clues")] public CArray<FocusClueDefinition> Clues { get; set; }
		[Ordinal(4)]  [RED("cpoEnableMultiplePlayersScanningModifier")] public CBool CpoEnableMultiplePlayersScanningModifier { get; set; }
		[Ordinal(5)]  [RED("currentBraindanceLayer")] public CInt32 CurrentBraindanceLayer { get; set; }
		[Ordinal(6)]  [RED("currentHighlight")] public CHandle<FocusForcedHighlightData> CurrentHighlight { get; set; }
		[Ordinal(7)]  [RED("ignoresScanningDistanceLimit")] public CBool IgnoresScanningDistanceLimit { get; set; }
		[Ordinal(8)]  [RED("isBeingScanned")] public CBool IsBeingScanned { get; set; }
		[Ordinal(9)]  [RED("isBraindanceActive")] public CBool IsBraindanceActive { get; set; }
		[Ordinal(10)]  [RED("isBraindanceBlocked")] public CBool IsBraindanceBlocked { get; set; }
		[Ordinal(11)]  [RED("isBraindanceClue")] public CBool IsBraindanceClue { get; set; }
		[Ordinal(12)]  [RED("isBraindanceLayerUnlocked")] public CBool IsBraindanceLayerUnlocked { get; set; }
		[Ordinal(13)]  [RED("isBraindanceTimelineUnlocked")] public CBool IsBraindanceTimelineUnlocked { get; set; }
		[Ordinal(14)]  [RED("isEntityVisible")] public CBool IsEntityVisible { get; set; }
		[Ordinal(15)]  [RED("isFocusModeActive")] public CBool IsFocusModeActive { get; set; }
		[Ordinal(16)]  [RED("isHudManagerInitialized")] public CBool IsHudManagerInitialized { get; set; }
		[Ordinal(17)]  [RED("isScanningCluesBlocked")] public CBool IsScanningCluesBlocked { get; set; }
		[Ordinal(18)]  [RED("objectDescription")] public CHandle<ObjectScanningDescription> ObjectDescription { get; set; }
		[Ordinal(19)]  [RED("scannableData")] public CArray<gameScanningTooltipElementDef> ScannableData { get; set; }
		[Ordinal(20)]  [RED("scanningBarText")] public TweakDBID ScanningBarText { get; set; }
		[Ordinal(21)]  [RED("timeNeeded")] public CFloat TimeNeeded { get; set; }

		public gameScanningComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
