using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CreditsData : inkUserData
	{
		private CBool _isFinalBoards;
		private CBool _showRewardPrompt;

		[Ordinal(0)] 
		[RED("isFinalBoards")] 
		public CBool IsFinalBoards
		{
			get => GetProperty(ref _isFinalBoards);
			set => SetProperty(ref _isFinalBoards, value);
		}

		[Ordinal(1)] 
		[RED("showRewardPrompt")] 
		public CBool ShowRewardPrompt
		{
			get => GetProperty(ref _showRewardPrompt);
			set => SetProperty(ref _showRewardPrompt, value);
		}
	}
}
