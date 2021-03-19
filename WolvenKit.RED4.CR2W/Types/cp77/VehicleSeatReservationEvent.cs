using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleSeatReservationEvent : redEvent
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

		public VehicleSeatReservationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
