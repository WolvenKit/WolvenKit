using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SameTargetHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("previousTarget")] 
		public CWeakHandle<gameObject> PreviousTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("previousSource")] 
		public CWeakHandle<gameObject> PreviousSource
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(5)] 
		[RED("previousWeapon")] 
		public CWeakHandle<gameweaponObject> PreviousWeapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		public SameTargetHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
