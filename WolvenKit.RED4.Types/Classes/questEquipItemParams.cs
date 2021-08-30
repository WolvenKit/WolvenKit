using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEquipItemParams : questAICommandParams
	{
		private TweakDBID _slotId;
		private CEnum<questNodeType> _type;
		private TweakDBID _itemId;
		private CFloat _equipDurationOverride;
		private CFloat _unequipDurationOverride;
		private CBool _failIfItemNotFound;
		private CBool _instant;
		private CBool _equipLastWeapon;
		private CBool _forceFirstEquip;
		private CBool _ignoreStateMachine;
		private CBool _isPlayer;
		private CEnum<gameItemEquipContexts> _equipTypes;
		private CEnum<gameItemUnequipContexts> _unequipTypes;
		private CBool _byItem;

		[Ordinal(0)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<questNodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("itemId")] 
		public TweakDBID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(3)] 
		[RED("equipDurationOverride")] 
		public CFloat EquipDurationOverride
		{
			get => GetProperty(ref _equipDurationOverride);
			set => SetProperty(ref _equipDurationOverride, value);
		}

		[Ordinal(4)] 
		[RED("unequipDurationOverride")] 
		public CFloat UnequipDurationOverride
		{
			get => GetProperty(ref _unequipDurationOverride);
			set => SetProperty(ref _unequipDurationOverride, value);
		}

		[Ordinal(5)] 
		[RED("failIfItemNotFound")] 
		public CBool FailIfItemNotFound
		{
			get => GetProperty(ref _failIfItemNotFound);
			set => SetProperty(ref _failIfItemNotFound, value);
		}

		[Ordinal(6)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		[Ordinal(7)] 
		[RED("equipLastWeapon")] 
		public CBool EquipLastWeapon
		{
			get => GetProperty(ref _equipLastWeapon);
			set => SetProperty(ref _equipLastWeapon, value);
		}

		[Ordinal(8)] 
		[RED("forceFirstEquip")] 
		public CBool ForceFirstEquip
		{
			get => GetProperty(ref _forceFirstEquip);
			set => SetProperty(ref _forceFirstEquip, value);
		}

		[Ordinal(9)] 
		[RED("ignoreStateMachine")] 
		public CBool IgnoreStateMachine
		{
			get => GetProperty(ref _ignoreStateMachine);
			set => SetProperty(ref _ignoreStateMachine, value);
		}

		[Ordinal(10)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(11)] 
		[RED("equipTypes")] 
		public CEnum<gameItemEquipContexts> EquipTypes
		{
			get => GetProperty(ref _equipTypes);
			set => SetProperty(ref _equipTypes, value);
		}

		[Ordinal(12)] 
		[RED("unequipTypes")] 
		public CEnum<gameItemUnequipContexts> UnequipTypes
		{
			get => GetProperty(ref _unequipTypes);
			set => SetProperty(ref _unequipTypes, value);
		}

		[Ordinal(13)] 
		[RED("byItem")] 
		public CBool ByItem
		{
			get => GetProperty(ref _byItem);
			set => SetProperty(ref _byItem, value);
		}

		public questEquipItemParams()
		{
			_equipDurationOverride = -1.000000F;
			_unequipDurationOverride = -1.000000F;
			_isPlayer = true;
			_unequipTypes = new() { Value = Enums.gameItemUnequipContexts.AllItems };
		}
	}
}
