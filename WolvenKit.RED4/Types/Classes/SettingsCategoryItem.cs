using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsCategoryItem : inkListItemController
	{
		[Ordinal(19)] 
		[RED("labelHighlight")] 
		public inkTextWidgetReference LabelHighlight
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public SettingsCategoryItem()
		{
			LabelHighlight = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
