using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotButtonHoldStartEvent : redEvent
	{
		private CEnum<EDPadSlot> _dPadItemDirection;

		[Ordinal(0)] 
		[RED("dPadItemDirection")] 
		public CEnum<EDPadSlot> DPadItemDirection
		{
			get
			{
				if (_dPadItemDirection == null)
				{
					_dPadItemDirection = (CEnum<EDPadSlot>) CR2WTypeManager.Create("EDPadSlot", "dPadItemDirection", cr2w, this);
				}
				return _dPadItemDirection;
			}
			set
			{
				if (_dPadItemDirection == value)
				{
					return;
				}
				_dPadItemDirection = value;
				PropertySet(this);
			}
		}

		public QuickSlotButtonHoldStartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
