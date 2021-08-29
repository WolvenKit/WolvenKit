using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterEquippedWeapon_ConditionType : questICharacterConditionType
	{
		private CBool _anyWeaponEquipped;
		private CString _weaponID;
		private CName _weaponTag;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("anyWeaponEquipped")] 
		public CBool AnyWeaponEquipped
		{
			get => GetProperty(ref _anyWeaponEquipped);
			set => SetProperty(ref _anyWeaponEquipped, value);
		}

		[Ordinal(1)] 
		[RED("weaponID")] 
		public CString WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(2)] 
		[RED("weaponTag")] 
		public CName WeaponTag
		{
			get => GetProperty(ref _weaponTag);
			set => SetProperty(ref _weaponTag, value);
		}

		[Ordinal(3)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}
	}
}
