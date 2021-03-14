using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameOccupantSlotComponent : entSlotComponent
	{
		private CArray<gameOccupantSlotData> _slotData;

		[Ordinal(7)] 
		[RED("slotData")] 
		public CArray<gameOccupantSlotData> SlotData
		{
			get
			{
				if (_slotData == null)
				{
					_slotData = (CArray<gameOccupantSlotData>) CR2WTypeManager.Create("array:gameOccupantSlotData", "slotData", cr2w, this);
				}
				return _slotData;
			}
			set
			{
				if (_slotData == value)
				{
					return;
				}
				_slotData = value;
				PropertySet(this);
			}
		}

		public gameOccupantSlotComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
