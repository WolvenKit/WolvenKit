using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SNewsFeedElementData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("banners")] 
		public CArray<SsimpleBanerData> Banners
		{
			get => GetPropertyValue<CArray<SsimpleBanerData>>();
			set => SetPropertyValue<CArray<SsimpleBanerData>>(value);
		}

		[Ordinal(1)] 
		[RED("currentBanner")] 
		public CInt32 CurrentBanner
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SNewsFeedElementData()
		{
			Banners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
