using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEntityLODConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("all")] public CArray<CEnum<AIbehaviorEntityLODConditions>> All { get; set; }
		[Ordinal(1)]  [RED("any")] public CArray<CEnum<AIbehaviorEntityLODConditions>> Any { get; set; }
		[Ordinal(2)]  [RED("none")] public CArray<CEnum<AIbehaviorEntityLODConditions>> None { get; set; }

		public AIbehaviorEntityLODConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
