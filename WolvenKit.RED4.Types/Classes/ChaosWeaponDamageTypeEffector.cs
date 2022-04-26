using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChaosWeaponDamageTypeEffector : ChaosWeaponCustomEffector
	{
		[Ordinal(5)] 
		[RED("damageTypeModGroups")] 
		public CArray<TweakDBID> DamageTypeModGroups
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		public ChaosWeaponDamageTypeEffector()
		{
			DamageTypeModGroups = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
