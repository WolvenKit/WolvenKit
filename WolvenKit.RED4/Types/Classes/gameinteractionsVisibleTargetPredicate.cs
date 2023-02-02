using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsVisibleTargetPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)] 
		[RED("stopOnTransparent")] 
		public CBool StopOnTransparent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameinteractionsVisibleTargetPredicate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
