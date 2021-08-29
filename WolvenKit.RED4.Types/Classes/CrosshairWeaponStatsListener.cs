using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairWeaponStatsListener : gameScriptStatsListener
	{
		private CWeakHandle<BaseTechCrosshairController> _controller;

		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<BaseTechCrosshairController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}
	}
}
