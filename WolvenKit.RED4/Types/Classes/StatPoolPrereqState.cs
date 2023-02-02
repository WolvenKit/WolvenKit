using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("statPoolListener")] 
		public CHandle<BaseStatPoolPrereqListener> StatPoolListener
		{
			get => GetPropertyValue<CHandle<BaseStatPoolPrereqListener>>();
			set => SetPropertyValue<CHandle<BaseStatPoolPrereqListener>>(value);
		}

		[Ordinal(1)] 
		[RED("inventoryCallback")] 
		public CHandle<StatPoolPrereqInventoryScriptCallback> InventoryCallback
		{
			get => GetPropertyValue<CHandle<StatPoolPrereqInventoryScriptCallback>>();
			set => SetPropertyValue<CHandle<StatPoolPrereqInventoryScriptCallback>>(value);
		}

		[Ordinal(2)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(3)] 
		[RED("statpoolWasMissing")] 
		public CBool StatpoolWasMissing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("statsObjID")] 
		public gameStatsObjectID StatsObjID
		{
			get => GetPropertyValue<gameStatsObjectID>();
			set => SetPropertyValue<gameStatsObjectID>(value);
		}

		public StatPoolPrereqState()
		{
			StatsObjID = new() { IdType = Enums.gameStatIDType.Invalid };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
