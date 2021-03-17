using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCFunctorDefinition : gameinteractionsIFunctorDefinition
	{
		private gameinteractionsCPredicateDefinition _predicate;
		private CEnum<gameinteractionsEUnaryOperator> _unaryOperator;

		[Ordinal(0)] 
		[RED("predicate")] 
		public gameinteractionsCPredicateDefinition Predicate
		{
			get => GetProperty(ref _predicate);
			set => SetProperty(ref _predicate, value);
		}

		[Ordinal(1)] 
		[RED("unaryOperator")] 
		public CEnum<gameinteractionsEUnaryOperator> UnaryOperator
		{
			get => GetProperty(ref _unaryOperator);
			set => SetProperty(ref _unaryOperator, value);
		}

		public gameinteractionsCFunctorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
