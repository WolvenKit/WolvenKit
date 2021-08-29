using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationSummaryListItem : inkListItemController
	{
		private inkTextWidgetReference _headerLabel;
		private inkTextWidgetReference _descLabel;
		private CHandle<CharacterCreationSummaryListItemData> _data;

		[Ordinal(16)] 
		[RED("headerLabel")] 
		public inkTextWidgetReference HeaderLabel
		{
			get => GetProperty(ref _headerLabel);
			set => SetProperty(ref _headerLabel, value);
		}

		[Ordinal(17)] 
		[RED("descLabel")] 
		public inkTextWidgetReference DescLabel
		{
			get => GetProperty(ref _descLabel);
			set => SetProperty(ref _descLabel, value);
		}

		[Ordinal(18)] 
		[RED("data")] 
		public CHandle<CharacterCreationSummaryListItemData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
