using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiNewsFeedDataProvider : IScriptable
	{
		[Ordinal(0)] 
		[RED("newsTitleTweak")] 
		public TweakDBID NewsTitleTweak
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("randomNewsFeedPack")] 
		public TweakDBID RandomNewsFeedPack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameuiNewsFeedDataProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
