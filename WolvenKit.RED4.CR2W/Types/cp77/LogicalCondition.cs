using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LogicalCondition : workIScriptedCondition
	{
		[Ordinal(0)] [RED("operation")] public CEnum<WorkspotConditionOperators> Operation { get; set; }
		[Ordinal(1)] [RED("conditions")] public CArray<CHandle<workIScriptedCondition>> Conditions { get; set; }

		public LogicalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
