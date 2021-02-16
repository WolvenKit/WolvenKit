using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerGameLogicController : gameuiSideScrollerMiniGameLogicControllerAdvanced
	{
		[Ordinal(9)] [RED("gameOverDelay")] public CFloat GameOverDelay { get; set; }
		[Ordinal(10)] [RED("mainMenuLibraryName")] public CName MainMenuLibraryName { get; set; }
		[Ordinal(11)] [RED("scoreboardLibraryName")] public CName ScoreboardLibraryName { get; set; }
		[Ordinal(12)] [RED("panelsLayer")] public CName PanelsLayer { get; set; }
		[Ordinal(13)] [RED("gameLayer")] public CName GameLayer { get; set; }
		[Ordinal(14)] [RED("cloudsLayer")] public CName CloudsLayer { get; set; }
		[Ordinal(15)] [RED("backgroundLibraryName")] public CName BackgroundLibraryName { get; set; }
		[Ordinal(16)] [RED("cloudsLibraryNames")] public CArray<CName> CloudsLibraryNames { get; set; }
		[Ordinal(17)] [RED("minCloudSpawnInterval")] public CFloat MinCloudSpawnInterval { get; set; }
		[Ordinal(18)] [RED("maxCloudSpawnInterval")] public CFloat MaxCloudSpawnInterval { get; set; }
		[Ordinal(19)] [RED("minCloudSpeed")] public CFloat MinCloudSpeed { get; set; }
		[Ordinal(20)] [RED("maxCloudSpeed")] public CFloat MaxCloudSpeed { get; set; }
		[Ordinal(21)] [RED("scoreCounter")] public inkTextWidgetReference ScoreCounter { get; set; }
		[Ordinal(22)] [RED("livesCounter")] public inkTextWidgetReference LivesCounter { get; set; }
		[Ordinal(23)] [RED("moveUpKey")] public CName MoveUpKey { get; set; }
		[Ordinal(24)] [RED("moveDownKey")] public CName MoveDownKey { get; set; }
		[Ordinal(25)] [RED("moveLeftKey")] public CName MoveLeftKey { get; set; }
		[Ordinal(26)] [RED("moveRightKey")] public CName MoveRightKey { get; set; }
		[Ordinal(27)] [RED("shootKey")] public CName ShootKey { get; set; }
		[Ordinal(28)] [RED("backKey")] public CName BackKey { get; set; }
		[Ordinal(29)] [RED("submitKey")] public CName SubmitKey { get; set; }
		[Ordinal(30)] [RED("axisDeadZone")] public CFloat AxisDeadZone { get; set; }
		[Ordinal(31)] [RED("moveXAxis")] public CName MoveXAxis { get; set; }
		[Ordinal(32)] [RED("moveYAxis")] public CName MoveYAxis { get; set; }
		[Ordinal(33)] [RED("shootAxis")] public CName ShootAxis { get; set; }
		[Ordinal(34)] [RED("droneLibraryName")] public CName DroneLibraryName { get; set; }
		[Ordinal(35)] [RED("minDroneSpawnInterval")] public CFloat MinDroneSpawnInterval { get; set; }
		[Ordinal(36)] [RED("maxDroneSpawnInterval")] public CFloat MaxDroneSpawnInterval { get; set; }
		[Ordinal(37)] [RED("avLibraryName")] public CName AvLibraryName { get; set; }
		[Ordinal(38)] [RED("minAvSpawnInterval")] public CFloat MinAvSpawnInterval { get; set; }
		[Ordinal(39)] [RED("maxAvSpawnInterval")] public CFloat MaxAvSpawnInterval { get; set; }

		public gameuiPanzerGameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
