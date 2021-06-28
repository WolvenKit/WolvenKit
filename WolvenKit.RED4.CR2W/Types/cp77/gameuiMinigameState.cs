using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameState : IScriptable
	{
		private CInt32 _currentLives;
		private CInt32 _currentScore;

		[Ordinal(0)] 
		[RED("currentLives")] 
		public CInt32 CurrentLives
		{
			get => GetProperty(ref _currentLives);
			set => SetProperty(ref _currentLives, value);
		}

		[Ordinal(1)] 
		[RED("currentScore")] 
		public CInt32 CurrentScore
		{
			get => GetProperty(ref _currentScore);
			set => SetProperty(ref _currentScore, value);
		}

		public gameuiMinigameState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
