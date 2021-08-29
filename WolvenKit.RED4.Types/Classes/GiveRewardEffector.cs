using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GiveRewardEffector : gameEffector
	{
		private TweakDBID _reward;
		private entEntityID _target;

		[Ordinal(0)] 
		[RED("reward")] 
		public TweakDBID Reward
		{
			get => GetProperty(ref _reward);
			set => SetProperty(ref _reward, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public entEntityID Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}
	}
}
