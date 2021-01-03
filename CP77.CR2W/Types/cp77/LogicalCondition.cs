using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LogicalCondition : workIScriptedCondition
	{
		[Ordinal(0)]  [RED("conditions")] public CArray<CHandle<workIScriptedCondition>> Conditions { get; set; }
		[Ordinal(1)]  [RED("operation")] public CEnum<WorkspotConditionOperators> Operation { get; set; }

		public LogicalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
