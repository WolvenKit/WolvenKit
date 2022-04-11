using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TransferSaveGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("notificationController")] 
		public inkWidgetReference NotificationController
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public TransferSaveGameController()
		{
			NotificationController = new();
		}
	}
}
