using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PickerChoosenQuantityChangedEvent : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("choosenQuantity")] 
		public CInt32 ChoosenQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PickerChoosenQuantityChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
