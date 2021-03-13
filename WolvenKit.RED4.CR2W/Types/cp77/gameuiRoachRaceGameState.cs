using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceGameState : gameuiMinigameState
	{
		[Ordinal(2)] [RED("invincibleTime")] public CFloat InvincibleTime { get; set; }
		[Ordinal(3)] [RED("pointsBonusTime")] public CFloat PointsBonusTime { get; set; }
		[Ordinal(4)] [RED("speedMultiplicator")] public CFloat SpeedMultiplicator { get; set; }

		public gameuiRoachRaceGameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
