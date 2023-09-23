using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewsFeedMenuWidgetController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("bannersListWidgetPath")] 
		public CName BannersListWidgetPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("bannersListWidget")] 
		public inkWidgetReference BannersListWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("bannerWidgetsData")] 
		public CArray<SBannerWidgetPackage> BannerWidgetsData
		{
			get => GetPropertyValue<CArray<SBannerWidgetPackage>>();
			set => SetPropertyValue<CArray<SBannerWidgetPackage>>(value);
		}

		[Ordinal(5)] 
		[RED("fullBannerWidgetData")] 
		public SBannerWidgetPackage FullBannerWidgetData
		{
			get => GetPropertyValue<SBannerWidgetPackage>();
			set => SetPropertyValue<SBannerWidgetPackage>(value);
		}

		public NewsFeedMenuWidgetController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
