using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceGameState : gameuiMinigameState
	{
		[Ordinal(0)]  [RED("invincibleTime")] public CFloat InvincibleTime { get; set; }
		[Ordinal(1)]  [RED("pointsBonusTime")] public CFloat PointsBonusTime { get; set; }
		[Ordinal(2)]  [RED("speedMultiplicator")] public CFloat SpeedMultiplicator { get; set; }

		public gameuiRoachRaceGameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
