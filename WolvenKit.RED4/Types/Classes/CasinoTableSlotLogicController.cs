using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CasinoTableSlotLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<CasinoTableState> State
		{
			get => GetPropertyValue<CEnum<CasinoTableState>>();
			set => SetPropertyValue<CEnum<CasinoTableState>>(value);
		}

		[Ordinal(2)] 
		[RED("betData")] 
		public BetData BetData
		{
			get => GetPropertyValue<BetData>();
			set => SetPropertyValue<BetData>(value);
		}

		[Ordinal(3)] 
		[RED("spawnRequest")] 
		public CWeakHandle<inkAsyncSpawnRequest> SpawnRequest
		{
			get => GetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>();
			set => SetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>(value);
		}

		[Ordinal(4)] 
		[RED("page")] 
		public CWeakHandle<inkWidget> Page
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public CasinoTableSlotLogicController()
		{
			BetData = new BetData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
