using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterEquippedWeapon_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("anyWeaponEquipped")] 
		public CBool AnyWeaponEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("weaponID")] 
		public CString WeaponID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("weaponTag")] 
		public CName WeaponTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCharacterEquippedWeapon_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
