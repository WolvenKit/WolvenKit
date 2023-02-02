using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIMenuNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public UIMenuNotificationQueue()
		{
			Duration = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
