using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GogRewardEntryController : inkWidgetLogicController
	{
		private inkWidgetReference _nameWidget;
		private inkWidgetReference _descriptionWidget;
		private inkImageWidgetReference _iconImage;

		[Ordinal(1)] 
		[RED("nameWidget")] 
		public inkWidgetReference NameWidget
		{
			get => GetProperty(ref _nameWidget);
			set => SetProperty(ref _nameWidget, value);
		}

		[Ordinal(2)] 
		[RED("descriptionWidget")] 
		public inkWidgetReference DescriptionWidget
		{
			get => GetProperty(ref _descriptionWidget);
			set => SetProperty(ref _descriptionWidget, value);
		}

		[Ordinal(3)] 
		[RED("iconImage")] 
		public inkImageWidgetReference IconImage
		{
			get => GetProperty(ref _iconImage);
			set => SetProperty(ref _iconImage, value);
		}
	}
}
