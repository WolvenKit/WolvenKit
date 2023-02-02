using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryStatsDisplay : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("StatsRoot")] 
		public inkCompoundWidgetReference StatsRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("StatItemName")] 
		public CName StatItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("StatItems")] 
		public CArray<CWeakHandle<InventoryStatItemV2>> StatItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<InventoryStatItemV2>>>();
			set => SetPropertyValue<CArray<CWeakHandle<InventoryStatItemV2>>>(value);
		}

		public InventoryStatsDisplay()
		{
			StatsRoot = new();
			StatItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
