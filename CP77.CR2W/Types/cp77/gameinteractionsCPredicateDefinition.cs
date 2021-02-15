using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCPredicateDefinition : CVariable
	{
		[Ordinal(0)] [RED("predicateType")] public CHandle<gameinteractionsIPredicateType> PredicateType { get; set; }
		[Ordinal(1)] [RED("binaryOperator")] public CEnum<gameinteractionsEBinaryOperator> BinaryOperator { get; set; }
		[Ordinal(2)] [RED("functor1DataDefinition")] public CHandle<gameinteractionsCFunctorDefinition> Functor1DataDefinition { get; set; }
		[Ordinal(3)] [RED("functor2DataDefinition")] public CHandle<gameinteractionsCFunctorDefinition> Functor2DataDefinition { get; set; }

		public gameinteractionsCPredicateDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
