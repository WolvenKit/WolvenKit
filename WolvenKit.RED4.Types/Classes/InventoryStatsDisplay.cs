using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryStatsDisplay : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _statsRoot;
		private CName _statItemName;
		private CArray<CWeakHandle<InventoryStatItemV2>> _statItems;

		[Ordinal(1)] 
		[RED("StatsRoot")] 
		public inkCompoundWidgetReference StatsRoot
		{
			get => GetProperty(ref _statsRoot);
			set => SetProperty(ref _statsRoot, value);
		}

		[Ordinal(2)] 
		[RED("StatItemName")] 
		public CName StatItemName
		{
			get => GetProperty(ref _statItemName);
			set => SetProperty(ref _statItemName, value);
		}

		[Ordinal(3)] 
		[RED("StatItems")] 
		public CArray<CWeakHandle<InventoryStatItemV2>> StatItems
		{
			get => GetProperty(ref _statItems);
			set => SetProperty(ref _statItems, value);
		}
	}
}
