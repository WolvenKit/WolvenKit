using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTargetShootComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("weaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> WeaponRecord
		{
			get => GetPropertyValue<CHandle<gamedataWeaponItem_Record>>();
			set => SetPropertyValue<CHandle<gamedataWeaponItem_Record>>(value);
		}

		[Ordinal(4)] 
		[RED("weaponTDBID")] 
		public TweakDBID WeaponTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("characterRecord")] 
		public CHandle<gamedataCharacter_Record> CharacterRecord
		{
			get => GetPropertyValue<CHandle<gamedataCharacter_Record>>();
			set => SetPropertyValue<CHandle<gamedataCharacter_Record>>(value);
		}

		[Ordinal(6)] 
		[RED("characterTDBID")] 
		public TweakDBID CharacterTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameTargetShootComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
