using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerksLevelBarController : inkWidgetLogicController
	{
		private inkWidgetReference _foregroundImage;
		private inkWidgetReference _backgroundImage;

		[Ordinal(1)] 
		[RED("foregroundImage")] 
		public inkWidgetReference ForegroundImage
		{
			get => GetProperty(ref _foregroundImage);
			set => SetProperty(ref _foregroundImage, value);
		}

		[Ordinal(2)] 
		[RED("backgroundImage")] 
		public inkWidgetReference BackgroundImage
		{
			get => GetProperty(ref _backgroundImage);
			set => SetProperty(ref _backgroundImage, value);
		}
	}
}
