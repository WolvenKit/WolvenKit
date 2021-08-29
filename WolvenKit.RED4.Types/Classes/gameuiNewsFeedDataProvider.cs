using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiNewsFeedDataProvider : IScriptable
	{
		private TweakDBID _newsTitleTweak;
		private TweakDBID _randomNewsFeedPack;

		[Ordinal(0)] 
		[RED("newsTitleTweak")] 
		public TweakDBID NewsTitleTweak
		{
			get => GetProperty(ref _newsTitleTweak);
			set => SetProperty(ref _newsTitleTweak, value);
		}

		[Ordinal(1)] 
		[RED("randomNewsFeedPack")] 
		public TweakDBID RandomNewsFeedPack
		{
			get => GetProperty(ref _randomNewsFeedPack);
			set => SetProperty(ref _randomNewsFeedPack, value);
		}
	}
}
