using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DoorInkGameController : DeviceInkGameControllerBase
	{
		private CWeakHandle<inkTextWidget> _doorStaturTextWidget;

		[Ordinal(16)] 
		[RED("doorStaturTextWidget")] 
		public CWeakHandle<inkTextWidget> DoorStaturTextWidget
		{
			get => GetProperty(ref _doorStaturTextWidget);
			set => SetProperty(ref _doorStaturTextWidget, value);
		}
	}
}
