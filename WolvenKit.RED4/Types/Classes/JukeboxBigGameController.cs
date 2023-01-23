using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JukeboxBigGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("onTogglePlayListener")] 
		public CHandle<redCallbackObject> OnTogglePlayListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public JukeboxBigGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
