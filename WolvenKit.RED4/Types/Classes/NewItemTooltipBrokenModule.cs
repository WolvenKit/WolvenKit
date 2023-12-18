using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipBrokenModule : NewItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public NewItemTooltipBrokenModule()
		{
			DescriptionText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
