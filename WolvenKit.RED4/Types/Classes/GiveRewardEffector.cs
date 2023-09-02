using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GiveRewardEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("reward")] 
		public TweakDBID Reward
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public entEntityID Target
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public GiveRewardEffector()
		{
			Target = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
