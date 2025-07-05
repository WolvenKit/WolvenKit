using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickSlotButtonHoldStartEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("dPadItemDirection")] 
		public CEnum<EDPadSlot> DPadItemDirection
		{
			get => GetPropertyValue<CEnum<EDPadSlot>>();
			set => SetPropertyValue<CEnum<EDPadSlot>>(value);
		}

		public QuickSlotButtonHoldStartEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
