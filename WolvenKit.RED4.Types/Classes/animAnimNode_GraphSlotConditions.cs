using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_GraphSlotConditions : animAnimNode_GraphSlot
	{
		private CArray<animGraphSlotCondition> _conditions;

		[Ordinal(14)] 
		[RED("conditions")] 
		public CArray<animGraphSlotCondition> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}
	}
}
