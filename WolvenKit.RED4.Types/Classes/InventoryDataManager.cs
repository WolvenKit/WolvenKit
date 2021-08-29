using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryDataManager : IScriptable
	{
		private ScriptGameInstance _gameInstance;
		private CWeakHandle<PlayerPuppet> _player;
		private CWeakHandle<gameTransactionSystem> _transactionSystem;
		private CWeakHandle<EquipmentSystem> _equipmentSystem;
		private CWeakHandle<gameStatsSystem> _statsSystem;
		private CHandle<UILocalizationMap> _locMgr;

		[Ordinal(0)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(2)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(3)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(4)] 
		[RED("statsSystem")] 
		public CWeakHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(5)] 
		[RED("locMgr")] 
		public CHandle<UILocalizationMap> LocMgr
		{
			get => GetProperty(ref _locMgr);
			set => SetProperty(ref _locMgr, value);
		}
	}
}
