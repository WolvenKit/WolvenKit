using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReleaseSlotEvent : redEvent
	{
		private CInt32 _slotID;

		[Ordinal(0)] 
		[RED("slotID")] 
		public CInt32 SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}
	}
}
