using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuadRacerGameController : gameuiSideScrollerMiniGameController
	{
		private inkWidgetReference _gameMenu;
		private inkWidgetReference _scoreboardMenu;

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

		public QuadRacerGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
