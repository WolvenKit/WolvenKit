using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayConditionContainer : IScriptable
	{
		[Ordinal(0)] [RED("logicOperator")] public CEnum<ELogicOperator> LogicOperator { get; set; }
		[Ordinal(1)] [RED("conditionGroups")] public CArray<ConditionGroupData> ConditionGroups { get; set; }

		public GameplayConditionContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
