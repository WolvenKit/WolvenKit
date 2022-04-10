using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickSlotsHoldEvents : QuickSlotsEvents
	{
		[Ordinal(0)] 
		[RED("holdDirection")] 
		public CEnum<EDPadSlot> HoldDirection
		{
			get => GetPropertyValue<CEnum<EDPadSlot>>();
			set => SetPropertyValue<CEnum<EDPadSlot>>(value);
		}

		public QuickSlotsHoldEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
