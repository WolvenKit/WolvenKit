using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScoreboardPlayer : CVariable
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

		public ScoreboardPlayer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
