using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsLookAtPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)] 
		[RED("testTarget")] 
		public CEnum<gameinteractionsELookAtTarget> TestTarget
		{
			get => GetPropertyValue<CEnum<gameinteractionsELookAtTarget>>();
			set => SetPropertyValue<CEnum<gameinteractionsELookAtTarget>>(value);
		}

		[Ordinal(1)] 
		[RED("testType")] 
		public CEnum<gameinteractionsELookAtTest> TestType
		{
			get => GetPropertyValue<CEnum<gameinteractionsELookAtTest>>();
			set => SetPropertyValue<CEnum<gameinteractionsELookAtTest>>(value);
		}

		[Ordinal(2)] 
		[RED("stopOnTransparent")] 
		public CBool StopOnTransparent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameinteractionsLookAtPredicate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
