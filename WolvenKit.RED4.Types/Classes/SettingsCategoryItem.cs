using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsCategoryItem : inkListItemController
	{
		[Ordinal(16)] 
		[RED("labelHighlight")] 
		public inkTextWidgetReference LabelHighlight
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public SettingsCategoryItem()
		{
			LabelHighlight = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
