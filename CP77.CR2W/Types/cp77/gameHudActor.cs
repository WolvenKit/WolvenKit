using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHudActor : IScriptable
	{
		[Ordinal(0)]  [RED("activeModules")] public CArray<wCHandle<HUDModule>> ActiveModules { get; set; }
		[Ordinal(1)]  [RED("canOpenScannerInfo")] public CBool CanOpenScannerInfo { get; set; }
		[Ordinal(2)]  [RED("clueData")] public HUDClueData ClueData { get; set; }
		[Ordinal(3)]  [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(4)]  [RED("isIconForcedVisibleThroughWalls")] public CBool IsIconForcedVisibleThroughWalls { get; set; }
		[Ordinal(5)]  [RED("isInIconForcedVisibilityRange")] public CBool IsInIconForcedVisibilityRange { get; set; }
		[Ordinal(6)]  [RED("isRemotelyAccessed")] public CBool IsRemotelyAccessed { get; set; }
		[Ordinal(7)]  [RED("isRevealed")] public CBool IsRevealed { get; set; }
		[Ordinal(8)]  [RED("isTagged")] public CBool IsTagged { get; set; }
		[Ordinal(9)]  [RED("shouldRefreshQHack")] public CBool ShouldRefreshQHack { get; set; }
		[Ordinal(10)]  [RED("status")] public CEnum<HUDActorStatus> Status { get; set; }
		[Ordinal(11)]  [RED("type")] public CEnum<HUDActorType> Type { get; set; }
		[Ordinal(12)]  [RED("visibility")] public CEnum<ActorVisibilityStatus> Visibility { get; set; }

		public gameHudActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
