using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSideScrollerMiniGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _gameplayCanvas;
		private CName _gameName;

		[Ordinal(2)] 
		[RED("gameplayCanvas")] 
		public inkWidgetReference GameplayCanvas
		{
			get => GetProperty(ref _gameplayCanvas);
			set => SetProperty(ref _gameplayCanvas, value);
		}

		[Ordinal(3)] 
		[RED("gameName")] 
		public CName GameName
		{
			get => GetProperty(ref _gameName);
			set => SetProperty(ref _gameName, value);
		}
	}
}
