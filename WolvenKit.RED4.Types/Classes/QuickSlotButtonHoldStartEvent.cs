using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotButtonHoldStartEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("dPadItemDirection")] 
		public CEnum<EDPadSlot> DPadItemDirection
		{
			get => GetPropertyValue<CEnum<EDPadSlot>>();
			set => SetPropertyValue<CEnum<EDPadSlot>>(value);
		}
	}
}
