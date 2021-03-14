using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInventoryState : CVariable
	{
		private CArray<gameMuppetInventorySlotInfo> _slots;
		private CInt32 _activeSlot;

		[Ordinal(0)] 
		[RED("slots")] 
		public CArray<gameMuppetInventorySlotInfo> Slots
		{
			get
			{
				if (_slots == null)
				{
					_slots = (CArray<gameMuppetInventorySlotInfo>) CR2WTypeManager.Create("array:gameMuppetInventorySlotInfo", "slots", cr2w, this);
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

		[Ordinal(1)] 
		[RED("activeSlot")] 
		public CInt32 ActiveSlot
		{
			get
			{
				if (_activeSlot == null)
				{
					_activeSlot = (CInt32) CR2WTypeManager.Create("Int32", "activeSlot", cr2w, this);
				}
				return _activeSlot;
			}
			set
			{
				if (_activeSlot == value)
				{
					return;
				}
				_activeSlot = value;
				PropertySet(this);
			}
		}

		public gameMuppetInventoryState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
