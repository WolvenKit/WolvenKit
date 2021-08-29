using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingsCategoryItem : inkListItemController
	{
		private inkTextWidgetReference _labelHighlight;

		[Ordinal(16)] 
		[RED("labelHighlight")] 
		public inkTextWidgetReference LabelHighlight
		{
			get => GetProperty(ref _labelHighlight);
			set => SetProperty(ref _labelHighlight, value);
		}
	}
}
