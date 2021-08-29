using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ThumbnailUI : ActionBool
	{
		private SThumbnailWidgetPackage _thumbnailWidgetPackage;

		[Ordinal(25)] 
		[RED("thumbnailWidgetPackage")] 
		public SThumbnailWidgetPackage ThumbnailWidgetPackage
		{
			get => GetProperty(ref _thumbnailWidgetPackage);
			set => SetProperty(ref _thumbnailWidgetPackage, value);
		}
	}
}
