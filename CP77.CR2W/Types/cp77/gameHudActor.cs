using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameHudActor : IScriptable
	{
		[Ordinal(0)] [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<HUDActorType> Type { get; set; }
		[Ordinal(2)] [RED("status")] public CEnum<HUDActorStatus> Status { get; set; }
		[Ordinal(3)] [RED("visibility")] public CEnum<ActorVisibilityStatus> Visibility { get; set; }
		[Ordinal(4)] [RED("activeModules")] public CArray<wCHandle<HUDModule>> ActiveModules { get; set; }
		[Ordinal(5)] [RED("isRevealed")] public CBool IsRevealed { get; set; }
		[Ordinal(6)] [RED("isTagged")] public CBool IsTagged { get; set; }
		[Ordinal(7)] [RED("clueData")] public HUDClueData ClueData { get; set; }
		[Ordinal(8)] [RED("isRemotelyAccessed")] public CBool IsRemotelyAccessed { get; set; }
		[Ordinal(9)] [RED("canOpenScannerInfo")] public CBool CanOpenScannerInfo { get; set; }
		[Ordinal(10)] [RED("isInIconForcedVisibilityRange")] public CBool IsInIconForcedVisibilityRange { get; set; }
		[Ordinal(11)] [RED("isIconForcedVisibleThroughWalls")] public CBool IsIconForcedVisibleThroughWalls { get; set; }
		[Ordinal(12)] [RED("shouldRefreshQHack")] public CBool ShouldRefreshQHack { get; set; }

		public gameHudActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
