using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questGlobalTvScheduler_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("channelId")] 
		public TweakDBID ChannelId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("overlayResource")] 
		public CResourceAsyncReference<inkWidgetLibraryResource> OverlayResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkWidgetLibraryResource>>(value);
		}

		[Ordinal(2)] 
		[RED("videoResource")] 
		public CResourceAsyncReference<Bink> VideoResource
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(3)] 
		[RED("VOScene")] 
		public CResourceAsyncReference<scnSceneResource> VOScene
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(4)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("newsTitleTweak")] 
		public TweakDBID NewsTitleTweak
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("randomNewsFeedPack")] 
		public TweakDBID RandomNewsFeedPack
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questGlobalTvScheduler_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
