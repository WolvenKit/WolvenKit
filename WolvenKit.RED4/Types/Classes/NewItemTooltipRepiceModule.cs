using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipRepiceModule : NewItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public NewItemTooltipRepiceModule()
		{
			ItemNameText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
