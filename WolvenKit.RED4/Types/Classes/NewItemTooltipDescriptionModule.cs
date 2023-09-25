using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipDescriptionModule : NewItemTooltipModuleController
	{
		[Ordinal(4)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("defaultMargin")] 
		public inkMargin DefaultMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		public NewItemTooltipDescriptionModule()
		{
			DescriptionText = new inkTextWidgetReference();
			DefaultMargin = new inkMargin();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
