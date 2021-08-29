using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiStealthIndicatorGameController : gameuiHUDGameController
	{
		private CWeakHandle<inkCompoundWidget> _rootWidget;

		[Ordinal(9)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}
	}
}
