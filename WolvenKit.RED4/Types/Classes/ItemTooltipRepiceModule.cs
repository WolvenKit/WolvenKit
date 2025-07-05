using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipRepiceModule : ItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ItemTooltipRepiceModule()
		{
			ItemNameText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
