using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyObjectActionEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("triggered")] 
		public CBool Triggered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ApplyObjectActionEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
