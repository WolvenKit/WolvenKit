using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SNewsFeedElementData : CVariable
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

		public SNewsFeedElementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
