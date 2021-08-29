using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IceMachineInkGameController : DeviceInkGameControllerBase
	{
		private inkWidgetReference _buttonContainer;

		[Ordinal(16)] 
		[RED("buttonContainer")] 
		public inkWidgetReference ButtonContainer
		{
			get => GetProperty(ref _buttonContainer);
			set => SetProperty(ref _buttonContainer, value);
		}
	}
}
