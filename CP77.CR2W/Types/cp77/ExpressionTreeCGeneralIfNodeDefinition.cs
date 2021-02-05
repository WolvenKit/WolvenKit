using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ExpressionTreeCGeneralIfNodeDefinition : ExpressionTreeCGeneralNodeDefinition
	{
		[Ordinal(0)]  [RED("expressions")] public CArray<CHandle<LibTreeINodeDefinition>> Expressions { get; set; }
		[Ordinal(1)]  [RED("trueBranch")] public CHandle<LibTreeINodeDefinition> TrueBranch { get; set; }
		[Ordinal(2)]  [RED("falseBranch")] public CHandle<LibTreeINodeDefinition> FalseBranch { get; set; }

		public ExpressionTreeCGeneralIfNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
