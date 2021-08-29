using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRewardEvent : redEvent
	{
		private TweakDBID _rewardName;

		[Ordinal(0)] 
		[RED("rewardName")] 
		public TweakDBID RewardName
		{
			get => GetProperty(ref _rewardName);
			set => SetProperty(ref _rewardName, value);
		}
	}
}
