using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAnimationTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("record")] public TweakDBID Record { get; set; }
		[Ordinal(1)] [RED("animVariation")] public CHandle<AIArgumentMapping> AnimVariation { get; set; }
		[Ordinal(2)] [RED("actionRecord")] public wCHandle<gamedataAIAction_Record> ActionRecord { get; set; }
		[Ordinal(3)] [RED("actionDebugName")] public CString ActionDebugName { get; set; }
		[Ordinal(4)] [RED("animVariationValue")] public CInt32 AnimVariationValue { get; set; }
		[Ordinal(5)] [RED("phaseRecord")] public wCHandle<gamedataAIActionPhase_Record> PhaseRecord { get; set; }
		[Ordinal(6)] [RED("actionPhase")] public CEnum<EAIActionPhase> ActionPhase { get; set; }
		[Ordinal(7)] [RED("phaseActivationTime")] public CFloat PhaseActivationTime { get; set; }
		[Ordinal(8)] [RED("phaseDuration")] public CFloat PhaseDuration { get; set; }

		public AIAnimationTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
