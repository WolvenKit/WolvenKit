using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinigameGenerationRuleScalingPrograms : gameuiMinigameGenerationRule
	{
		private CWeakHandle<gameIBlackboard> _bbNetwork;
		private CBool _isOfficerBreach;
		private CBool _isRemoteBreach;
		private CBool _isFirstAttempt;

		[Ordinal(7)] 
		[RED("bbNetwork")] 
		public CWeakHandle<gameIBlackboard> BbNetwork
		{
			get => GetProperty(ref _bbNetwork);
			set => SetProperty(ref _bbNetwork, value);
		}

		[Ordinal(8)] 
		[RED("isOfficerBreach")] 
		public CBool IsOfficerBreach
		{
			get => GetProperty(ref _isOfficerBreach);
			set => SetProperty(ref _isOfficerBreach, value);
		}

		[Ordinal(9)] 
		[RED("isRemoteBreach")] 
		public CBool IsRemoteBreach
		{
			get => GetProperty(ref _isRemoteBreach);
			set => SetProperty(ref _isRemoteBreach, value);
		}

		[Ordinal(10)] 
		[RED("isFirstAttempt")] 
		public CBool IsFirstAttempt
		{
			get => GetProperty(ref _isFirstAttempt);
			set => SetProperty(ref _isFirstAttempt, value);
		}
	}
}
