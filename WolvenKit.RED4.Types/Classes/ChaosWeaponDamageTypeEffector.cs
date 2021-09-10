using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
