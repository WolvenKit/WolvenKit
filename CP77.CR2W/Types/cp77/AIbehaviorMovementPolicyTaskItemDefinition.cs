using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMovementPolicyTaskItemDefinition : ISerializable
	{
		[Ordinal(0)] [RED("function")] public CEnum<AIbehaviorMovementPolicyTaskFunctions> Function { get; set; }
		[Ordinal(1)] [RED("params", 4)] public CStatic<CHandle<AIbehaviorExpressionSocket>> Params { get; set; }

		public AIbehaviorMovementPolicyTaskItemDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
