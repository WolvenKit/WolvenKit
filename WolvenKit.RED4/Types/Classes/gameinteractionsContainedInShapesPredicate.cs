using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsContainedInShapesPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)] 
		[RED("useCameraPosition")] 
		public CBool UseCameraPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameinteractionsContainedInShapesPredicate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
