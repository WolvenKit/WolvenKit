using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RoachRaceGameController : gameuiSideScrollerMiniGameController
	{
		private inkWidgetReference _gameMenu;
		private inkWidgetReference _scoreboardMenu;
		private CBool _isCutsceneInProgress;

		[Ordinal(4)] 
		[RED("gameMenu")] 
		public inkWidgetReference GameMenu
		{
			get => GetProperty(ref _gameMenu);
			set => SetProperty(ref _gameMenu, value);
		}

		[Ordinal(5)] 
		[RED("scoreboardMenu")] 
		public inkWidgetReference ScoreboardMenu
		{
			get => GetProperty(ref _scoreboardMenu);
			set => SetProperty(ref _scoreboardMenu, value);
		}

		[Ordinal(6)] 
		[RED("isCutsceneInProgress")] 
		public CBool IsCutsceneInProgress
		{
			get => GetProperty(ref _isCutsceneInProgress);
			set => SetProperty(ref _isCutsceneInProgress, value);
		}
	}
}
