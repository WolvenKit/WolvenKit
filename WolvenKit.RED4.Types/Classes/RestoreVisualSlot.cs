using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RestoreVisualSlot : redEvent
	{
		[Ordinal(0)] 
		[RED("slot")] 
		public CEnum<TransmogSlots> Slot
		{
			get => GetPropertyValue<CEnum<TransmogSlots>>();
			set => SetPropertyValue<CEnum<TransmogSlots>>(value);
		}

		public RestoreVisualSlot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
