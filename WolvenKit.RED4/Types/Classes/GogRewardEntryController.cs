using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GogRewardEntryController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("nameWidget")] 
		public inkWidgetReference NameWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("descriptionWidget")] 
		public inkWidgetReference DescriptionWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("iconImage")] 
		public inkImageWidgetReference IconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public GogRewardEntryController()
		{
			NameWidget = new();
			DescriptionWidget = new();
			IconImage = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
