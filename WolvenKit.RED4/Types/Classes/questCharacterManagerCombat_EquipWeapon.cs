using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerCombat_EquipWeapon : questICharacterManagerCombat_NodeSubType
	{
		[Ordinal(0)] 
		[RED("equip")] 
		public CBool Equip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("weaponID")] 
		public TweakDBID WeaponID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("equipLastWeapon")] 
		public CBool EquipLastWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("forceFirstEquip")] 
		public CBool ForceFirstEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("ignoreStateMachine")] 
		public CBool IgnoreStateMachine
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCharacterManagerCombat_EquipWeapon()
		{
			Equip = true;
			WeaponID = 71614763877;
			SlotID = "AttachmentSlots.WeaponRight";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
