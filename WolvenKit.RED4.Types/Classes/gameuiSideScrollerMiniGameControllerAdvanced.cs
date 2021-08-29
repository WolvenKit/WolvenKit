using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSideScrollerMiniGameControllerAdvanced : gameuiWidgetGameController
	{
		private inkWidgetReference _gameplayCanvas;

		[Ordinal(2)] 
		[RED("gameplayCanvas")] 
		public inkWidgetReference GameplayCanvas
		{
			get => GetProperty(ref _gameplayCanvas);
			set => SetProperty(ref _gameplayCanvas, value);
		}
	}
}
