using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChargebarStatsListener : gameScriptStatsListener
	{
		private CWeakHandle<ChargebarController> _controller;

		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<ChargebarController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}
	}
}
