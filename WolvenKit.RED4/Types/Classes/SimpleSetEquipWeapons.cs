using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleSetEquipWeapons : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("primary")] 
		public CBool Primary
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("secondary")] 
		public CBool Secondary
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("puppet")] 
		public CWeakHandle<ScriptedPuppet> Puppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(3)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(4)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(5)] 
		[RED("primaryItems")] 
		public CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>> PrimaryItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>>>(value);
		}

		[Ordinal(6)] 
		[RED("secondaryItems")] 
		public CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>> SecondaryItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataNPCEquipmentItem_Record>>>(value);
		}

		[Ordinal(7)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SimpleSetEquipWeapons()
		{
			Primary = true;
			Secondary = true;
			Game = new();
			PrimaryItems = new();
			SecondaryItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
