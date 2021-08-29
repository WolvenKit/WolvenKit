using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponTransition : DefaultTransition
	{
		private TweakDBID _magazineID;
		private TweakDBID _magazineAttack;
		private CHandle<gamedataRangedAttackPackage_Record> _rangedAttackPackage;

		[Ordinal(0)] 
		[RED("magazineID")] 
		public TweakDBID MagazineID
		{
			get => GetProperty(ref _magazineID);
			set => SetProperty(ref _magazineID, value);
		}

		[Ordinal(1)] 
		[RED("magazineAttack")] 
		public TweakDBID MagazineAttack
		{
			get => GetProperty(ref _magazineAttack);
			set => SetProperty(ref _magazineAttack, value);
		}

		[Ordinal(2)] 
		[RED("rangedAttackPackage")] 
		public CHandle<gamedataRangedAttackPackage_Record> RangedAttackPackage
		{
			get => GetProperty(ref _rangedAttackPackage);
			set => SetProperty(ref _rangedAttackPackage, value);
		}
	}
}
