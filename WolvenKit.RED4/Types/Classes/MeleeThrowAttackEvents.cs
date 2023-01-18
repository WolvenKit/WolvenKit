using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeThrowAttackEvents : MeleeAttackGenericEvents
	{
		[Ordinal(9)] 
		[RED("projectileThrown")] 
		public CBool ProjectileThrown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("targetObject")] 
		public CWeakHandle<gameObject> TargetObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public MeleeThrowAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
