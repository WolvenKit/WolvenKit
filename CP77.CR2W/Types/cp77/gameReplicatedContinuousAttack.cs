using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedContinuousAttack : CVariable
	{
		[Ordinal(0)]  [RED("attackId")] public TweakDBID AttackId { get; set; }
		[Ordinal(1)]  [RED("startTimeStamp")] public netTime StartTimeStamp { get; set; }
		[Ordinal(2)]  [RED("stopTimeStamp")] public netTime StopTimeStamp { get; set; }

		public gameReplicatedContinuousAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
