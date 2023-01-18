using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickSlotsDisabledDecisions : QuickSlotsDecisions
	{
		[Ordinal(0)] 
		[RED("executionOwner")] 
		public CWeakHandle<gameObject> ExecutionOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("hasStatusEffect")] 
		public CBool HasStatusEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuickSlotsDisabledDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
