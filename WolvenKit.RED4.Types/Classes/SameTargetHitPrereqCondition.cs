using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SameTargetHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("previousTarget")] 
		public CWeakHandle<gameObject> PreviousTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("previousSource")] 
		public CWeakHandle<gameObject> PreviousSource
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("previousWeapon")] 
		public CWeakHandle<gameweaponObject> PreviousWeapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}
	}
}
