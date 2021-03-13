using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedContinuousAttack : CVariable
	{
		[Ordinal(0)] [RED("startTimeStamp")] public netTime StartTimeStamp { get; set; }
		[Ordinal(1)] [RED("stopTimeStamp")] public netTime StopTimeStamp { get; set; }
		[Ordinal(2)] [RED("attackId")] public TweakDBID AttackId { get; set; }

		public gameReplicatedContinuousAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
