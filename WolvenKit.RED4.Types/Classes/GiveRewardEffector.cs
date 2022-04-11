using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Target = new();
		}
	}
}
