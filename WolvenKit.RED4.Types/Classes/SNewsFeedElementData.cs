using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SNewsFeedElementData : RedBaseClass
	{
		private CArray<SsimpleBanerData> _banners;
		private CInt32 _currentBanner;

		[Ordinal(0)] 
		[RED("banners")] 
		public CArray<SsimpleBanerData> Banners
		{
			get => GetProperty(ref _banners);
			set => SetProperty(ref _banners, value);
		}

		[Ordinal(1)] 
		[RED("currentBanner")] 
		public CInt32 CurrentBanner
		{
			get => GetProperty(ref _currentBanner);
			set => SetProperty(ref _currentBanner, value);
		}
	}
}
