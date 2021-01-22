using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorExpressionSocket : ISerializable
	{
		[Ordinal(0)]  [RED("expression")] public CHandle<AIbehaviorPassiveExpressionDefinition> Expression { get; set; }
		[Ordinal(1)]  [RED("typeHint")] public AIbehaviorTypeRef TypeHint { get; set; }

		public AIbehaviorExpressionSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
