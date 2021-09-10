using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReleaseSlotEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public CInt32 SlotID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
