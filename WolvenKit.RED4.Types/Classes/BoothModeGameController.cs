using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BoothModeGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _buttonRef;

		[Ordinal(2)] 
		[RED("buttonRef")] 
		public inkWidgetReference ButtonRef
		{
			get => GetProperty(ref _buttonRef);
			set => SetProperty(ref _buttonRef, value);
		}
	}
}
