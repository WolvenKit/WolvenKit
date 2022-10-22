using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemStatsManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("Stats")] 
		public CArray<CHandle<UIInventoryItemStat>> Stats
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItemStat>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItemStat>>>(value);
		}

		[Ordinal(1)] 
		[RED("manager")] 
		public CWeakHandle<UIInventoryItemsManager> Manager
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItemsManager>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItemsManager>>(value);
		}

		public UIInventoryItemStatsManager()
		{
			Stats = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
