using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConstantExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		[Ordinal(0)]  [RED("type")] public AIbehaviorTypeRef Type { get; set; }
		[Ordinal(1)]  [RED("value")] public CVariant Value { get; set; }

		public AIbehaviorConstantExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
