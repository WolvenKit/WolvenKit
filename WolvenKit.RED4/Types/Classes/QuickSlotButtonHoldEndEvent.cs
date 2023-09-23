using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickSlotButtonHoldEndEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("dPadItemDirection")] 
		public CEnum<EDPadSlot> DPadItemDirection
		{
			get => GetPropertyValue<CEnum<EDPadSlot>>();
			set => SetPropertyValue<CEnum<EDPadSlot>>(value);
		}

		[Ordinal(1)] 
		[RED("rightStickAngle")] 
		public CFloat RightStickAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("tryExecuteCommand")] 
		public CBool TryExecuteCommand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickSlotButtonHoldEndEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
