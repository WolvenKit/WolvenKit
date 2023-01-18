using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickMeleeEvents : WeaponEventsTransition
	{
		[Ordinal(3)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(4)] 
		[RED("targetObject")] 
		public CWeakHandle<gameObject> TargetObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("targetComponent")] 
		public CHandle<entIPlacedComponent> TargetComponent
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(6)] 
		[RED("quickMeleeAttackCreated")] 
		public CBool QuickMeleeAttackCreated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("quickMeleeAttackData")] 
		public QuickMeleeAttackData QuickMeleeAttackData
		{
			get => GetPropertyValue<QuickMeleeAttackData>();
			set => SetPropertyValue<QuickMeleeAttackData>(value);
		}

		public QuickMeleeEvents()
		{
			QuickMeleeAttackData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
