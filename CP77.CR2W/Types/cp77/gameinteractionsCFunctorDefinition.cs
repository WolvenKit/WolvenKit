using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCFunctorDefinition : gameinteractionsIFunctorDefinition
	{
		[Ordinal(0)]  [RED("predicate")] public gameinteractionsCPredicateDefinition Predicate { get; set; }
		[Ordinal(1)]  [RED("unaryOperator")] public CEnum<gameinteractionsEUnaryOperator> UnaryOperator { get; set; }

		public gameinteractionsCFunctorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
