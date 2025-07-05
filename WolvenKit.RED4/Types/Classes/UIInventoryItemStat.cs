using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemStat : IScriptable
	{
		[Ordinal(0)] 
		[RED("Type")] 
		public CEnum<gamedataStatType> Type
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("Value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("PropertiesProvider")] 
		public CHandle<IUIInventoryItemStatsProvider> PropertiesProvider
		{
			get => GetPropertyValue<CHandle<IUIInventoryItemStatsProvider>>();
			set => SetPropertyValue<CHandle<IUIInventoryItemStatsProvider>>(value);
		}

		[Ordinal(3)] 
		[RED("properties")] 
		public CHandle<UIItemStatProperties> Properties
		{
			get => GetPropertyValue<CHandle<UIItemStatProperties>>();
			set => SetPropertyValue<CHandle<UIItemStatProperties>>(value);
		}

		[Ordinal(4)] 
		[RED("propertiesFetched")] 
		public CBool PropertiesFetched
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UIInventoryItemStat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
