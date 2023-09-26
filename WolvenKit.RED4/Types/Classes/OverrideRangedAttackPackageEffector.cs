using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OverrideRangedAttackPackageEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("attackPackage")] 
		public CHandle<gamedataRangedAttackPackage_Record> AttackPackage
		{
			get => GetPropertyValue<CHandle<gamedataRangedAttackPackage_Record>>();
			set => SetPropertyValue<CHandle<gamedataRangedAttackPackage_Record>>(value);
		}

		public OverrideRangedAttackPackageEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
