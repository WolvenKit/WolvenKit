using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGenericNotificationReceiverGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("ItemChanged")] 
		public inkEmptyCallback ItemChanged
		{
			get => GetPropertyValue<inkEmptyCallback>();
			set => SetPropertyValue<inkEmptyCallback>(value);
		}

		public gameuiGenericNotificationReceiverGameController()
		{
			ItemChanged = new inkEmptyCallback();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
