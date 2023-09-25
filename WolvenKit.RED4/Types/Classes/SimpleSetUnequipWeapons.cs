using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleSetUnequipWeapons : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("puppet")] 
		public CWeakHandle<ScriptedPuppet> Puppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(2)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(3)] 
		[RED("primaryItems")] 
		public CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>> PrimaryItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>>>(value);
		}

		[Ordinal(4)] 
		[RED("secondaryItems")] 
		public CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>> SecondaryItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>>>(value);
		}

		[Ordinal(5)] 
		[RED("secondaryEquipmentDuplicatesPrimary")] 
		public CBool SecondaryEquipmentDuplicatesPrimary
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SimpleSetUnequipWeapons()
		{
			Game = new ScriptGameInstance();
			PrimaryItems = new();
			SecondaryItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
