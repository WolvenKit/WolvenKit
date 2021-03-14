using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStimuli_ConditionType : questISensesConditionType
	{
		[Ordinal(0)] [RED("instigatorRef")] public gameEntityReference InstigatorRef { get; set; }
		[Ordinal(1)] [RED("isPlayerInstigator")] public CBool IsPlayerInstigator { get; set; }
		[Ordinal(2)] [RED("targetRef")] public gameEntityReference TargetRef { get; set; }
		[Ordinal(3)] [RED("type")] public CEnum<gamedataStimType> Type { get; set; }

		public questStimuli_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
