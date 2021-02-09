using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("gameName")] public CName GameName { get; set; }
		[Ordinal(1)]  [RED("startHealth")] public CUInt32 StartHealth { get; set; }
		[Ordinal(2)]  [RED("playerLibraryName")] public CName PlayerLibraryName { get; set; }
		[Ordinal(3)]  [RED("playerColliderPositionOffset")] public Vector2 PlayerColliderPositionOffset { get; set; }
		[Ordinal(4)]  [RED("playerColliderSizeOffset")] public Vector2 PlayerColliderSizeOffset { get; set; }
		[Ordinal(5)]  [RED("gameplayRoot")] public inkCompoundWidgetReference GameplayRoot { get; set; }
		[Ordinal(6)]  [RED("baseSpeed")] public CFloat BaseSpeed { get; set; }
		[Ordinal(7)]  [RED("spawnedListLibraryNames")] public CArray<CName> SpawnedListLibraryNames { get; set; }
		[Ordinal(8)]  [RED("isGameRunning")] public CBool IsGameRunning { get; set; }

		public gameuiSideScrollerMiniGameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
