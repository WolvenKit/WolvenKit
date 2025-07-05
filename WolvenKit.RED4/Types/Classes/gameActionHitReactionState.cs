using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionHitReactionState : gameActionReplicatedState
	{
		[Ordinal(5)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature_HitReactionsData> AnimFeature
		{
			get => GetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>();
			set => SetPropertyValue<CHandle<animAnimFeature_HitReactionsData>>(value);
		}

		public gameActionHitReactionState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
