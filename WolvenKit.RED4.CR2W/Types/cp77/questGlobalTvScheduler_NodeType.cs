using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questGlobalTvScheduler_NodeType : questIUIManagerNodeType
	{
		private TweakDBID _channelId;
		private raRef<inkWidgetLibraryResource> _overlayResource;
		private raRef<Bink> _videoResource;
		private raRef<scnSceneResource> _vOScene;
		private CName _audioEvent;
		private TweakDBID _newsTitleTweak;
		private TweakDBID _randomNewsFeedPack;

		[Ordinal(0)] 
		[RED("channelId")] 
		public TweakDBID ChannelId
		{
			get => GetProperty(ref _channelId);
			set => SetProperty(ref _channelId, value);
		}

		[Ordinal(1)] 
		[RED("overlayResource")] 
		public raRef<inkWidgetLibraryResource> OverlayResource
		{
			get => GetProperty(ref _overlayResource);
			set => SetProperty(ref _overlayResource, value);
		}

		[Ordinal(2)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get => GetProperty(ref _videoResource);
			set => SetProperty(ref _videoResource, value);
		}

		[Ordinal(3)] 
		[RED("VOScene")] 
		public raRef<scnSceneResource> VOScene
		{
			get => GetProperty(ref _vOScene);
			set => SetProperty(ref _vOScene, value);
		}

		[Ordinal(4)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetProperty(ref _audioEvent);
			set => SetProperty(ref _audioEvent, value);
		}

		[Ordinal(5)] 
		[RED("newsTitleTweak")] 
		public TweakDBID NewsTitleTweak
		{
			get => GetProperty(ref _newsTitleTweak);
			set => SetProperty(ref _newsTitleTweak, value);
		}

		[Ordinal(6)] 
		[RED("randomNewsFeedPack")] 
		public TweakDBID RandomNewsFeedPack
		{
			get => GetProperty(ref _randomNewsFeedPack);
			set => SetProperty(ref _randomNewsFeedPack, value);
		}

		public questGlobalTvScheduler_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
