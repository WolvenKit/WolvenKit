using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiAdvertTranslationController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _advertText;

		[Ordinal(2)] 
		[RED("advertText")] 
		public inkTextWidgetReference AdvertText
		{
			get => GetProperty(ref _advertText);
			set => SetProperty(ref _advertText, value);
		}
	}
}
