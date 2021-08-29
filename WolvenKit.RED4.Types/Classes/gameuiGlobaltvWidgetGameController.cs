using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiGlobaltvWidgetGameController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _overlayContainer;

		[Ordinal(2)] 
		[RED("overlayContainer")] 
		public inkCompoundWidgetReference OverlayContainer
		{
			get => GetProperty(ref _overlayContainer);
			set => SetProperty(ref _overlayContainer, value);
		}
	}
}
