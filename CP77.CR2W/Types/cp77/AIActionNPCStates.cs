using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIActionNPCStates : CVariable
	{
		[Ordinal(0)] [RED("highLevelStates")] public CArray<CEnum<gamedataNPCHighLevelState>> HighLevelStates { get; set; }
		[Ordinal(1)] [RED("upperBodyStates")] public CArray<CEnum<gamedataNPCUpperBodyState>> UpperBodyStates { get; set; }
		[Ordinal(2)] [RED("stanceStates")] public CArray<CEnum<gamedataNPCStanceState>> StanceStates { get; set; }
		[Ordinal(3)] [RED("behaviorStates")] public CArray<CEnum<gamedataNPCBehaviorState>> BehaviorStates { get; set; }
		[Ordinal(4)] [RED("defenseMode")] public CArray<CEnum<gamedataDefenseMode>> DefenseMode { get; set; }
		[Ordinal(5)] [RED("locomotionMode")] public CArray<CEnum<gamedataLocomotionMode>> LocomotionMode { get; set; }

		public AIActionNPCStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
