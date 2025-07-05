using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HideVisualSlot : redEvent
	{
		[Ordinal(0)] 
		[RED("slot")] 
		public CEnum<TransmogSlots> Slot
		{
			get => GetPropertyValue<CEnum<TransmogSlots>>();
			set => SetPropertyValue<CEnum<TransmogSlots>>(value);
		}

		public HideVisualSlot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
