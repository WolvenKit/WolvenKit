using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NewsFeedMenuWidgetController : inkWidgetLogicController
	{
		private CName _bannersListWidgetPath;
		private inkWidgetReference _bannersListWidget;
		private CBool _isInitialized;
		private CArray<SBannerWidgetPackage> _bannerWidgetsData;
		private SBannerWidgetPackage _fullBannerWidgetData;

		[Ordinal(1)] 
		[RED("bannersListWidgetPath")] 
		public CName BannersListWidgetPath
		{
			get => GetProperty(ref _bannersListWidgetPath);
			set => SetProperty(ref _bannersListWidgetPath, value);
		}

		[Ordinal(2)] 
		[RED("bannersListWidget")] 
		public inkWidgetReference BannersListWidget
		{
			get => GetProperty(ref _bannersListWidget);
			set => SetProperty(ref _bannersListWidget, value);
		}

		[Ordinal(3)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(4)] 
		[RED("bannerWidgetsData")] 
		public CArray<SBannerWidgetPackage> BannerWidgetsData
		{
			get => GetProperty(ref _bannerWidgetsData);
			set => SetProperty(ref _bannerWidgetsData, value);
		}

		[Ordinal(5)] 
		[RED("fullBannerWidgetData")] 
		public SBannerWidgetPackage FullBannerWidgetData
		{
			get => GetProperty(ref _fullBannerWidgetData);
			set => SetProperty(ref _fullBannerWidgetData, value);
		}

		public NewsFeedMenuWidgetController()
		{
			_bannersListWidgetPath = "banners";
		}
	}
}
