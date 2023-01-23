using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionCondition_CompositeSimultaneous : animIAnimStateTransitionCondition
	{
		[Ordinal(0)] 
		[RED("conditions")] 
		public CArray<CHandle<animIAnimStateTransitionCondition>> Conditions
		{
			get => GetPropertyValue<CArray<CHandle<animIAnimStateTransitionCondition>>>();
			set => SetPropertyValue<CArray<CHandle<animIAnimStateTransitionCondition>>>(value);
		}

		public animAnimStateTransitionCondition_CompositeSimultaneous()
		{
			Conditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
