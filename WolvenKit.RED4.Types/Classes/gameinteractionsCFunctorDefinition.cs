using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCFunctorDefinition : gameinteractionsIFunctorDefinition
	{
		[Ordinal(0)] 
		[RED("predicate")] 
		public gameinteractionsCPredicateDefinition Predicate
		{
			get => GetPropertyValue<gameinteractionsCPredicateDefinition>();
			set => SetPropertyValue<gameinteractionsCPredicateDefinition>(value);
		}

		[Ordinal(1)] 
		[RED("unaryOperator")] 
		public CEnum<gameinteractionsEUnaryOperator> UnaryOperator
		{
			get => GetPropertyValue<CEnum<gameinteractionsEUnaryOperator>>();
			set => SetPropertyValue<CEnum<gameinteractionsEUnaryOperator>>(value);
		}

		public gameinteractionsCFunctorDefinition()
		{
			Predicate = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
