using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIFollowerInterpolateFollowingSpeed : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("enterCondition")] public TweakDBID EnterCondition { get; set; }
		[Ordinal(1)]  [RED("exitCondition")] public TweakDBID ExitCondition { get; set; }
		[Ordinal(2)]  [RED("minInterpolationDistanceToDestination")] public CFloat MinInterpolationDistanceToDestination { get; set; }
		[Ordinal(3)]  [RED("maxInterpolationDistanceToDestination")] public CFloat MaxInterpolationDistanceToDestination { get; set; }
		[Ordinal(4)]  [RED("maxTimeDilation")] public CFloat MaxTimeDilation { get; set; }
		[Ordinal(5)]  [RED("enterConditionInstance")] public wCHandle<gamedataAIActionCondition_Record> EnterConditionInstance { get; set; }
		[Ordinal(6)]  [RED("exitConditionInstace")] public wCHandle<gamedataAIActionCondition_Record> ExitConditionInstace { get; set; }
		[Ordinal(7)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(8)]  [RED("reason")] public CName Reason { get; set; }

		public AIFollowerInterpolateFollowingSpeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
