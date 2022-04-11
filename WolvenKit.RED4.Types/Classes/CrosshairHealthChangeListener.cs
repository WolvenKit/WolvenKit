using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairHealthChangeListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("parentCrosshair")] 
		public CWeakHandle<gameuiCrosshairBaseGameController> ParentCrosshair
		{
			get => GetPropertyValue<CWeakHandle<gameuiCrosshairBaseGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiCrosshairBaseGameController>>(value);
		}
	}
}
