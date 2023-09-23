using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerBannerWidgetController : DeviceInkLogicControllerBase
	{
		[Ordinal(5)] 
		[RED("titleWidget")] 
		public inkTextWidgetReference TitleWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("textContentWidget")] 
		public inkTextWidgetReference TextContentWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("videoContentWidget")] 
		public inkVideoWidgetReference VideoContentWidget
		{
			get => GetPropertyValue<inkVideoWidgetReference>();
			set => SetPropertyValue<inkVideoWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("imageContentWidget")] 
		public inkImageWidgetReference ImageContentWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("bannerButtonWidget")] 
		public inkWidgetReference BannerButtonWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("bannerData")] 
		public SBannerWidgetPackage BannerData
		{
			get => GetPropertyValue<SBannerWidgetPackage>();
			set => SetPropertyValue<SBannerWidgetPackage>(value);
		}

		[Ordinal(11)] 
		[RED("lastPlayedVideo")] 
		public redResourceReferenceScriptToken LastPlayedVideo
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public ComputerBannerWidgetController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
