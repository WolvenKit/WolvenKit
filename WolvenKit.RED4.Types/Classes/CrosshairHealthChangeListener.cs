using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairHealthChangeListener : gameCustomValueStatPoolsListener
	{
		private CWeakHandle<gameuiCrosshairBaseGameController> _parentCrosshair;

		[Ordinal(0)] 
		[RED("parentCrosshair")] 
		public CWeakHandle<gameuiCrosshairBaseGameController> ParentCrosshair
		{
			get => GetProperty(ref _parentCrosshair);
			set => SetProperty(ref _parentCrosshair, value);
		}
	}
}
