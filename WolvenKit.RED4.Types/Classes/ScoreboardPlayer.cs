using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScoreboardPlayer : RedBaseClass
	{
		private CString _playerName;
		private CInt32 _playerScore;

		[Ordinal(0)] 
		[RED("playerName")] 
		public CString PlayerName
		{
			get => GetProperty(ref _playerName);
			set => SetProperty(ref _playerName, value);
		}

		[Ordinal(1)] 
		[RED("playerScore")] 
		public CInt32 PlayerScore
		{
			get => GetProperty(ref _playerScore);
			set => SetProperty(ref _playerScore, value);
		}
	}
}
