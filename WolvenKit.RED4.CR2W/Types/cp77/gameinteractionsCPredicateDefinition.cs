using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCPredicateDefinition : CVariable
	{
		private CHandle<gameinteractionsIPredicateType> _predicateType;
		private CEnum<gameinteractionsEBinaryOperator> _binaryOperator;
		private CHandle<gameinteractionsCFunctorDefinition> _functor1DataDefinition;
		private CHandle<gameinteractionsCFunctorDefinition> _functor2DataDefinition;

		[Ordinal(0)] 
		[RED("predicateType")] 
		public CHandle<gameinteractionsIPredicateType> PredicateType
		{
			get => GetProperty(ref _predicateType);
			set => SetProperty(ref _predicateType, value);
		}

		[Ordinal(1)] 
		[RED("binaryOperator")] 
		public CEnum<gameinteractionsEBinaryOperator> BinaryOperator
		{
			get => GetProperty(ref _binaryOperator);
			set => SetProperty(ref _binaryOperator, value);
		}

		[Ordinal(2)] 
		[RED("functor1DataDefinition")] 
		public CHandle<gameinteractionsCFunctorDefinition> Functor1DataDefinition
		{
			get => GetProperty(ref _functor1DataDefinition);
			set => SetProperty(ref _functor1DataDefinition, value);
		}

		[Ordinal(3)] 
		[RED("functor2DataDefinition")] 
		public CHandle<gameinteractionsCFunctorDefinition> Functor2DataDefinition
		{
			get => GetProperty(ref _functor2DataDefinition);
			set => SetProperty(ref _functor2DataDefinition, value);
		}

		public gameinteractionsCPredicateDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
