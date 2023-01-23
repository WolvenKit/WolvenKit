using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeHitEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("isStrongAttack")] 
		public CBool IsStrongAttack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("hitBlocked")] 
		public CBool HitBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MeleeHitEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
