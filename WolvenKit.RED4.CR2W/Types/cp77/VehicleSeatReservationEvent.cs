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
			get
			{
				if (_slotID == null)
				{
					_slotID = (CName) CR2WTypeManager.Create("CName", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("reserve")] 
		public CBool Reserve
		{
			get
			{
				if (_reserve == null)
				{
					_reserve = (CBool) CR2WTypeManager.Create("Bool", "reserve", cr2w, this);
				}
				return _reserve;
			}
			set
			{
				if (_reserve == value)
				{
					return;
				}
				_reserve = value;
				PropertySet(this);
			}
		}

		public VehicleSeatReservationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
