using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsHoldEvents : QuickSlotsEvents
	{
		private CEnum<EDPadSlot> _holdDirection;

		[Ordinal(0)] 
		[RED("holdDirection")] 
		public CEnum<EDPadSlot> HoldDirection
		{
			get
			{
				if (_holdDirection == null)
				{
					_holdDirection = (CEnum<EDPadSlot>) CR2WTypeManager.Create("EDPadSlot", "holdDirection", cr2w, this);
				}
				return _holdDirection;
			}
			set
			{
				if (_holdDirection == value)
				{
					return;
				}
				_holdDirection = value;
				PropertySet(this);
			}
		}

		public QuickSlotsHoldEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
