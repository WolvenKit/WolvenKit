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
		[RED("Properties")] 
		public CHandle<UIItemStatProperties> Properties
		{
			get => GetPropertyValue<CHandle<UIItemStatProperties>>();
			set => SetPropertyValue<CHandle<UIItemStatProperties>>(value);
		}

		public UIInventoryItemStat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
