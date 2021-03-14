using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiContraLogicController : gameuiSideScrollerMiniGameLogicControllerAdvanced
	{
		[Ordinal(9)] [RED("playerSpawnHeight")] public CFloat PlayerSpawnHeight { get; set; }
		[Ordinal(10)] [RED("mainMenuScreenLibraryName")] public CName MainMenuScreenLibraryName { get; set; }
		[Ordinal(11)] [RED("scoreboardScreenLibraryName")] public CName ScoreboardScreenLibraryName { get; set; }
		[Ordinal(12)] [RED("jumpKey")] public CName JumpKey { get; set; }
		[Ordinal(13)] [RED("goDownKey")] public CName GoDownKey { get; set; }
		[Ordinal(14)] [RED("goLeftKey")] public CName GoLeftKey { get; set; }
		[Ordinal(15)] [RED("goRightKey")] public CName GoRightKey { get; set; }
		[Ordinal(16)] [RED("lieDownKey")] public CName LieDownKey { get; set; }
		[Ordinal(17)] [RED("shootKey")] public CName ShootKey { get; set; }
		[Ordinal(18)] [RED("submitKey")] public CName SubmitKey { get; set; }
		[Ordinal(19)] [RED("axisDeadZone")] public CFloat AxisDeadZone { get; set; }
		[Ordinal(20)] [RED("moveXAxis")] public CName MoveXAxis { get; set; }
		[Ordinal(21)] [RED("moveYAxis")] public CName MoveYAxis { get; set; }
		[Ordinal(22)] [RED("shootTriggerName")] public CName ShootTriggerName { get; set; }
		[Ordinal(23)] [RED("uiLayerName")] public CName UiLayerName { get; set; }
		[Ordinal(24)] [RED("gameLayerName")] public CName GameLayerName { get; set; }
		[Ordinal(25)] [RED("platformLayerName")] public CName PlatformLayerName { get; set; }
		[Ordinal(26)] [RED("backgroundLayerName")] public CName BackgroundLayerName { get; set; }
		[Ordinal(27)] [RED("tileLibraryName")] public CName TileLibraryName { get; set; }
		[Ordinal(28)] [RED("platformLibraryName")] public CName PlatformLibraryName { get; set; }
		[Ordinal(29)] [RED("platformTexturePartName")] public CName PlatformTexturePartName { get; set; }
		[Ordinal(30)] [RED("RoadTexturePartName")] public CName RoadTexturePartName { get; set; }
		[Ordinal(31)] [RED("middlePlatformMinDistance")] public CFloat MiddlePlatformMinDistance { get; set; }
		[Ordinal(32)] [RED("middlePlatformMaxDistance")] public CFloat MiddlePlatformMaxDistance { get; set; }
		[Ordinal(33)] [RED("topPlatformPosition")] public CFloat TopPlatformPosition { get; set; }
		[Ordinal(34)] [RED("bottomPlatformPosition")] public CFloat BottomPlatformPosition { get; set; }
		[Ordinal(35)] [RED("fenceLibraryName")] public CName FenceLibraryName { get; set; }
		[Ordinal(36)] [RED("fenceSpawnDistance")] public CFloat FenceSpawnDistance { get; set; }

		public gameuiContraLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
