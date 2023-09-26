using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PersistentDotSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<CrosshairGameControllerPersistentDot> Controller
		{
			get => GetPropertyValue<CWeakHandle<CrosshairGameControllerPersistentDot>>();
			set => SetPropertyValue<CWeakHandle<CrosshairGameControllerPersistentDot>>(value);
		}

		public PersistentDotSettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
