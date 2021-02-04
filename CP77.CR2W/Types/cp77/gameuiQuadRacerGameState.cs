using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerGameState : gameuiMinigameState
	{
		[Ordinal(0)]  [RED("timeLeft")] public CFloat TimeLeft { get; set; }
		[Ordinal(1)]  [RED("boostTime")] public CFloat BoostTime { get; set; }
		[Ordinal(2)]  [RED("pointsBonusTime")] public CFloat PointsBonusTime { get; set; }
		[Ordinal(3)]  [RED("maxSpeed")] public CFloat MaxSpeed { get; set; }
		[Ordinal(4)]  [RED("speed")] public CFloat Speed { get; set; }
		[Ordinal(5)]  [RED("hasPassedCheckpoint")] public CBool HasPassedCheckpoint { get; set; }
		[Ordinal(6)]  [RED("shouldPushBackPlayer")] public CBool ShouldPushBackPlayer { get; set; }
		[Ordinal(7)]  [RED("lapsPassed")] public CInt32 LapsPassed { get; set; }

		public gameuiQuadRacerGameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
