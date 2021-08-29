using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChangeRewardSettingsEvent : redEvent
	{
		private CBool _forceDefeatReward;
		private CBool _disableKillReward;

		[Ordinal(0)] 
		[RED("forceDefeatReward")] 
		public CBool ForceDefeatReward
		{
			get => GetProperty(ref _forceDefeatReward);
			set => SetProperty(ref _forceDefeatReward, value);
		}

		[Ordinal(1)] 
		[RED("disableKillReward")] 
		public CBool DisableKillReward
		{
			get => GetProperty(ref _disableKillReward);
			set => SetProperty(ref _disableKillReward, value);
		}
	}
}
