using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceGameLogicController : gameuiSideScrollerMiniGameLogicController
	{
		[Ordinal(0)]  [RED("jumpAcceleration")] public CFloat JumpAcceleration { get; set; }
		[Ordinal(1)]  [RED("jumpCancelAcceleration")] public CFloat JumpCancelAcceleration { get; set; }
		[Ordinal(2)]  [RED("gravity")] public CFloat Gravity { get; set; }
		[Ordinal(3)]  [RED("playerSpawnPoint")] public Vector2 PlayerSpawnPoint { get; set; }
		[Ordinal(4)]  [RED("pixelsPerScore")] public CFloat PixelsPerScore { get; set; }
		[Ordinal(5)]  [RED("invincibilityTime")] public CFloat InvincibilityTime { get; set; }
		[Ordinal(6)]  [RED("maxSpeedMultiplier")] public CFloat MaxSpeedMultiplier { get; set; }
		[Ordinal(7)]  [RED("multiplierPerScore")] public CFloat MultiplierPerScore { get; set; }
		[Ordinal(8)]  [RED("house")] public inkWidgetReference House { get; set; }
		[Ordinal(9)]  [RED("ground")] public inkWidgetReference Ground { get; set; }
		[Ordinal(10)]  [RED("startAnimation")] public CName StartAnimation { get; set; }
		[Ordinal(11)]  [RED("deathAnimation")] public CName DeathAnimation { get; set; }
		[Ordinal(12)]  [RED("layers")] public CArray<gameuiRoachRaceChunkLayer> Layers { get; set; }

		public gameuiRoachRaceGameLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
