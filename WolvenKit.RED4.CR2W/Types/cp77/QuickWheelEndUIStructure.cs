using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickWheelEndUIStructure : CVariable
	{
		private QuickSlotCommand _chosenItem;
		private CBool _wasUsed;
		private CBool _wasAssignedToSlot;
		private CEnum<EDPadSlot> _wheelDirection;

		[Ordinal(0)] 
		[RED("ChosenItem")] 
		public QuickSlotCommand ChosenItem
		{
			get
			{
				if (_chosenItem == null)
				{
					_chosenItem = (QuickSlotCommand) CR2WTypeManager.Create("QuickSlotCommand", "ChosenItem", cr2w, this);
				}
				return _chosenItem;
			}
			set
			{
				if (_chosenItem == value)
				{
					return;
				}
				_chosenItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("WasUsed")] 
		public CBool WasUsed
		{
			get
			{
				if (_wasUsed == null)
				{
					_wasUsed = (CBool) CR2WTypeManager.Create("Bool", "WasUsed", cr2w, this);
				}
				return _wasUsed;
			}
			set
			{
				if (_wasUsed == value)
				{
					return;
				}
				_wasUsed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("WasAssignedToSlot")] 
		public CBool WasAssignedToSlot
		{
			get
			{
				if (_wasAssignedToSlot == null)
				{
					_wasAssignedToSlot = (CBool) CR2WTypeManager.Create("Bool", "WasAssignedToSlot", cr2w, this);
				}
				return _wasAssignedToSlot;
			}
			set
			{
				if (_wasAssignedToSlot == value)
				{
					return;
				}
				_wasAssignedToSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("WheelDirection")] 
		public CEnum<EDPadSlot> WheelDirection
		{
			get
			{
				if (_wheelDirection == null)
				{
					_wheelDirection = (CEnum<EDPadSlot>) CR2WTypeManager.Create("EDPadSlot", "WheelDirection", cr2w, this);
				}
				return _wheelDirection;
			}
			set
			{
				if (_wheelDirection == value)
				{
					return;
				}
				_wheelDirection = value;
				PropertySet(this);
			}
		}

		public QuickWheelEndUIStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
