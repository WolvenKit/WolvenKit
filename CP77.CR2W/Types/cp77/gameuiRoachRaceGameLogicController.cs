using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceGameLogicController : gameuiSideScrollerMiniGameLogicController
	{
		[Ordinal(0)]  [RED("isGameRunning")] public CBool IsGameRunning { get; set; }
		[Ordinal(1)]  [RED("jumpAcceleration")] public CFloat JumpAcceleration { get; set; }
		[Ordinal(2)]  [RED("jumpCancelAcceleration")] public CFloat JumpCancelAcceleration { get; set; }
		[Ordinal(3)]  [RED("gravity")] public CFloat Gravity { get; set; }
		[Ordinal(4)]  [RED("playerSpawnPoint")] public Vector2 PlayerSpawnPoint { get; set; }
		[Ordinal(5)]  [RED("pixelsPerScore")] public CFloat PixelsPerScore { get; set; }
		[Ordinal(6)]  [RED("invincibilityTime")] public CFloat InvincibilityTime { get; set; }
		[Ordinal(7)]  [RED("maxSpeedMultiplier")] public CFloat MaxSpeedMultiplier { get; set; }
		[Ordinal(8)]  [RED("multiplierPerScore")] public CFloat MultiplierPerScore { get; set; }
		[Ordinal(9)]  [RED("house")] public inkWidgetReference House { get; set; }
		[Ordinal(10)]  [RED("ground")] public inkWidgetReference Ground { get; set; }
		[Ordinal(11)]  [RED("startAnimation")] public CName StartAnimation { get; set; }
		[Ordinal(12)]  [RED("deathAnimation")] public CName DeathAnimation { get; set; }
		[Ordinal(13)]  [RED("layers")] public CArray<gameuiRoachRaceChunkLayer> Layers { get; set; }
		[Ordinal(14)]  [RED("damageAnimation")] public CName DamageAnimation { get; set; }
		[Ordinal(15)]  [RED("healAnimation")] public CName HealAnimation { get; set; }
		[Ordinal(16)]  [RED("healthText")] public inkTextWidgetReference HealthText { get; set; }
		[Ordinal(17)]  [RED("scoreText")] public inkTextWidgetReference ScoreText { get; set; }
		[Ordinal(18)]  [RED("scoreMultiplierText")] public inkTextWidgetReference ScoreMultiplierText { get; set; }
		[Ordinal(19)]  [RED("previousHealth")] public CInt32 PreviousHealth { get; set; }

		public gameuiRoachRaceGameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
