using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JukeboxBigGameController : DeviceInkGameControllerBase
	{
		private CHandle<redCallbackObject> _onTogglePlayListener;

		[Ordinal(16)] 
		[RED("onTogglePlayListener")] 
		public CHandle<redCallbackObject> OnTogglePlayListener
		{
			get => GetProperty(ref _onTogglePlayListener);
			set => SetProperty(ref _onTogglePlayListener, value);
		}
	}
}
