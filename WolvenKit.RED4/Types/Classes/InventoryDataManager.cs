using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryDataManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(2)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(3)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(4)] 
		[RED("statsSystem")] 
		public CWeakHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CWeakHandle<gameStatsSystem>>();
			set => SetPropertyValue<CWeakHandle<gameStatsSystem>>(value);
		}

		[Ordinal(5)] 
		[RED("locMgr")] 
		public CHandle<UILocalizationMap> LocMgr
		{
			get => GetPropertyValue<CHandle<UILocalizationMap>>();
			set => SetPropertyValue<CHandle<UILocalizationMap>>(value);
		}

		public InventoryDataManager()
		{
			GameInstance = new ScriptGameInstance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
