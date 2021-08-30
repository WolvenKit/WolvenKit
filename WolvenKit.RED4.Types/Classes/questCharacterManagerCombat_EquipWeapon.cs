using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerCombat_EquipWeapon : questICharacterManagerCombat_NodeSubType
	{
		private CBool _equip;
		private TweakDBID _weaponID;
		private TweakDBID _slotID;
		private CBool _equipLastWeapon;
		private CBool _forceFirstEquip;
		private CBool _instant;
		private CBool _ignoreStateMachine;

		[Ordinal(0)] 
		[RED("equip")] 
		public CBool Equip
		{
			get => GetProperty(ref _equip);
			set => SetProperty(ref _equip, value);
		}

		[Ordinal(1)] 
		[RED("weaponID")] 
		public TweakDBID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(2)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(3)] 
		[RED("equipLastWeapon")] 
		public CBool EquipLastWeapon
		{
			get => GetProperty(ref _equipLastWeapon);
			set => SetProperty(ref _equipLastWeapon, value);
		}

		[Ordinal(4)] 
		[RED("forceFirstEquip")] 
		public CBool ForceFirstEquip
		{
			get => GetProperty(ref _forceFirstEquip);
			set => SetProperty(ref _forceFirstEquip, value);
		}

		[Ordinal(5)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		[Ordinal(6)] 
		[RED("ignoreStateMachine")] 
		public CBool IgnoreStateMachine
		{
			get => GetProperty(ref _ignoreStateMachine);
			set => SetProperty(ref _ignoreStateMachine, value);
		}

		public questCharacterManagerCombat_EquipWeapon()
		{
			_equip = true;
			_weaponID = new() { Value = 71614763877 };
			_slotID = new() { Value = 118070326407 };
		}
	}
}
