using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceGameLogicController : gameuiSideScrollerMiniGameLogicController
	{
		[Ordinal(10)] [RED("jumpAcceleration")] public CFloat JumpAcceleration { get; set; }
		[Ordinal(11)] [RED("jumpCancelAcceleration")] public CFloat JumpCancelAcceleration { get; set; }
		[Ordinal(12)] [RED("gravity")] public CFloat Gravity { get; set; }
		[Ordinal(13)] [RED("playerSpawnPoint")] public Vector2 PlayerSpawnPoint { get; set; }
		[Ordinal(14)] [RED("pixelsPerScore")] public CFloat PixelsPerScore { get; set; }
		[Ordinal(15)] [RED("invincibilityTime")] public CFloat InvincibilityTime { get; set; }
		[Ordinal(16)] [RED("maxSpeedMultiplier")] public CFloat MaxSpeedMultiplier { get; set; }
		[Ordinal(17)] [RED("multiplierPerScore")] public CFloat MultiplierPerScore { get; set; }
		[Ordinal(18)] [RED("house")] public inkWidgetReference House { get; set; }
		[Ordinal(19)] [RED("ground")] public inkWidgetReference Ground { get; set; }
		[Ordinal(20)] [RED("startAnimation")] public CName StartAnimation { get; set; }
		[Ordinal(21)] [RED("deathAnimation")] public CName DeathAnimation { get; set; }
		[Ordinal(22)] [RED("layers")] public CArray<gameuiRoachRaceChunkLayer> Layers { get; set; }
		[Ordinal(23)] [RED("damageAnimation")] public CName DamageAnimation { get; set; }
		[Ordinal(24)] [RED("healAnimation")] public CName HealAnimation { get; set; }
		[Ordinal(25)] [RED("healthText")] public inkTextWidgetReference HealthText { get; set; }
		[Ordinal(26)] [RED("scoreText")] public inkTextWidgetReference ScoreText { get; set; }
		[Ordinal(27)] [RED("scoreMultiplierText")] public inkTextWidgetReference ScoreMultiplierText { get; set; }
		[Ordinal(28)] [RED("previousHealth")] public CInt32 PreviousHealth { get; set; }

		public gameuiRoachRaceGameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
