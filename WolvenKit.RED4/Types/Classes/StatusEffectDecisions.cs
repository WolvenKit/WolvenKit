using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatusEffectDecisions : LocomotionGroundDecisions
	{
		[Ordinal(3)] 
		[RED("executionOwner")] 
		public CWeakHandle<gameObject> ExecutionOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>();
			set => SetPropertyValue<CHandle<DefaultTransitionStatusEffectListener>>(value);
		}

		[Ordinal(5)] 
		[RED("statusEffectEnumName")] 
		public CString StatusEffectEnumName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public StatusEffectDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
