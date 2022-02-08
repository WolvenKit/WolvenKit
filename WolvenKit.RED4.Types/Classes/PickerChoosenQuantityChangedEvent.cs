using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PickerChoosenQuantityChangedEvent : inkGameNotificationData
	{
		[Ordinal(6)] 
		[RED("choosenQuantity")] 
		public CInt32 ChoosenQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
