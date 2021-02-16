using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponent : gameComponent
	{
		[Ordinal(4)] [RED("scannableData")] public CArray<gameScanningTooltipElementDef> ScannableData { get; set; }
		[Ordinal(5)] [RED("timeNeeded")] public CFloat TimeNeeded { get; set; }
		[Ordinal(6)] [RED("autoGenerateBoundingSphere")] public CBool AutoGenerateBoundingSphere { get; set; }
		[Ordinal(7)] [RED("boundingSphere")] public Sphere BoundingSphere { get; set; }
		[Ordinal(8)] [RED("ignoresScanningDistanceLimit")] public CBool IgnoresScanningDistanceLimit { get; set; }
		[Ordinal(9)] [RED("cpoEnableMultiplePlayersScanningModifier")] public CBool CpoEnableMultiplePlayersScanningModifier { get; set; }
		[Ordinal(10)] [RED("isBraindanceClue")] public CBool IsBraindanceClue { get; set; }
		[Ordinal(11)] [RED("BraindanceLayer")] public CEnum<braindanceVisionMode> BraindanceLayer { get; set; }
		[Ordinal(12)] [RED("isBraindanceBlocked")] public CBool IsBraindanceBlocked { get; set; }
		[Ordinal(13)] [RED("isBraindanceLayerUnlocked")] public CBool IsBraindanceLayerUnlocked { get; set; }
		[Ordinal(14)] [RED("isBraindanceTimelineUnlocked")] public CBool IsBraindanceTimelineUnlocked { get; set; }
		[Ordinal(15)] [RED("isBraindanceActive")] public CBool IsBraindanceActive { get; set; }
		[Ordinal(16)] [RED("currentBraindanceLayer")] public CInt32 CurrentBraindanceLayer { get; set; }
		[Ordinal(17)] [RED("clues")] public CArray<FocusClueDefinition> Clues { get; set; }
		[Ordinal(18)] [RED("objectDescription")] public CHandle<ObjectScanningDescription> ObjectDescription { get; set; }
		[Ordinal(19)] [RED("scanningBarText")] public TweakDBID ScanningBarText { get; set; }
		[Ordinal(20)] [RED("isFocusModeActive")] public CBool IsFocusModeActive { get; set; }
		[Ordinal(21)] [RED("currentHighlight")] public CHandle<FocusForcedHighlightData> CurrentHighlight { get; set; }
		[Ordinal(22)] [RED("isHudManagerInitialized")] public CBool IsHudManagerInitialized { get; set; }
		[Ordinal(23)] [RED("isBeingScanned")] public CBool IsBeingScanned { get; set; }
		[Ordinal(24)] [RED("isScanningCluesBlocked")] public CBool IsScanningCluesBlocked { get; set; }
		[Ordinal(25)] [RED("isEntityVisible")] public CBool IsEntityVisible { get; set; }

		public gameScanningComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
