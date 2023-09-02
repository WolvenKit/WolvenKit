using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipHeaderController : ItemTooltipModuleController
	{
		[Ordinal(4)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("localizedIconicText")] 
		public CString LocalizedIconicText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public ItemTooltipHeaderController()
		{
			ItemNameText = new inkTextWidgetReference();
			ItemRarityText = new inkTextWidgetReference();
			ItemTypeText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
