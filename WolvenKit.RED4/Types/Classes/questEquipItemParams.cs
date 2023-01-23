using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEquipItemParams : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<questNodeType> Type
		{
			get => GetPropertyValue<CEnum<questNodeType>>();
			set => SetPropertyValue<CEnum<questNodeType>>(value);
		}

		[Ordinal(2)] 
		[RED("itemId")] 
		public TweakDBID ItemId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("equipDurationOverride")] 
		public CFloat EquipDurationOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("unequipDurationOverride")] 
		public CFloat UnequipDurationOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("failIfItemNotFound")] 
		public CBool FailIfItemNotFound
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("equipLastWeapon")] 
		public CBool EquipLastWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("forceFirstEquip")] 
		public CBool ForceFirstEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("ignoreStateMachine")] 
		public CBool IgnoreStateMachine
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("equipTypes")] 
		public CEnum<gameItemEquipContexts> EquipTypes
		{
			get => GetPropertyValue<CEnum<gameItemEquipContexts>>();
			set => SetPropertyValue<CEnum<gameItemEquipContexts>>(value);
		}

		[Ordinal(12)] 
		[RED("unequipTypes")] 
		public CEnum<gameItemUnequipContexts> UnequipTypes
		{
			get => GetPropertyValue<CEnum<gameItemUnequipContexts>>();
			set => SetPropertyValue<CEnum<gameItemUnequipContexts>>(value);
		}

		[Ordinal(13)] 
		[RED("byItem")] 
		public CBool ByItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questEquipItemParams()
		{
			EquipDurationOverride = -1.000000F;
			UnequipDurationOverride = -1.000000F;
			IsPlayer = true;
			UnequipTypes = Enums.gameItemUnequipContexts.AllItems;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
