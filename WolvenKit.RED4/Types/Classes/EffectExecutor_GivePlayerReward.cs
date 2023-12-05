using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectExecutor_GivePlayerReward : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("reward")] 
		public TweakDBID Reward
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public EffectExecutor_GivePlayerReward()
		{
			Amount = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
