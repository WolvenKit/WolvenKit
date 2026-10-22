using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickMeleeEvents : WeaponEventsTransition
	{
		[Ordinal(6)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(7)] 
		[RED("targetObject")] 
		public CWeakHandle<gameObject> TargetObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(8)] 
		[RED("targetComponent")] 
		public CHandle<entIPlacedComponent> TargetComponent
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(9)] 
		[RED("quickMeleeAttackCreated")] 
		public CBool QuickMeleeAttackCreated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("quickMeleeAttackData")] 
		public QuickMeleeAttackData QuickMeleeAttackData
		{
			get => GetPropertyValue<QuickMeleeAttackData>();
			set => SetPropertyValue<QuickMeleeAttackData>(value);
		}

		public QuickMeleeEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();
			QuickMeleeAttackData = new QuickMeleeAttackData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
