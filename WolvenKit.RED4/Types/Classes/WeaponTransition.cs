using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponTransition : DefaultTransition
	{
		[Ordinal(0)] 
		[RED("magazineID")] 
		public TweakDBID MagazineID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("magazineAttack")] 
		public TweakDBID MagazineAttack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("rangedAttackPackage")] 
		public CHandle<gamedataRangedAttackPackage_Record> RangedAttackPackage
		{
			get => GetPropertyValue<CHandle<gamedataRangedAttackPackage_Record>>();
			set => SetPropertyValue<CHandle<gamedataRangedAttackPackage_Record>>(value);
		}

		public WeaponTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
