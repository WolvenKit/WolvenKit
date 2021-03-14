using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickWheelStartUIStructure : CVariable
	{
		private CArray<QuickSlotCommand> _wheelItems;
		private CEnum<EDPadSlot> _dpadSlot;

		[Ordinal(0)] 
		[RED("WheelItems")] 
		public CArray<QuickSlotCommand> WheelItems
		{
			get
			{
				if (_wheelItems == null)
				{
					_wheelItems = (CArray<QuickSlotCommand>) CR2WTypeManager.Create("array:QuickSlotCommand", "WheelItems", cr2w, this);
				}
				return _wheelItems;
			}
			set
			{
				if (_wheelItems == value)
				{
					return;
				}
				_wheelItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("dpadSlot")] 
		public CEnum<EDPadSlot> DpadSlot
		{
			get
			{
				if (_dpadSlot == null)
				{
					_dpadSlot = (CEnum<EDPadSlot>) CR2WTypeManager.Create("EDPadSlot", "dpadSlot", cr2w, this);
				}
				return _dpadSlot;
			}
			set
			{
				if (_dpadSlot == value)
				{
					return;
				}
				_dpadSlot = value;
				PropertySet(this);
			}
		}

		public QuickWheelStartUIStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
