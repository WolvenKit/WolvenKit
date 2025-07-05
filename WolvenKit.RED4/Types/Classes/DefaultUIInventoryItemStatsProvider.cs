using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DefaultUIInventoryItemStatsProvider : IUIInventoryItemStatsProvider
	{
		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("manager")] 
		public CWeakHandle<UIInventoryItemsManager> Manager
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItemsManager>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItemsManager>>(value);
		}

		public DefaultUIInventoryItemStatsProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
