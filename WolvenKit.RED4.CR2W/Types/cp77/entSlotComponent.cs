using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entSlotComponent : entIPlacedComponent
	{
		private CArray<entSlot> _slots;
		private CArray<entFallbackSlot> _fallbackSlots;

		[Ordinal(5)] 
		[RED("slots")] 
		public CArray<entSlot> Slots
		{
			get
			{
				if (_slots == null)
				{
					_slots = (CArray<entSlot>) CR2WTypeManager.Create("array:entSlot", "slots", cr2w, this);
				}
				return _slots;
			}
			set
			{
				if (_slots == value)
				{
					return;
				}
				_slots = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("fallbackSlots")] 
		public CArray<entFallbackSlot> FallbackSlots
		{
			get
			{
				if (_fallbackSlots == null)
				{
					_fallbackSlots = (CArray<entFallbackSlot>) CR2WTypeManager.Create("array:entFallbackSlot", "fallbackSlots", cr2w, this);
				}
				return _fallbackSlots;
			}
			set
			{
				if (_fallbackSlots == value)
				{
					return;
				}
				_fallbackSlots = value;
				PropertySet(this);
			}
		}

		public entSlotComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
