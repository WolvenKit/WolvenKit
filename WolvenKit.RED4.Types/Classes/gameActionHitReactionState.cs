using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionHitReactionState : gameActionReplicatedState
	{
		private CHandle<animAnimFeature_HitReactionsData> _animFeature;

		[Ordinal(5)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature_HitReactionsData> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}
	}
}
