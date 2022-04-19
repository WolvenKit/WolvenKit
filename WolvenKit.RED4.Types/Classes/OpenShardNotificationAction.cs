using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpenShardNotificationAction : GenericNotificationBaseAction
	{
		[Ordinal(0)] 
		[RED("eventDispatcher")] 
		public CHandle<gameuiGameSystemUI> EventDispatcher
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		public OpenShardNotificationAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
