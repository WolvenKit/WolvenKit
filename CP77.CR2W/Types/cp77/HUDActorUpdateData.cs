using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HUDActorUpdateData : IScriptable
	{
		[Ordinal(0)]  [RED("canOpenScannerInfoValue")] public CBool CanOpenScannerInfoValue { get; set; }
		[Ordinal(1)]  [RED("clueDataValue")] public HUDClueData ClueDataValue { get; set; }
		[Ordinal(2)]  [RED("isIconForcedVisibleThroughWallsValue")] public CBool IsIconForcedVisibleThroughWallsValue { get; set; }
		[Ordinal(3)]  [RED("isInIconForcedVisibilityRangeValue")] public CBool IsInIconForcedVisibilityRangeValue { get; set; }
		[Ordinal(4)]  [RED("isRemotelyAccessedValue")] public CBool IsRemotelyAccessedValue { get; set; }
		[Ordinal(5)]  [RED("isRevealedValue")] public CBool IsRevealedValue { get; set; }
		[Ordinal(6)]  [RED("isTaggedValue")] public CBool IsTaggedValue { get; set; }
		[Ordinal(7)]  [RED("updateCanOpenScannerInfo")] public CBool UpdateCanOpenScannerInfo { get; set; }
		[Ordinal(8)]  [RED("updateClueData")] public CBool UpdateClueData { get; set; }
		[Ordinal(9)]  [RED("updateIsIconForcedVisibleThroughWalls")] public CBool UpdateIsIconForcedVisibleThroughWalls { get; set; }
		[Ordinal(10)]  [RED("updateIsInIconForcedVisibilityRange")] public CBool UpdateIsInIconForcedVisibilityRange { get; set; }
		[Ordinal(11)]  [RED("updateIsRemotelyAccessed")] public CBool UpdateIsRemotelyAccessed { get; set; }
		[Ordinal(12)]  [RED("updateIsRevealed")] public CBool UpdateIsRevealed { get; set; }
		[Ordinal(13)]  [RED("updateIsTagged")] public CBool UpdateIsTagged { get; set; }
		[Ordinal(14)]  [RED("updateVisibility")] public CBool UpdateVisibility { get; set; }
		[Ordinal(15)]  [RED("visibilityValue")] public CEnum<ActorVisibilityStatus> VisibilityValue { get; set; }

		public HUDActorUpdateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
