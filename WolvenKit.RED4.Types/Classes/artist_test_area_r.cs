using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class artist_test_area_r : gameuiHUDGameController
	{
		private CWeakHandle<inkWidget> _rootWidget;
		private CWeakHandle<inkCanvasWidget> _linesWidget;

		[Ordinal(9)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(10)] 
		[RED("linesWidget")] 
		public CWeakHandle<inkCanvasWidget> LinesWidget
		{
			get => GetProperty(ref _linesWidget);
			set => SetProperty(ref _linesWidget, value);
		}
	}
}
