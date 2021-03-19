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
			get => GetProperty(ref _chosenItem);
			set => SetProperty(ref _chosenItem, value);
		}

		[Ordinal(1)] 
		[RED("WasUsed")] 
		public CBool WasUsed
		{
			get => GetProperty(ref _wasUsed);
			set => SetProperty(ref _wasUsed, value);
		}

		[Ordinal(2)] 
		[RED("WasAssignedToSlot")] 
		public CBool WasAssignedToSlot
		{
			get => GetProperty(ref _wasAssignedToSlot);
			set => SetProperty(ref _wasAssignedToSlot, value);
		}

		[Ordinal(3)] 
		[RED("WheelDirection")] 
		public CEnum<EDPadSlot> WheelDirection
		{
			get => GetProperty(ref _wheelDirection);
			set => SetProperty(ref _wheelDirection, value);
		}

		public QuickWheelEndUIStructure(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
