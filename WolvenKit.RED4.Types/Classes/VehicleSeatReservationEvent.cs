using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleSeatReservationEvent : redEvent
	{
		private CName _slotID;
		private CBool _reserve;

		[Ordinal(0)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("reserve")] 
		public CBool Reserve
		{
			get => GetProperty(ref _reserve);
			set => SetProperty(ref _reserve, value);
		}
	}
}
