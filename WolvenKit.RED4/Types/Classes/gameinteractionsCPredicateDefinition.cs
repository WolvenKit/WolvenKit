using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCPredicateDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("predicateType")] 
		public CHandle<gameinteractionsIPredicateType> PredicateType
		{
			get => GetPropertyValue<CHandle<gameinteractionsIPredicateType>>();
			set => SetPropertyValue<CHandle<gameinteractionsIPredicateType>>(value);
		}

		[Ordinal(1)] 
		[RED("binaryOperator")] 
		public CEnum<gameinteractionsEBinaryOperator> BinaryOperator
		{
			get => GetPropertyValue<CEnum<gameinteractionsEBinaryOperator>>();
			set => SetPropertyValue<CEnum<gameinteractionsEBinaryOperator>>(value);
		}

		[Ordinal(2)] 
		[RED("functor1DataDefinition")] 
		public CHandle<gameinteractionsCFunctorDefinition> Functor1DataDefinition
		{
			get => GetPropertyValue<CHandle<gameinteractionsCFunctorDefinition>>();
			set => SetPropertyValue<CHandle<gameinteractionsCFunctorDefinition>>(value);
		}

		[Ordinal(3)] 
		[RED("functor2DataDefinition")] 
		public CHandle<gameinteractionsCFunctorDefinition> Functor2DataDefinition
		{
			get => GetPropertyValue<CHandle<gameinteractionsCFunctorDefinition>>();
			set => SetPropertyValue<CHandle<gameinteractionsCFunctorDefinition>>(value);
		}

		public gameinteractionsCPredicateDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
