using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_GraphSlotConditions : animAnimNode_GraphSlot
	{
		[Ordinal(14)] 
		[RED("conditions")] 
		public CArray<animGraphSlotCondition> Conditions
		{
			get => GetPropertyValue<CArray<animGraphSlotCondition>>();
			set => SetPropertyValue<CArray<animGraphSlotCondition>>(value);
		}

		public animAnimNode_GraphSlotConditions()
		{
			Conditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
