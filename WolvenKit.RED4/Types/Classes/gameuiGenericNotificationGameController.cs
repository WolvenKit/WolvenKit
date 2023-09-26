using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGenericNotificationGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("notificationsRoot")] 
		public inkCompoundWidgetReference NotificationsRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("exclusiveProcessing")] 
		public CBool ExclusiveProcessing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiGenericNotificationGameController()
		{
			NotificationsRoot = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
