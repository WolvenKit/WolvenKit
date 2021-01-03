using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ConditionGroupData : CVariable
	{
		[Ordinal(0)]  [RED("conditions")] public CArray<CHandle<GameplayConditionBase>> Conditions { get; set; }
		[Ordinal(1)]  [RED("logicOperator")] public CEnum<ELogicOperator> LogicOperator { get; set; }

		public ConditionGroupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
