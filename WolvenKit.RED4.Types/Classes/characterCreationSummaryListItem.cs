using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class characterCreationSummaryListItem : inkListItemController
	{
		[Ordinal(16)] 
		[RED("headerLabel")] 
		public inkTextWidgetReference HeaderLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("descLabel")] 
		public inkTextWidgetReference DescLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("data")] 
		public CHandle<CharacterCreationSummaryListItemData> Data
		{
			get => GetPropertyValue<CHandle<CharacterCreationSummaryListItemData>>();
			set => SetPropertyValue<CHandle<CharacterCreationSummaryListItemData>>(value);
		}

		public characterCreationSummaryListItem()
		{
			HeaderLabel = new();
			DescLabel = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
