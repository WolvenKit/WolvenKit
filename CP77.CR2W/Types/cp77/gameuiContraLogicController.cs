using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiContraLogicController : gameuiSideScrollerMiniGameLogicControllerAdvanced
	{
		[Ordinal(0)]  [RED("playerSpawnHeight")] public CFloat PlayerSpawnHeight { get; set; }
		[Ordinal(1)]  [RED("mainMenuScreenLibraryName")] public CName MainMenuScreenLibraryName { get; set; }
		[Ordinal(2)]  [RED("scoreboardScreenLibraryName")] public CName ScoreboardScreenLibraryName { get; set; }
		[Ordinal(3)]  [RED("uiLayerName")] public CName UiLayerName { get; set; }
		[Ordinal(4)]  [RED("gameLayerName")] public CName GameLayerName { get; set; }
		[Ordinal(5)]  [RED("platformLayerName")] public CName PlatformLayerName { get; set; }
		[Ordinal(6)]  [RED("backgroundLayerName")] public CName BackgroundLayerName { get; set; }
		[Ordinal(7)]  [RED("jumpKey")] public CName JumpKey { get; set; }
		[Ordinal(8)]  [RED("goDownKey")] public CName GoDownKey { get; set; }
		[Ordinal(9)]  [RED("goLeftKey")] public CName GoLeftKey { get; set; }
		[Ordinal(10)]  [RED("goRightKey")] public CName GoRightKey { get; set; }
		[Ordinal(11)]  [RED("lieDownKey")] public CName LieDownKey { get; set; }
		[Ordinal(12)]  [RED("shootKey")] public CName ShootKey { get; set; }
		[Ordinal(13)]  [RED("submitKey")] public CName SubmitKey { get; set; }
		[Ordinal(14)]  [RED("axisDeadZone")] public CFloat AxisDeadZone { get; set; }
		[Ordinal(15)]  [RED("moveXAxis")] public CName MoveXAxis { get; set; }
		[Ordinal(16)]  [RED("moveYAxis")] public CName MoveYAxis { get; set; }
		[Ordinal(17)]  [RED("shootTriggerName")] public CName ShootTriggerName { get; set; }
		[Ordinal(18)]  [RED("tileLibraryName")] public CName TileLibraryName { get; set; }
		[Ordinal(19)]  [RED("platformLibraryName")] public CName PlatformLibraryName { get; set; }
		[Ordinal(20)]  [RED("platformTexturePartName")] public CName PlatformTexturePartName { get; set; }
		[Ordinal(21)]  [RED("RoadTexturePartName")] public CName RoadTexturePartName { get; set; }
		[Ordinal(22)]  [RED("middlePlatformMinDistance")] public CFloat MiddlePlatformMinDistance { get; set; }
		[Ordinal(23)]  [RED("middlePlatformMaxDistance")] public CFloat MiddlePlatformMaxDistance { get; set; }
		[Ordinal(24)]  [RED("topPlatformPosition")] public CFloat TopPlatformPosition { get; set; }
		[Ordinal(25)]  [RED("bottomPlatformPosition")] public CFloat BottomPlatformPosition { get; set; }
		[Ordinal(26)]  [RED("fenceLibraryName")] public CName FenceLibraryName { get; set; }
		[Ordinal(27)]  [RED("fenceSpawnDistance")] public CFloat FenceSpawnDistance { get; set; }

		public gameuiContraLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
