using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChaosWeaponDamageTypeEffector : ChaosWeaponCustomEffector
	{
		private CArray<TweakDBID> _damageTypeModGroups;

		[Ordinal(5)] 
		[RED("damageTypeModGroups")] 
		public CArray<TweakDBID> DamageTypeModGroups
		{
			get => GetProperty(ref _damageTypeModGroups);
			set => SetProperty(ref _damageTypeModGroups, value);
		}
	}
}
