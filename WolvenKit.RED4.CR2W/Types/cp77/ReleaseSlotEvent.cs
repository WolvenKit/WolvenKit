using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReleaseSlotEvent : redEvent
	{
		private CInt32 _slotID;

		[Ordinal(0)] 
		[RED("slotID")] 
		public CInt32 SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (CInt32) CR2WTypeManager.Create("Int32", "slotID", cr2w, this);
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

		public ReleaseSlotEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
