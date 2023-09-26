using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponEvolutionHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("weaponEvolution")] 
		public CEnum<gamedataWeaponEvolution> WeaponEvolution
		{
			get => GetPropertyValue<CEnum<gamedataWeaponEvolution>>();
			set => SetPropertyValue<CEnum<gamedataWeaponEvolution>>(value);
		}

		public WeaponEvolutionHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
