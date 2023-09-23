using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationSummaryListItem : inkListItemController
	{
		[Ordinal(19)] 
		[RED("headerLabel")] 
		public inkTextWidgetReference HeaderLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("descLabel")] 
		public inkTextWidgetReference DescLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("data")] 
		public CHandle<CharacterCreationSummaryListItemData> Data
		{
			get => GetPropertyValue<CHandle<CharacterCreationSummaryListItemData>>();
			set => SetPropertyValue<CHandle<CharacterCreationSummaryListItemData>>(value);
		}

		public characterCreationSummaryListItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
